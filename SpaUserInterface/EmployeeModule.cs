using System;
using System.Windows.Forms;
using MySpaLibrary.Database;
using MySpaLibrary.Helpers;

namespace SpaUserInterface
{
    public partial class EmployeeModule : UserControl
    {
        private EmployeeManager _employeeMgr;

        public EmployeeModule(SpaDbContext dbContext)
        {
            InitializeComponent();

            LoadEmployeesGrid();

            _employeeMgr = new EmployeeManager(dbContext);
            

        }

        private void LoadEmployeesGrid()
        {
            try
            {
                using (var dbContext = new SpaDbContext())
                {
                    var empMgr = new EmployeeManager(dbContext);
                    var employeeList = empMgr.ListEmployees();
                    dgvEmployees.DataSource = employeeList;
                    dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvEmployees.ReadOnly = true;
                    if (dgvEmployees.Columns.Contains("HireDate"))
                    {
                        dgvEmployees.Columns["HireDate"].Visible = false;
                    }
                    if (dgvEmployees.Columns.Contains("CalculateCommission"))
                    {
                        dgvEmployees.Columns["CalculateCommission"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            bool isEditing = (btnAddEmployee.Tag != null);

            using (var dbContext = new SpaDbContext())
            {
                var empMgr = new EmployeeManager(dbContext);

                try
                {
                    string firstName = txtEmpFirstName.Text.Trim();
                    string lastName = txtEmpLastName.Text.Trim();
                    string role = txtEmpRole.Text.Trim();
                    string rateText = txtEmpRate.Text.Trim();

                    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(role))
                    {
                        MessageBox.Show("First Name, Last Name, and Role are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!decimal.TryParse(rateText, out decimal commissionRate) || commissionRate < 0 || commissionRate > 1)
                    {
                        MessageBox.Show("Commission Rate must be a valid number between 0 and 1 (e.g., 0.10 for 10%).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (isEditing)
                    {
                        int employeeId = (int)btnAddEmployee.Tag;
                        var employeeToUpdate = empMgr.FindById(employeeId);

                        if (employeeToUpdate != null)
                        {
                            employeeToUpdate.FirstName = firstName;
                            employeeToUpdate.LastName = lastName;
                            employeeToUpdate.Role = role;
                            employeeToUpdate.CommissionRate = commissionRate;

                            dbContext.SaveChanges();

                            MessageBox.Show($"Employee ID {employeeId} updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        var newEmployee = new MySpaLibrary.Models.Employee(
                            id: 0,
                            firstName: firstName,
                            lastName: lastName,
                            role: role,
                            commissionRate: commissionRate
                        );

                        empMgr.AddEmployee(newEmployee);
                        dbContext.SaveChanges();

                        MessageBox.Show($"Employee {firstName} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txtEmpFirstName.Clear(); txtEmpLastName.Clear();
                    txtEmpRole.Clear(); txtEmpRate.Clear();

                    btnAddEmployee.Tag = null;
                    btnAddEmployee.Text = "Add New Employee";
                    LoadEmployeesGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during save or update: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvEmployees.SelectedRows[0];

            try
            {
                int employeeId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string employeeName = selectedRow.Cells["FirstName"].Value.ToString() + " " + selectedRow.Cells["LastName"].Value.ToString();
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to permanently delete employee {employeeName} (ID: {employeeId})?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    using (var dbContext = new SpaDbContext())
                    {
                        var empMgr = new EmployeeManager(dbContext);

                        empMgr.DeleteEmployee(employeeId);
                        dbContext.SaveChanges();

                        MessageBox.Show($"Employee {employeeId} has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployeesGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting employee. They might have active commissions or appointments. Details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvEmployees.SelectedRows[0];

            try
            {
                int employeeId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                using (var dbContext = new SpaDbContext())
                {
                    var empMgr = new EmployeeManager(dbContext);
                    var employeeToEdit = empMgr.FindById(employeeId);

                    if (employeeToEdit != null)
                    {
                        txtEmpFirstName.Text = employeeToEdit.FirstName;
                        txtEmpLastName.Text = employeeToEdit.LastName;
                        txtEmpRole.Text = employeeToEdit.Role;
                        txtEmpRate.Text = employeeToEdit.CommissionRate.ToString();
                        btnAddEmployee.Tag = employeeId;
                        btnAddEmployee.Text = $"Save Changes (Editing ID: {employeeId})";

                        MessageBox.Show($"Editing employee {employeeToEdit.FirstName}. Click 'Save Changes' when done.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing employee for edit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}