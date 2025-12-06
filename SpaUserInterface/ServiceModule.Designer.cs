namespace SpaUserInterface
{
    partial class ServiceModule
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
            panel1 = new Panel();
            label7 = new Label();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtDuration = new TextBox();
            label2 = new Label();
            label4 = new Label();
            btnEditService = new Button();
            btnDeleteService = new Button();
            btnAddService = new Button();
            dgvServices = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtDuration);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnEditService);
            panel1.Controls.Add(btnDeleteService);
            panel1.Controls.Add(btnAddService);
            panel1.Controls.Add(dgvServices);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2192, 1421);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(673, 63);
            label7.Name = "label7";
            label7.Size = new Size(783, 119);
            label7.TabIndex = 16;
            label7.Text = "Services Section";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(436, 376);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(310, 43);
            txtDescription.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(436, 518);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(310, 43);
            txtPrice.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label1.Location = new Point(89, 303);
            label1.Name = "label1";
            label1.Size = new Size(135, 50);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label3.Location = new Point(89, 518);
            label3.Name = "label3";
            label3.Size = new Size(119, 50);
            label3.TabIndex = 14;
            label3.Text = "Price:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(436, 303);
            txtName.Name = "txtName";
            txtName.Size = new Size(310, 43);
            txtName.TabIndex = 9;
            // 
            // txtDuration
            // 
            txtDuration.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDuration.Location = new Point(436, 445);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(310, 43);
            txtDuration.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label2.Location = new Point(89, 376);
            label2.Name = "label2";
            label2.Size = new Size(232, 50);
            label2.TabIndex = 10;
            label2.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label4.Location = new Point(89, 445);
            label4.Name = "label4";
            label4.Size = new Size(292, 50);
            label4.TabIndex = 12;
            label4.Text = "Duration (Min):";
            // 
            // btnEditService
            // 
            btnEditService.BackColor = SystemColors.Menu;
            btnEditService.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btnEditService.Location = new Point(976, 499);
            btnEditService.Name = "btnEditService";
            btnEditService.Size = new Size(534, 89);
            btnEditService.TabIndex = 3;
            btnEditService.Text = "EDIT SELECTED SERVICE";
            btnEditService.UseVisualStyleBackColor = false;
            btnEditService.Click += btnEditService_Click;
            // 
            // btnDeleteService
            // 
            btnDeleteService.BackColor = SystemColors.Menu;
            btnDeleteService.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btnDeleteService.Location = new Point(976, 652);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(534, 89);
            btnDeleteService.TabIndex = 2;
            btnDeleteService.Text = "DELETE SELECTED SERVICE";
            btnDeleteService.UseVisualStyleBackColor = false;
            btnDeleteService.Click += btnDeleteService_Click;
            // 
            // btnAddService
            // 
            btnAddService.BackColor = SystemColors.Menu;
            btnAddService.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btnAddService.Location = new Point(89, 652);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(657, 89);
            btnAddService.TabIndex = 1;
            btnAddService.Text = "ADD NEW SERVICE";
            btnAddService.UseVisualStyleBackColor = false;
            btnAddService.Click += btnAddService_Click;
            // 
            // dgvServices
            // 
            dgvServices.BackgroundColor = SystemColors.Control;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Dock = DockStyle.Bottom;
            dgvServices.Location = new Point(0, 900);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersWidth = 82;
            dgvServices.Size = new Size(2192, 521);
            dgvServices.TabIndex = 0;
            // 
            // ServiceModule
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ServiceModule";
            Size = new Size(2192, 1421);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvServices;
        private Button btnAddService;
        private Button btnEditService;
        private Button btnDeleteService;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Label label1;
        private Label label3;
        private TextBox txtName;
        private TextBox txtDuration;
        private Label label2;
        private Label label4;
        private Label label7;
    }
}
