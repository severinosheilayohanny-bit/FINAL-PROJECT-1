using System;
using System.Linq;
using System.Windows.Forms;
using MySpaLibrary.Database;
using MySpaLibrary.Helpers;
using MySpaLibrary.Models;

namespace SpaUserInterface
{
    public partial class Form1 : Form
    {
        private ClientManager _clientMgr;
        private AppointmentManager _apptMgr;
        private EmployeeManager _employeeMgr;
        private SpaDbContext _db;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (var dbContext = new SpaDbContext())
                {
                    var clientMgr = new ClientManager(dbContext);
                    var apptMgr = new AppointmentManager(dbContext);
                    int clientCount = clientMgr.ListClients().Count;

                    int apptsUpcoming = apptMgr.ListAppointments()
                        .Count(a => a.StartAt.Date >= DateTime.Today.Date && a.Status == AppointmentStatus.Scheduled);
                    decimal pendingAmount = apptMgr.ListCommissions()
                        .Where(c => c.Paid == false)
                        .Sum(c => c.Amount);
                    decimal totalRevenue = apptMgr.ListPayments().Sum(p => p.Amount);

                    lblTotalClientsCount.Text = clientCount.ToString();
                    lblTodayApptsCount.Text = apptsUpcoming.ToString();
                    lblPendingCommissionsAmount.Text = pendingAmount.ToString("C");
                    lblTotalRevenueAmount.Text = totalRevenue.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Failed to load Dashboard data. SQL Details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(tcMain);
            LoadDashboardData();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            using (var dbContext = new SpaDbContext())
            {
                ClientModule clientView = new ClientModule(dbContext);
                clientView.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(clientView);
            }
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            using (var dbContext = new MySpaLibrary.Database.SpaDbContext())
            {
                EmployeeModule employeeView = new EmployeeModule(dbContext);
                employeeView.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(employeeView);
            }
        }
        private void btnServices_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            using (var dbContext = new MySpaLibrary.Database.SpaDbContext())
            {
                ServiceModule serviceView = new ServiceModule(dbContext);
                serviceView.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(serviceView);
            }
        }
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            var dbContext = new MySpaLibrary.Database.SpaDbContext();
            AppointmentModule appointmentView = new AppointmentModule(dbContext);
            appointmentView.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(appointmentView);
        }

    }
}