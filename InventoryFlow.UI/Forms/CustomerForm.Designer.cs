namespace InventoryFlow.UI.Forms
{
    partial class CustomerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            tbxFirstName = new TextBox();
            lblLastName = new Label();
            tbxLastName = new TextBox();
            lblEmail = new Label();
            tbxEmail = new TextBox();
            lblPhone = new Label();
            tbxPhone = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgwCustomers = new DataGridView();
            gbxCustomer = new GroupBox();
            flpCrud = new FlowLayoutPanel();
            panelGrid = new Panel();
            panelRight = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).BeginInit();
            gbxCustomer.SuspendLayout();
            flpCrud.SuspendLayout();
            panelGrid.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(28, 40);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(74, 17);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(120, 36);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(150, 26);
            tbxFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(28, 75);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(74, 17);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(120, 72);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(150, 26);
            tbxLastName.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(59, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(43, 17);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(120, 105);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "example@mail.com";
            tbxEmail.Size = new Size(150, 26);
            tbxEmail.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(54, 144);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(48, 17);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(120, 141);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(150, 26);
            tbxPhone.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 32);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(99, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 32);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(195, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 32);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgwCustomers
            // 
            dgwCustomers.AllowUserToAddRows = false;
            dgwCustomers.AllowUserToDeleteRows = false;
            dgwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwCustomers.BackgroundColor = SystemColors.Window;
            dgwCustomers.BorderStyle = BorderStyle.None;
            dgwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCustomers.Dock = DockStyle.Fill;
            dgwCustomers.Location = new Point(12, 12);
            dgwCustomers.MultiSelect = false;
            dgwCustomers.Name = "dgwCustomers";
            dgwCustomers.ReadOnly = true;
            dgwCustomers.RowHeadersVisible = false;
            dgwCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCustomers.Size = new Size(557, 484);
            dgwCustomers.TabIndex = 11;
            dgwCustomers.CellClick += dgwCustomers_CellClick;
            // 
            // gbxCustomer
            // 
            gbxCustomer.Controls.Add(lblFirstName);
            gbxCustomer.Controls.Add(tbxFirstName);
            gbxCustomer.Controls.Add(lblLastName);
            gbxCustomer.Controls.Add(tbxLastName);
            gbxCustomer.Controls.Add(lblEmail);
            gbxCustomer.Controls.Add(tbxPhone);
            gbxCustomer.Controls.Add(tbxEmail);
            gbxCustomer.Controls.Add(lblPhone);
            gbxCustomer.Controls.Add(flpCrud);
            gbxCustomer.Dock = DockStyle.Fill;
            gbxCustomer.Location = new Point(12, 12);
            gbxCustomer.Name = "gbxCustomer";
            gbxCustomer.Size = new Size(294, 484);
            gbxCustomer.TabIndex = 12;
            gbxCustomer.TabStop = false;
            gbxCustomer.Text = "Customer Details";
            // 
            // flpCrud
            // 
            flpCrud.Controls.Add(btnAdd);
            flpCrud.Controls.Add(btnUpdate);
            flpCrud.Controls.Add(btnDelete);
            flpCrud.Location = new Point(9, 199);
            flpCrud.Name = "flpCrud";
            flpCrud.Size = new Size(311, 38);
            flpCrud.TabIndex = 11;
            flpCrud.WrapContents = false;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgwCustomers);
            panelGrid.Location = new Point(0, 0);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(12);
            panelGrid.Size = new Size(581, 508);
            panelGrid.TabIndex = 13;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(gbxCustomer);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(566, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(12);
            panelRight.Size = new Size(318, 508);
            panelRight.TabIndex = 14;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(884, 508);
            Controls.Add(panelGrid);
            Controls.Add(panelRight);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryFlow - Customers";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).EndInit();
            gbxCustomer.ResumeLayout(false);
            gbxCustomer.PerformLayout();
            flpCrud.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblFirstName;
        private TextBox tbxFirstName;
        private Label lblLastName;
        private TextBox tbxLastName;
        private Label lblEmail;
        private TextBox tbxEmail;
        private Label lblPhone;
        private TextBox tbxPhone;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgwCustomers;
        private GroupBox gbxCustomer;
        private Panel panelGrid;
        private Panel panelRight;
        private FlowLayoutPanel flpCrud;
    }
}