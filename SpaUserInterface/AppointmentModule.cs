using System;
using System.Linq;
using System.Windows.Forms;
using MySpaLibrary.Database;
using MySpaLibrary.Helpers;
using MySpaLibrary.Models;

namespace SpaUserInterface
{
    public partial class AppointmentModule : UserControl
    {
        private AppointmentManager _apptMgr;
        private ClientManager _clientMgr;
        private EmployeeManager _employeeMgr;
        private ServiceManager _serviceMgr;
        private SpaDbContext _dbContext;

        public AppointmentModule(SpaDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _apptMgr = new AppointmentManager(_dbContext);
            _clientMgr = new ClientManager(_dbContext);
            _employeeMgr = new EmployeeManager(_dbContext);
            _serviceMgr = new ServiceManager(_dbContext);

            PopulateDropDowns();
            LoadAppointmentsGrid();
        }

        private void PopulateDropDowns()
        {
            var clients = _clientMgr.ListClients();
            cbClient.DisplayMember = "GetFullName";
            cbClient.ValueMember = "Id";
            cbClient.DataSource = clients;
            var employees = _employeeMgr.ListEmployees();
            cbEmployee.DisplayMember = "ToString";
            cbEmployee.ValueMember = "Id";
            cbEmployee.DataSource = employees;
            var services = _serviceMgr.ListServices();
            cbService.DisplayMember = "ToString";
            cbService.ValueMember = "Id";
            cbService.DataSource = services;
            cbPaymentMethod.Items.Clear();
            cbPaymentMethod.Items.Add("Cash");
            cbPaymentMethod.Items.Add("Credit Card");
            cbPaymentMethod.Items.Add("Debit Card");
            cbPaymentMethod.Items.Add("Transfer");
            cbPaymentMethod.SelectedIndex = 0;
            dtpStartAt.Format = DateTimePickerFormat.Custom;
            dtpStartAt.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpStartAt.ShowUpDown = true;
        }

        private void LoadAppointmentsGrid()
        {
            try
            {
                var appointmentList = _apptMgr.ListAppointments();

                dgvAppointments.DataSource = appointmentList;
                dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAppointments.ReadOnly = true;
                if (dgvAppointments.Columns.Contains("ClientId")) dgvAppointments.Columns["ClientId"].Visible = false;
                if (dgvAppointments.Columns.Contains("EmployeeId")) dgvAppointments.Columns["EmployeeId"].Visible = false;
                if (dgvAppointments.Columns.Contains("ServiceId")) dgvAppointments.Columns["ServiceId"].Visible = false;
                if (dgvAppointments.Columns.Contains("CreatedAt")) dgvAppointments.Columns["CreatedAt"].Visible = false;
                if (dgvAppointments.Columns.Contains("Client")) dgvAppointments.Columns["Client"].DisplayIndex = 1;
                if (dgvAppointments.Columns.Contains("Employee")) dgvAppointments.Columns["Employee"].DisplayIndex = 2;
                if (dgvAppointments.Columns.Contains("Service")) dgvAppointments.Columns["Service"].DisplayIndex = 3;
                if (dgvAppointments.Columns.Contains("StartAt")) dgvAppointments.Columns["StartAt"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                if (dgvAppointments.Columns.Contains("EndAt")) dgvAppointments.Columns["EndAt"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            bool isEditing = (btnSchedule.Tag != null);

            if (cbClient.SelectedIndex == -1 || cbEmployee.SelectedIndex == -1 || cbService.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Client, Employee, and Service.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int clientId = Convert.ToInt32(cbClient.SelectedValue);
                int employeeId = Convert.ToInt32(cbEmployee.SelectedValue);
                int serviceId = Convert.ToInt32(cbService.SelectedValue);

                DateTime startAt = dtpStartAt.Value;

                if (startAt <= DateTime.Now && !isEditing)
                {
                    MessageBox.Show("The appointment must be scheduled for a future date and time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedService = _serviceMgr.FindById(serviceId);

                if (selectedService == null)
                {
                    MessageBox.Show("Error: Selected service not found.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int durationMinutes = selectedService.DurationMinutes;

                if (isEditing)
                {
                    int appointmentId = (int)btnSchedule.Tag;
                    var appointmentToUpdate = _apptMgr.FindById(appointmentId);

                    if (appointmentToUpdate != null)
                    {
                        appointmentToUpdate.ClientId = clientId;
                        appointmentToUpdate.EmployeeId = employeeId;
                        appointmentToUpdate.ServiceId = serviceId;
                        appointmentToUpdate.StartAt = startAt;
                        appointmentToUpdate.EndAt = startAt.AddMinutes(durationMinutes);

                        bool success = _apptMgr.UpdateAppointment(appointmentToUpdate);

                        if (success)
                        {
                            MessageBox.Show($"Appointment ID {appointmentId} updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Scheduling Conflict: The modified time, client, or employee selection conflicts with an existing appointment.", "Scheduling Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    var newAppointment = new Appointment(
                        id: 0,
                        clientId: clientId,
                        serviceId: serviceId,
                        employeeId: employeeId,
                        startAt: startAt,
                        durationMinutes: durationMinutes
                    );

                    bool success = _apptMgr.ScheduleAppointment(newAppointment);

                    if (success)
                    {
                        MessageBox.Show("Appointment scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Scheduling Conflict: The client or employee is already booked at that time.", "Scheduling Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                ClearInputFields();
                LoadAppointmentsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during scheduling or updating: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment row to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvAppointments.SelectedRows[0];

            try
            {
                int appointmentId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string currentStatus = selectedRow.Cells["Status"].Value.ToString();

                if (currentStatus == AppointmentStatus.Completed.ToString())
                {
                    MessageBox.Show("This appointment is already completed and cannot be cancelled.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to cancel appointment ID: {appointmentId}?",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    _apptMgr.CancelAppointment(appointmentId);

                    MessageBox.Show($"Appointment {appointmentId} has been successfully cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAppointmentsGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling appointment. Details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvAppointments.SelectedRows[0];

            try
            {
                int appointmentId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var appointmentToEdit = _apptMgr.FindById(appointmentId);

                if (appointmentToEdit != null)
                {
                    cbClient.SelectedValue = appointmentToEdit.ClientId;
                    cbEmployee.SelectedValue = appointmentToEdit.EmployeeId;
                    cbService.SelectedValue = appointmentToEdit.ServiceId;

                    dtpStartAt.Value = appointmentToEdit.StartAt;
                    btnSchedule.Tag = appointmentId;
                    btnSchedule.Text = $"SAVE CHANGES (Editing ID: {appointmentId})";

                    MessageBox.Show($"Editing appointment ID: {appointmentId}. Change the details and click 'SAVE CHANGES'.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing appointment for edit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompleteAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0 || cbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an appointment row AND a payment method.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedPaymentMethod = cbPaymentMethod.Text;
            var selectedRow = dgvAppointments.SelectedRows[0];

            try
            {
                int appointmentId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string currentStatus = selectedRow.Cells["Status"].Value.ToString();

                if (currentStatus == AppointmentStatus.Completed.ToString() || currentStatus == AppointmentStatus.Cancelled.ToString())
                {
                    MessageBox.Show($"This appointment is already {currentStatus} and cannot be processed.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to complete appointment ID: {appointmentId}, process payment ({selectedPaymentMethod}), and calculate commission?",
                    "Confirm Completion & Payment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    var ap = _apptMgr.FindById(appointmentId);
                    var employee = _employeeMgr.FindById(ap.EmployeeId);
                    var service = _serviceMgr.FindById(ap.ServiceId);

                    decimal amountPaid = service.Price; 
                    _apptMgr.CompleteAppointment(
                        appointmentId: appointmentId,
                        amountPaid: amountPaid,
                        method: selectedPaymentMethod,
                        emp: employee,
                        svc: service
                    );

                    MessageBox.Show($"Appointment {appointmentId} completed, payment processed ({selectedPaymentMethod}), and commission calculated successfully!", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAppointmentsGrid();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            cbClient.SelectedIndex = -1;
            cbEmployee.SelectedIndex = -1;
            cbService.SelectedIndex = -1;
            cbPaymentMethod.SelectedIndex = 0;
            dtpStartAt.Value = DateTime.Now;
            btnSchedule.Tag = null;
            btnSchedule.Text = "Schedule Appointment";
        }

    }
}