namespace SpaUserInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnServices = new Button();
            btnEmployees = new Button();
            btnAppointments = new Button();
            btnClients = new Button();
            btnDashboard = new Button();
            pnlHeader = new Panel();
            label1 = new Label();
            pnlContent = new Panel();
            tcMain = new TabControl();
            tabPage1 = new TabPage();
            pnlTotalRevenueAmount = new Panel();
            label2 = new Label();
            lblTotalRevenueAmount = new Label();
            pnlPendingCommissions = new Panel();
            lblPendingCommissionsText = new Label();
            lblPendingCommissionsAmount = new Label();
            pnlAppointmentsToday = new Panel();
            lblTodayApptsText = new Label();
            lblTodayApptsCount = new Label();
            pnlClientStat = new Panel();
            lblTotalClientsText = new Label();
            lblTotalClientsCount = new Label();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            tcMain.SuspendLayout();
            tabPage1.SuspendLayout();
            pnlTotalRevenueAmount.SuspendLayout();
            pnlPendingCommissions.SuspendLayout();
            pnlAppointmentsToday.SuspendLayout();
            pnlClientStat.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.Black;
            pnlSidebar.Controls.Add(btnServices);
            pnlSidebar.Controls.Add(btnEmployees);
            pnlSidebar.Controls.Add(btnAppointments);
            pnlSidebar.Controls.Add(btnClients);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(pnlHeader);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(406, 1373);
            pnlSidebar.TabIndex = 0;
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.Lavender;
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.Font = new Font("Microsoft PhagsPa", 13.875F, FontStyle.Bold);
            btnServices.Location = new Point(30, 721);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(338, 86);
            btnServices.TabIndex = 7;
            btnServices.Text = "Services";
            btnServices.UseVisualStyleBackColor = false;
            btnServices.Click += btnServices_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.Lavender;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Microsoft PhagsPa", 13.875F, FontStyle.Bold);
            btnEmployees.Location = new Point(30, 596);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(338, 86);
            btnEmployees.TabIndex = 6;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = Color.Lavender;
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.Font = new Font("Microsoft PhagsPa", 13.875F, FontStyle.Bold);
            btnAppointments.Location = new Point(30, 836);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(338, 86);
            btnAppointments.TabIndex = 3;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnClients
            // 
            btnClients.BackColor = Color.Lavender;
            btnClients.FlatStyle = FlatStyle.Flat;
            btnClients.Font = new Font("Microsoft PhagsPa", 13.875F, FontStyle.Bold);
            btnClients.Location = new Point(30, 470);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(338, 86);
            btnClients.TabIndex = 2;
            btnClients.Text = "Clients";
            btnClients.UseVisualStyleBackColor = false;
            btnClients.Click += btnClients_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Lavender;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft PhagsPa", 13.875F, FontStyle.Bold);
            btnDashboard.Location = new Point(30, 346);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(338, 86);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.SlateBlue;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(406, 143);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 40);
            label1.Name = "label1";
            label1.Size = new Size(279, 62);
            label1.TabIndex = 0;
            label1.Text = "Client's LOGO";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.AppWorkspace;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(406, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1595, 1373);
            pnlContent.TabIndex = 1;
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tabPage1);
            tcMain.Dock = DockStyle.Fill;
            tcMain.Location = new Point(406, 0);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(1595, 1373);
            tcMain.TabIndex = 2;
            tcMain.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Lavender;
            tabPage1.Controls.Add(pnlTotalRevenueAmount);
            tabPage1.Controls.Add(pnlPendingCommissions);
            tabPage1.Controls.Add(pnlAppointmentsToday);
            tabPage1.Controls.Add(pnlClientStat);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1579, 1319);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            // 
            // pnlTotalRevenueAmount
            // 
            pnlTotalRevenueAmount.BackColor = SystemColors.AppWorkspace;
            pnlTotalRevenueAmount.Controls.Add(label2);
            pnlTotalRevenueAmount.Controls.Add(lblTotalRevenueAmount);
            pnlTotalRevenueAmount.Location = new Point(1119, 635);
            pnlTotalRevenueAmount.Name = "pnlTotalRevenueAmount";
            pnlTotalRevenueAmount.Size = new Size(400, 230);
            pnlTotalRevenueAmount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(29, 162);
            label2.Name = "label2";
            label2.Size = new Size(217, 45);
            label2.TabIndex = 2;
            label2.Text = "Total Revenue";
            // 
            // lblTotalRevenueAmount
            // 
            lblTotalRevenueAmount.AutoSize = true;
            lblTotalRevenueAmount.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenueAmount.Location = new Point(29, 28);
            lblTotalRevenueAmount.Name = "lblTotalRevenueAmount";
            lblTotalRevenueAmount.Size = new Size(234, 100);
            lblTotalRevenueAmount.TabIndex = 2;
            lblTotalRevenueAmount.Text = "$0.00";
            // 
            // pnlPendingCommissions
            // 
            pnlPendingCommissions.BackColor = SystemColors.AppWorkspace;
            pnlPendingCommissions.Controls.Add(lblPendingCommissionsText);
            pnlPendingCommissions.Controls.Add(lblPendingCommissionsAmount);
            pnlPendingCommissions.Location = new Point(1119, 341);
            pnlPendingCommissions.Name = "pnlPendingCommissions";
            pnlPendingCommissions.Size = new Size(400, 230);
            pnlPendingCommissions.TabIndex = 2;
            // 
            // lblPendingCommissionsText
            // 
            lblPendingCommissionsText.AutoSize = true;
            lblPendingCommissionsText.Font = new Font("Segoe UI", 12F);
            lblPendingCommissionsText.Location = new Point(29, 162);
            lblPendingCommissionsText.Name = "lblPendingCommissionsText";
            lblPendingCommissionsText.Size = new Size(241, 45);
            lblPendingCommissionsText.TabIndex = 2;
            lblPendingCommissionsText.Text = "Pending Payout";
            // 
            // lblPendingCommissionsAmount
            // 
            lblPendingCommissionsAmount.AutoSize = true;
            lblPendingCommissionsAmount.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCommissionsAmount.Location = new Point(29, 28);
            lblPendingCommissionsAmount.Name = "lblPendingCommissionsAmount";
            lblPendingCommissionsAmount.Size = new Size(234, 100);
            lblPendingCommissionsAmount.TabIndex = 2;
            lblPendingCommissionsAmount.Text = "$0.00";
            // 
            // pnlAppointmentsToday
            // 
            pnlAppointmentsToday.BackColor = SystemColors.AppWorkspace;
            pnlAppointmentsToday.Controls.Add(lblTodayApptsText);
            pnlAppointmentsToday.Controls.Add(lblTodayApptsCount);
            pnlAppointmentsToday.Location = new Point(654, 56);
            pnlAppointmentsToday.Name = "pnlAppointmentsToday";
            pnlAppointmentsToday.Size = new Size(400, 230);
            pnlAppointmentsToday.TabIndex = 1;
            // 
            // lblTodayApptsText
            // 
            lblTodayApptsText.AutoSize = true;
            lblTodayApptsText.Font = new Font("Segoe UI", 12F);
            lblTodayApptsText.Location = new Point(38, 162);
            lblTodayApptsText.Name = "lblTodayApptsText";
            lblTodayApptsText.Size = new Size(323, 45);
            lblTodayApptsText.TabIndex = 1;
            lblTodayApptsText.Text = "Future Appointments";
            // 
            // lblTodayApptsCount
            // 
            lblTodayApptsCount.AutoSize = true;
            lblTodayApptsCount.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayApptsCount.Location = new Point(24, 28);
            lblTodayApptsCount.Name = "lblTodayApptsCount";
            lblTodayApptsCount.Size = new Size(128, 100);
            lblTodayApptsCount.TabIndex = 0;
            lblTodayApptsCount.Text = "00";
            // 
            // pnlClientStat
            // 
            pnlClientStat.BackColor = SystemColors.AppWorkspace;
            pnlClientStat.Controls.Add(lblTotalClientsText);
            pnlClientStat.Controls.Add(lblTotalClientsCount);
            pnlClientStat.Location = new Point(171, 56);
            pnlClientStat.Name = "pnlClientStat";
            pnlClientStat.Size = new Size(400, 230);
            pnlClientStat.TabIndex = 0;
            // 
            // lblTotalClientsText
            // 
            lblTotalClientsText.AutoSize = true;
            lblTotalClientsText.Font = new Font("Segoe UI", 12F);
            lblTotalClientsText.Location = new Point(28, 162);
            lblTotalClientsText.Name = "lblTotalClientsText";
            lblTotalClientsText.Size = new Size(193, 45);
            lblTotalClientsText.TabIndex = 1;
            lblTotalClientsText.Text = "Total Clients";
            // 
            // lblTotalClientsCount
            // 
            lblTotalClientsCount.AutoSize = true;
            lblTotalClientsCount.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalClientsCount.Location = new Point(16, 28);
            lblTotalClientsCount.Name = "lblTotalClientsCount";
            lblTotalClientsCount.Size = new Size(128, 100);
            lblTotalClientsCount.TabIndex = 0;
            lblTotalClientsCount.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(2001, 1373);
            Controls.Add(tcMain);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Name = "Form1";
            Text = "SheiGlow Spa";
            Load += Form1_Load;
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tcMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pnlTotalRevenueAmount.ResumeLayout(false);
            pnlTotalRevenueAmount.PerformLayout();
            pnlPendingCommissions.ResumeLayout(false);
            pnlPendingCommissions.PerformLayout();
            pnlAppointmentsToday.ResumeLayout(false);
            pnlAppointmentsToday.PerformLayout();
            pnlClientStat.ResumeLayout(false);
            pnlClientStat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private TabControl tcMain;
        private TabPage tabPage1;
        private Panel pnlHeader;
        private Button btnAppointments;
        private Button btnClients;
        private Button btnDashboard;
        private Panel pnlPendingCommissions;
        private Panel pnlAppointmentsToday;
        private Panel pnlClientStat;
        private Label lblTodayApptsText;
        private Label lblTodayApptsCount;
        private Label lblTotalClientsText;
        private Label lblTotalClientsCount;
        private Label lblPendingCommissionsText;
        private Label lblPendingCommissionsAmount;
        private Label label1;
        private Button btnServices;
        private Button btnEmployees;
        private Panel pnlTotalRevenueAmount;
        private Label label2;
        private Label lblTotalRevenueAmount;
    }
}
