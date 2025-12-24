namespace InventoryFlow.UI.Forms
{
    partial class MainForm
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
            dgwProduct = new DataGridView();
            btnOpenAddForm = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblSearch = new Label();
            tbxSearch = new TextBox();
            btnExport = new Button();
            btnOpenSales = new Button();
            btnCustomers = new Button();
            panelSearch = new Panel();
            gbSearch = new GroupBox();
            panelDGW = new Panel();
            flpCrud = new FlowLayoutPanel();
            flpNavigations = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            panelSearch.SuspendLayout();
            gbSearch.SuspendLayout();
            panelDGW.SuspendLayout();
            flpCrud.SuspendLayout();
            flpNavigations.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProduct
            // 
            dgwProduct.AllowUserToAddRows = false;
            dgwProduct.AllowUserToDeleteRows = false;
            dgwProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.Dock = DockStyle.Fill;
            dgwProduct.Location = new Point(12, 12);
            dgwProduct.MultiSelect = false;
            dgwProduct.Name = "dgwProduct";
            dgwProduct.ReadOnly = true;
            dgwProduct.RowHeadersVisible = false;
            dgwProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwProduct.Size = new Size(860, 359);
            dgwProduct.TabIndex = 0;
            dgwProduct.BorderStyle = BorderStyle.None;
            dgwProduct.BackgroundColor = SystemColors.Window;
            // 
            // btnOpenAddForm
            // 
            btnOpenAddForm.AutoSize = false;
            btnOpenAddForm.ForeColor = SystemColors.ControlText;
            btnOpenAddForm.Location = new Point(3, 3);
            btnOpenAddForm.Name = "btnOpenAddForm";
            btnOpenAddForm.Size = new Size(140, 32);
            btnOpenAddForm.TabIndex = 1;
            btnOpenAddForm.Text = "Add New Product";
            btnOpenAddForm.UseVisualStyleBackColor = true;
            btnOpenAddForm.Click += btnOpenAddForm_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = false;
            btnUpdate.Location = new Point(149, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 32);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Selected";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = false;
            btnDelete.Location = new Point(295, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(18, 33);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(108, 17);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search by Name:";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(132, 29);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PlaceholderText = "Product name...";
            tbxSearch.Size = new Size(360, 26);
            tbxSearch.TabIndex = 5;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // btnExport
            // 
            btnExport.AutoSize = false;
            btnExport.Location = new Point(323, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(140, 32);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export to Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnOpenSales
            // 
            btnOpenSales.AutoSize = false;
            btnOpenSales.Location = new Point(169, 3);
            btnOpenSales.Name = "btnOpenSales";
            btnOpenSales.Size = new Size(148, 32);
            btnOpenSales.TabIndex = 7;
            btnOpenSales.Text = "Go to Sales";
            btnOpenSales.UseVisualStyleBackColor = true;
            btnOpenSales.Click += btnOpenSales_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.AutoSize = false;
            btnCustomers.Location = new Point(3, 3);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(160, 32);
            btnCustomers.TabIndex = 8;
            btnCustomers.Text = "Manage Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(gbSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(12);
            panelSearch.Size = new Size(884, 92);
            panelSearch.TabIndex = 9;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(tbxSearch);
            gbSearch.Controls.Add(lblSearch);
            gbSearch.Dock = DockStyle.Fill;
            gbSearch.Location = new Point(12, 12);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(860, 68);
            gbSearch.TabIndex = 13;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search";
            // 
            // panelDGW
            // 
            panelDGW.Controls.Add(dgwProduct);
            panelDGW.Dock = DockStyle.Fill;
            panelDGW.Location = new Point(0, 92);
            panelDGW.Name = "panelDGW";
            panelDGW.Padding = new Padding(12, 12, 12, 6);
            panelDGW.Size = new Size(884, 324);
            panelDGW.TabIndex = 10;
            // 
            // flpCrud
            // 
            flpCrud.Controls.Add(btnOpenAddForm);
            flpCrud.Controls.Add(btnUpdate);
            flpCrud.Controls.Add(btnDelete);
            flpCrud.Dock = DockStyle.Bottom;
            flpCrud.FlowDirection = FlowDirection.LeftToRight;
            flpCrud.Location = new Point(0, 509);
            flpCrud.WrapContents = false;
            flpCrud.Name = "flpCrud";
            flpCrud.Padding = new Padding(12, 10, 12, 10);
            flpCrud.FlowDirection = FlowDirection.RightToLeft;
            flpCrud.Size = new Size(884, 52);
            flpCrud.TabIndex = 11;
            // 
            // flpNavigations
            // 
            flpNavigations.Controls.Add(btnCustomers);
            flpNavigations.Controls.Add(btnOpenSales);
            flpNavigations.Controls.Add(btnExport);
            flpNavigations.Dock = DockStyle.Bottom;
            flpNavigations.FlowDirection = FlowDirection.LeftToRight;
            flpNavigations.Location = new Point(0, 416);
            flpNavigations.WrapContents = false;
            flpNavigations.Name = "flpNavigations";
            flpNavigations.Padding = new Padding(12, 8, 12, 8);
            flpNavigations.Size = new Size(884, 46);
            flpNavigations.TabIndex = 12;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 508);
            Controls.Add(flpNavigations);
            Controls.Add(flpCrud);
            Controls.Add(panelDGW);
            Controls.Add(panelSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = SystemColors.ControlLightLight;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryFlow - Products";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProduct).EndInit();
            panelSearch.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            panelDGW.ResumeLayout(false);
            flpCrud.ResumeLayout(false);
            flpCrud.PerformLayout();
            flpNavigations.ResumeLayout(false);
            flpNavigations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProduct;
        private Button btnOpenAddForm;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblSearch;
        private TextBox tbxSearch;
        private Button btnExport;
        private Button btnOpenSales;
        private Button btnCustomers;
        private Panel panelSearch;
        private GroupBox gbSearch;
        private Panel panelDGW;
        private FlowLayoutPanel flpCrud;
        private FlowLayoutPanel flpNavigations;
    }
}