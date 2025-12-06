using System;
using System.Linq;
using System.Windows.Forms;
using MySpaLibrary.Database;
using MySpaLibrary.Helpers;
using MySpaLibrary.Models;

namespace SpaUserInterface
{
    public partial class ClientModule : UserControl
    {
        private ClientManager _clientMgr;

        public ClientModule(SpaDbContext dbContext)
        {
            InitializeComponent();

            LoadClientsGrid();

            _clientMgr = new ClientManager(dbContext);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            bool isEditing = (btnAddClient.Tag != null);

            using (var dbContext = new SpaDbContext())
            {
                var clientMgr = new ClientManager(dbContext);

                try
                {
                    string firstName = txtFirstName.Text.Trim();
                    string lastName = txtLastName.Text.Trim();
                    string phone = txtPhone.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string document = txtDocument.Text.Trim();
                    string address = txtAddress.Text.Trim();

                    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone))
                    {
                        MessageBox.Show("First Name, Last Name, and Phone are required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (isEditing)
                    {
                        int clientId = (int)btnAddClient.Tag;
                        var clientToUpdate = clientMgr.FindById(clientId);

                        if (clientToUpdate != null)
                        {
                            clientToUpdate.FirstName = firstName;
                            clientToUpdate.LastName = lastName;
                            clientToUpdate.Document = document;
                            clientToUpdate.Phone = phone;
                            clientToUpdate.Email = email;
                            clientToUpdate.Address = address;
                            dbContext.SaveChanges();

                            MessageBox.Show($"Client ID {clientId} updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        var newClient = new MySpaLibrary.Models.Client(
                            id: 0,
                            firstName: firstName,
                            lastName: lastName,
                            document: document,
                            phone: phone,
                            email: email,
                            address: address
                        );

                        clientMgr.AddClient(newClient);
                        dbContext.SaveChanges();

                        MessageBox.Show($"Client {firstName} {lastName} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhone.Clear();
                    txtEmail.Clear();
                    txtDocument.Clear();
                    txtAddress.Clear();
                    btnAddClient.Tag = null;
                    btnAddClient.Text = "Add New Client";
                    LoadClientsGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during save or update: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadClientsGrid()
        {
            try
            {
                using (var dbContext = new SpaDbContext())
                {
                    var clientMgr = new ClientManager(dbContext);
                    var clientList = clientMgr.ListClients();
                    dgvClients.DataSource = clientList;
                    dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgvClients.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading client data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a client row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedRow = dgvClients.SelectedRows[0];

            try
            {
                int clientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string clientName = selectedRow.Cells["FirstName"].Value.ToString() + " " + selectedRow.Cells["LastName"].Value.ToString();
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to permanently delete client {clientName} (ID: {clientId})?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    using (var dbContext = new SpaDbContext())
                    {
                        var clientMgr = new ClientManager(dbContext);
                        clientMgr.DeleteClient(clientId);
                        dbContext.SaveChanges(); 

                        MessageBox.Show($"Client {clientId} has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClientsGrid(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting client. The data might be linked to appointments. Details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a client row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedRow = dgvClients.SelectedRows[0];

            try
            {
                int clientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                using (var dbContext = new SpaDbContext())
                {
                    var clientMgr = new ClientManager(dbContext);
                    var clientToEdit = clientMgr.FindById(clientId);

                    if (clientToEdit != null)
                    {
                        txtFirstName.Text = clientToEdit.FirstName;
                        txtLastName.Text = clientToEdit.LastName;
                        txtDocument.Text = clientToEdit.Document;
                        txtPhone.Text = clientToEdit.Phone;
                        txtEmail.Text = clientToEdit.Email;
                        txtAddress.Text = clientToEdit.Address;
                        btnAddClient.Text = $"Save Changes (Editing ID: {clientId})"; 
                        btnAddClient.Tag = clientId;

                        MessageBox.Show($"Editing client {clientToEdit.FirstName}. Click 'Save Changes' when done.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing client for edit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}