namespace SpaUserInterface
{
    partial class EmployeeModule
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
            label1 = new Label();
            txtEmpFirstName = new TextBox();
            txtEmpLastName = new TextBox();
            label2 = new Label();
            txtEmpRate = new TextBox();
            label3 = new Label();
            txtEmpRole = new TextBox();
            label4 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            dgvEmployees = new DataGridView();
            btnEditEmployee = new Button();
            btnDeleteEmployee = new Button();
            btnAddEmployee = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label1.Location = new Point(101, 346);
            label1.Name = "label1";
            label1.Size = new Size(220, 50);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // txtEmpFirstName
            // 
            txtEmpFirstName.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmpFirstName.Location = new Point(448, 346);
            txtEmpFirstName.Name = "txtEmpFirstName";
            txtEmpFirstName.Size = new Size(310, 43);
            txtEmpFirstName.TabIndex = 1;
            // 
            // txtEmpLastName
            // 
            txtEmpLastName.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmpLastName.Location = new Point(448, 419);
            txtEmpLastName.Name = "txtEmpLastName";
            txtEmpLastName.Size = new Size(310, 43);
            txtEmpLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label2.Location = new Point(101, 419);
            label2.Name = "label2";
            label2.Size = new Size(214, 50);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // txtEmpRate
            // 
            txtEmpRate.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmpRate.Location = new Point(448, 561);
            txtEmpRate.Name = "txtEmpRate";
            txtEmpRate.Size = new Size(310, 43);
            txtEmpRate.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label3.Location = new Point(101, 561);
            label3.Name = "label3";
            label3.Size = new Size(333, 50);
            label3.TabIndex = 6;
            label3.Text = "Commission Rate:";
            // 
            // txtEmpRole
            // 
            txtEmpRole.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmpRole.Location = new Point(448, 488);
            txtEmpRole.Name = "txtEmpRole";
            txtEmpRole.Size = new Size(310, 43);
            txtEmpRole.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label4.Location = new Point(101, 488);
            label4.Name = "label4";
            label4.Size = new Size(109, 50);
            label4.TabIndex = 4;
            label4.Text = "Role:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(668, 79);
            label7.Name = "label7";
            label7.Size = new Size(847, 119);
            label7.TabIndex = 15;
            label7.Text = "Employee Section";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dgvEmployees);
            panel1.Controls.Add(btnEditEmployee);
            panel1.Controls.Add(btnDeleteEmployee);
            panel1.Controls.Add(btnAddEmployee);
            panel1.Controls.Add(txtEmpLastName);
            panel1.Controls.Add(txtEmpRate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEmpFirstName);
            panel1.Controls.Add(txtEmpRole);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2252, 1435);
            panel1.TabIndex = 16;
            // 
            // dgvEmployees
            // 
            dgvEmployees.BackgroundColor = SystemColors.Control;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Dock = DockStyle.Bottom;
            dgvEmployees.Location = new Point(0, 894);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 82;
            dgvEmployees.Size = new Size(2252, 541);
            dgvEmployees.TabIndex = 11;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = SystemColors.Menu;
            btnEditEmployee.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditEmployee.Location = new Point(976, 515);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(607, 96);
            btnEditEmployee.TabIndex = 10;
            btnEditEmployee.Text = "EDIT SELECTED EMPLOYEE";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = SystemColors.Menu;
            btnDeleteEmployee.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteEmployee.Location = new Point(976, 657);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(607, 96);
            btnDeleteEmployee.TabIndex = 9;
            btnDeleteEmployee.Text = "DELETE SELECTED EMPLOYEE";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = SystemColors.Menu;
            btnAddEmployee.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmployee.Location = new Point(101, 657);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(656, 96);
            btnAddEmployee.TabIndex = 8;
            btnAddEmployee.Text = "ADD NEW EMPLOYEE";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // EmployeeModule
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "EmployeeModule";
            Size = new Size(2252, 1435);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtEmpFirstName;
        private TextBox txtEmpLastName;
        private Label label2;
        private TextBox txtEmpRate;
        private Label label3;
        private TextBox txtEmpRole;
        private Label label4;
        private Label label7;
        private Panel panel1;
        private DataGridView dgvEmployees;
        private Button btnEditEmployee;
        private Button btnDeleteEmployee;
        private Button btnAddEmployee;
    }
}
