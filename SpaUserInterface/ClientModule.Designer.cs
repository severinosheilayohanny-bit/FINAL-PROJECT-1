namespace SpaUserInterface
{
    partial class ClientModule
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
            pnlClientEditor = new Panel();
            btnEditClient = new Button();
            btnDeleteClient = new Button();
            label7 = new Label();
            label1 = new Label();
            dgvClients = new DataGridView();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtDocument = new TextBox();
            txtAddress = new TextBox();
            txtLastName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            btnAddClient = new Button();
            pnlClientEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // pnlClientEditor
            // 
            pnlClientEditor.BackColor = SystemColors.ControlLightLight;
            pnlClientEditor.Controls.Add(btnEditClient);
            pnlClientEditor.Controls.Add(btnDeleteClient);
            pnlClientEditor.Controls.Add(label7);
            pnlClientEditor.Controls.Add(label1);
            pnlClientEditor.Controls.Add(dgvClients);
            pnlClientEditor.Controls.Add(txtPhone);
            pnlClientEditor.Controls.Add(txtEmail);
            pnlClientEditor.Controls.Add(txtDocument);
            pnlClientEditor.Controls.Add(txtAddress);
            pnlClientEditor.Controls.Add(txtLastName);
            pnlClientEditor.Controls.Add(label6);
            pnlClientEditor.Controls.Add(label5);
            pnlClientEditor.Controls.Add(label4);
            pnlClientEditor.Controls.Add(label3);
            pnlClientEditor.Controls.Add(label2);
            pnlClientEditor.Controls.Add(txtFirstName);
            pnlClientEditor.Controls.Add(btnAddClient);
            pnlClientEditor.Dock = DockStyle.Fill;
            pnlClientEditor.Location = new Point(0, 0);
            pnlClientEditor.Name = "pnlClientEditor";
            pnlClientEditor.Size = new Size(2064, 1486);
            pnlClientEditor.TabIndex = 0;
            // 
            // btnEditClient
            // 
            btnEditClient.BackColor = SystemColors.Menu;
            btnEditClient.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btnEditClient.Location = new Point(992, 535);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(529, 106);
            btnEditClient.TabIndex = 16;
            btnEditClient.Text = "EDIT SELECTED CLIENT";
            btnEditClient.UseVisualStyleBackColor = false;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.BackColor = SystemColors.Menu;
            btnDeleteClient.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteClient.Location = new Point(992, 721);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(529, 106);
            btnDeleteClient.TabIndex = 15;
            btnDeleteClient.Text = "DELETE SELECTED CLIENT";
            btnDeleteClient.UseVisualStyleBackColor = false;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(683, 84);
            label7.Name = "label7";
            label7.Size = new Size(676, 119);
            label7.TabIndex = 14;
            label7.Text = "Client Section";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label1.Location = new Point(129, 348);
            label1.Name = "label1";
            label1.Size = new Size(220, 50);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToOrderColumns = true;
            dgvClients.BackgroundColor = SystemColors.Control;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Dock = DockStyle.Bottom;
            dgvClients.Location = new Point(0, 1016);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 82;
            dgvClients.Size = new Size(2064, 470);
            dgvClients.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Window;
            txtPhone.Font = new Font("Segoe UI", 10.125F);
            txtPhone.Location = new Point(398, 478);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(260, 43);
            txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Font = new Font("Segoe UI", 10.125F);
            txtEmail.Location = new Point(398, 535);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 43);
            txtEmail.TabIndex = 11;
            // 
            // txtDocument
            // 
            txtDocument.BackColor = SystemColors.Window;
            txtDocument.Font = new Font("Segoe UI", 10.125F);
            txtDocument.Location = new Point(398, 596);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(260, 43);
            txtDocument.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Window;
            txtAddress.Font = new Font("Segoe UI", 10.125F);
            txtAddress.Location = new Point(398, 658);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(260, 43);
            txtAddress.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Window;
            txtLastName.Font = new Font("Segoe UI", 10.125F);
            txtLastName.Location = new Point(398, 410);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(260, 43);
            txtLastName.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label6.Location = new Point(129, 658);
            label6.Name = "label6";
            label6.Size = new Size(171, 50);
            label6.TabIndex = 7;
            label6.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label5.Location = new Point(129, 596);
            label5.Name = "label5";
            label5.Size = new Size(212, 50);
            label5.TabIndex = 6;
            label5.Text = "Document:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label4.Location = new Point(129, 535);
            label4.Name = "label4";
            label4.Size = new Size(128, 50);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label3.Location = new Point(129, 478);
            label3.Name = "label3";
            label3.Size = new Size(142, 50);
            label3.TabIndex = 4;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label2.Location = new Point(129, 410);
            label2.Name = "label2";
            label2.Size = new Size(214, 50);
            label2.TabIndex = 3;
            label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.Window;
            txtFirstName.Font = new Font("Segoe UI", 10.125F);
            txtFirstName.Location = new Point(398, 348);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(260, 43);
            txtFirstName.TabIndex = 2;
            // 
            // btnAddClient
            // 
            btnAddClient.BackColor = SystemColors.Menu;
            btnAddClient.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddClient.Location = new Point(129, 731);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(529, 96);
            btnAddClient.TabIndex = 0;
            btnAddClient.Text = "ADD NEW CLIENT";
            btnAddClient.UseVisualStyleBackColor = false;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // ClientModule
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(pnlClientEditor);
            Name = "ClientModule";
            Size = new Size(2064, 1486);
            pnlClientEditor.ResumeLayout(false);
            pnlClientEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlClientEditor;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private Button btnAddClient;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtDocument;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private DataGridView dgvClients;
        private Label label7;
        private Button btnDeleteClient;
        private Button btnEditClient;
    }
}
