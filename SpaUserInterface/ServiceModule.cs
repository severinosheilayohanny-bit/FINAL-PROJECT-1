using System;
using System.Linq;
using System.Windows.Forms;
using MySpaLibrary.Database;
using MySpaLibrary.Helpers;
using MySpaLibrary.Models;

namespace SpaUserInterface
{
    public partial class ServiceModule : UserControl
    {
        private ServiceManager _serviceMgr;

        public ServiceModule(SpaDbContext dbContext)
        {
            InitializeComponent();
            _serviceMgr = new ServiceManager(dbContext);
            LoadServicesGrid();
        }
        private void LoadServicesGrid()
        {
            try
            {
                using (var dbContext = new SpaDbContext())
                {
                    var svcMgr = new ServiceManager(dbContext);

                    var serviceList = svcMgr.ListServices();

                    dgvServices.DataSource = serviceList;
                    dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvServices.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            bool isEditing = (btnAddService.Tag != null);

            using (var dbContext = new SpaDbContext())
            {
                var svcMgr = new ServiceManager(dbContext);

                try
                {
                    string name = txtName.Text.Trim();
                    string description = txtDescription.Text.Trim();
                    string durationText = txtDuration.Text.Trim();
                    string priceText = txtPrice.Text.Trim();
                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(durationText))
                    {
                        MessageBox.Show("Name, Duration, and Price are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!int.TryParse(durationText, out int duration) || duration <= 0)
                    {
                        MessageBox.Show("Duration must be a valid number of minutes.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!decimal.TryParse(priceText, out decimal price) || price <= 0)
                    {
                        MessageBox.Show("Price must be a valid number greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (isEditing)
                    {
                        int serviceId = (int)btnAddService.Tag;
                        var serviceToUpdate = svcMgr.FindById(serviceId);

                        if (serviceToUpdate != null)
                        {
                            serviceToUpdate.Name = name;
                            serviceToUpdate.Description = description;
                            serviceToUpdate.DurationMinutes = duration;
                            serviceToUpdate.Price = price;

                            dbContext.SaveChanges();

                            MessageBox.Show($"Service ID {serviceId} updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        var newService = new MySpaLibrary.Models.Service(
                            id: 0,
                            name: name,
                            description: description,
                            durationMinutes: duration,
                            price: price
                        );

                        svcMgr.AddService(newService);
                        dbContext.SaveChanges();

                        MessageBox.Show($"Service '{name}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txtName.Clear(); txtDescription.Clear();
                    txtDuration.Clear(); txtPrice.Clear();

                    btnAddService.Tag = null;
                    btnAddService.Text = "Add New Service";
                    LoadServicesGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during save or update: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a service row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvServices.SelectedRows[0];

            try
            {
                int serviceId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string serviceName = selectedRow.Cells["Name"].Value.ToString();
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to permanently delete service '{serviceName}' (ID: {serviceId})?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    using (var dbContext = new SpaDbContext())
                    {
                        var svcMgr = new ServiceManager(dbContext);

                        svcMgr.DeleteService(serviceId);
                        dbContext.SaveChanges();

                        MessageBox.Show($"Service {serviceId} has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadServicesGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting service. It might be linked to existing appointments. Details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a service row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvServices.SelectedRows[0];

            try
            {
                int serviceId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                using (var dbContext = new SpaDbContext())
                {
                    var svcMgr = new ServiceManager(dbContext);
                    var serviceToEdit = svcMgr.FindById(serviceId);

                    if (serviceToEdit != null)
                    {
                        txtName.Text = serviceToEdit.Name;
                        txtDescription.Text = serviceToEdit.Description;
                        txtDuration.Text = serviceToEdit.DurationMinutes.ToString();
                        txtPrice.Text = serviceToEdit.Price.ToString();
                        btnAddService.Tag = serviceId;
                        btnAddService.Text = $"Save Changes (Editing ID: {serviceId})";

                        MessageBox.Show($"Editing service {serviceToEdit.Name}. Click 'Save Changes' when done.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing service for edit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}