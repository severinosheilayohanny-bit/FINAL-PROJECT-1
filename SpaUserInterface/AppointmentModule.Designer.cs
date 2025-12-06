namespace SpaUserInterface
{
    partial class AppointmentModule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnCompleteAppointment = new Button();
            button1 = new Button();
            btnCancelAppointment = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            dgvAppointments = new DataGridView();
            btnSchedule = new Button();
            dtpStartAt = new DateTimePicker();
            cbService = new ComboBox();
            cbEmployee = new ComboBox();
            cbClient = new ComboBox();
            label5 = new Label();
            cbPaymentMethod = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(cbPaymentMethod);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnCompleteAppointment);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCancelAppointment);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dgvAppointments);
            panel1.Controls.Add(btnSchedule);
            panel1.Controls.Add(dtpStartAt);
            panel1.Controls.Add(cbService);
            panel1.Controls.Add(cbEmployee);
            panel1.Controls.Add(cbClient);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2289, 1471);
            panel1.TabIndex = 0;
            // 
            // btnCompleteAppointment
            // 
            btnCompleteAppointment.BackColor = SystemColors.ControlLight;
            btnCompleteAppointment.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompleteAppointment.ForeColor = SystemColors.ActiveCaptionText;
            btnCompleteAppointment.Location = new Point(1037, 740);
            btnCompleteAppointment.Name = "btnCompleteAppointment";
            btnCompleteAppointment.Size = new Size(569, 70);
            btnCompleteAppointment.TabIndex = 24;
            btnCompleteAppointment.Text = "💰Process Payment";
            btnCompleteAppointment.TextAlign = ContentAlignment.MiddleLeft;
            btnCompleteAppointment.UseVisualStyleBackColor = false;
            btnCompleteAppointment.Click += btnCompleteAppointment_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1037, 538);
            button1.Name = "button1";
            button1.Size = new Size(569, 70);
            button1.TabIndex = 23;
            button1.Text = "✒️Edit Appointment";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnEditAppointment_Click;
            // 
            // btnCancelAppointment
            // 
            btnCancelAppointment.BackColor = SystemColors.ControlLight;
            btnCancelAppointment.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelAppointment.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelAppointment.Location = new Point(1037, 638);
            btnCancelAppointment.Name = "btnCancelAppointment";
            btnCancelAppointment.Size = new Size(569, 70);
            btnCancelAppointment.TabIndex = 22;
            btnCancelAppointment.Text = "❌Cancel Appointment";
            btnCancelAppointment.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelAppointment.UseVisualStyleBackColor = false;
            btnCancelAppointment.Click += btnCancelAppointment_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(75, 770);
            label4.Name = "label4";
            label4.Size = new Size(360, 59);
            label4.TabIndex = 21;
            label4.Text = "Start Date/Time:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(75, 614);
            label3.Name = "label3";
            label3.Size = new Size(182, 59);
            label3.TabIndex = 20;
            label3.Text = "Service:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(75, 452);
            label2.Name = "label2";
            label2.Size = new Size(233, 59);
            label2.TabIndex = 19;
            label2.Text = "Employee:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(75, 279);
            label1.Name = "label1";
            label1.Size = new Size(154, 59);
            label1.TabIndex = 18;
            label1.Text = "Client:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(702, 59);
            label7.Name = "label7";
            label7.Size = new Size(691, 119);
            label7.TabIndex = 17;
            label7.Text = "APPOINTMENT";
            // 
            // dgvAppointments
            // 
            dgvAppointments.BackgroundColor = Color.Lavender;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvAppointments.DefaultCellStyle = dataGridViewCellStyle1;
            dgvAppointments.Dock = DockStyle.Bottom;
            dgvAppointments.Location = new Point(0, 1038);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 82;
            dgvAppointments.Size = new Size(2289, 433);
            dgvAppointments.TabIndex = 5;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = SystemColors.ControlLight;
            btnSchedule.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSchedule.ForeColor = SystemColors.ActiveCaptionText;
            btnSchedule.Location = new Point(1037, 441);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(569, 70);
            btnSchedule.TabIndex = 4;
            btnSchedule.Text = "✔️Schedule Appointment";
            btnSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // dtpStartAt
            // 
            dtpStartAt.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartAt.Location = new Point(75, 850);
            dtpStartAt.Name = "dtpStartAt";
            dtpStartAt.Size = new Size(552, 39);
            dtpStartAt.TabIndex = 3;
            // 
            // cbService
            // 
            cbService.FormattingEnabled = true;
            cbService.Location = new Point(75, 688);
            cbService.Name = "cbService";
            cbService.Size = new Size(793, 40);
            cbService.TabIndex = 2;
            // 
            // cbEmployee
            // 
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(75, 529);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(793, 40);
            cbEmployee.TabIndex = 1;
            // 
            // cbClient
            // 
            cbClient.FormattingEnabled = true;
            cbClient.Location = new Point(75, 358);
            cbClient.Name = "cbClient";
            cbClient.Size = new Size(793, 40);
            cbClient.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(1037, 825);
            label5.Name = "label5";
            label5.Size = new Size(227, 37);
            label5.TabIndex = 25;
            label5.Text = "Payment Method:";
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Location = new Point(1286, 822);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(320, 40);
            cbPaymentMethod.TabIndex = 26;
            // 
            // AppointmentModule
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AppointmentModule";
            Size = new Size(2289, 1471);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvAppointments;
        private Button btnSchedule;
        private DateTimePicker dtpStartAt;
        private ComboBox cbService;
        private ComboBox cbEmployee;
        private ComboBox cbClient;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnCancelAppointment;
        private Button button1;
        private Button btnCompleteAppointment;
        private Label label5;
        private ComboBox cbPaymentMethod;
    }
}
