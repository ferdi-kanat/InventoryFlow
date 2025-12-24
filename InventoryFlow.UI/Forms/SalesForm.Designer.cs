namespace InventoryFlow.UI.Forms
{
    partial class SalesForm
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
            lblProduct = new Label();
            lblQuantity = new Label();
            cbxProducts = new ComboBox();
            tbxQuantity = new TextBox();
            btnSell = new Button();
            dgwSalesHistory = new DataGridView();
            lblTotalRevenue = new Label();
            lblCustomer = new Label();
            cbxCustomers = new ComboBox();
            panelSale = new Panel();
            gbSale = new GroupBox();
            tlpSale = new TableLayoutPanel();
            panelTotalRev = new Panel();
            panelGrid = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgwSalesHistory).BeginInit();
            panelSale.SuspendLayout();
            gbSale.SuspendLayout();
            tlpSale.SuspendLayout();
            panelTotalRev.SuspendLayout();
            panelGrid.SuspendLayout();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Dock = DockStyle.Fill;
            lblProduct.Location = new Point(3, 0);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(94, 31);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Select Product:";
            lblProduct.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.Location = new Point(526, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(62, 31);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity:";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxProducts
            // 
            cbxProducts.Dock = DockStyle.Fill;
            cbxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProducts.FormattingEnabled = true;
            cbxProducts.Location = new Point(103, 3);
            cbxProducts.Name = "cbxProducts";
            cbxProducts.Size = new Size(168, 25);
            cbxProducts.TabIndex = 2;
            // 
            // tbxQuantity
            // 
            tbxQuantity.Dock = DockStyle.Fill;
            tbxQuantity.Location = new Point(594, 3);
            tbxQuantity.Name = "tbxQuantity";
            tbxQuantity.Size = new Size(89, 26);
            tbxQuantity.TabIndex = 3;
            tbxQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.FromArgb(0, 120, 215);
            btnSell.FlatStyle = FlatStyle.Flat;
            btnSell.ForeColor = Color.White;
            btnSell.Location = new Point(689, 3);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(140, 25);
            btnSell.TabIndex = 4;
            btnSell.Text = "Complete Sale";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // dgwSalesHistory
            // 
            dgwSalesHistory.AllowUserToAddRows = false;
            dgwSalesHistory.AllowUserToDeleteRows = false;
            dgwSalesHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwSalesHistory.BackgroundColor = SystemColors.Window;
            dgwSalesHistory.BorderStyle = BorderStyle.None;
            dgwSalesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSalesHistory.Dock = DockStyle.Fill;
            dgwSalesHistory.Location = new Point(12, 12);
            dgwSalesHistory.Name = "dgwSalesHistory";
            dgwSalesHistory.ReadOnly = true;
            dgwSalesHistory.RowHeadersVisible = false;
            dgwSalesHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwSalesHistory.Size = new Size(860, 398);
            dgwSalesHistory.TabIndex = 5;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Dock = DockStyle.Right;
            lblTotalRevenue.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalRevenue.ForeColor = Color.DarkGreen;
            lblTotalRevenue.Location = new Point(664, 12);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(208, 25);
            lblTotalRevenue.TabIndex = 6;
            lblTotalRevenue.Text = "Total Revenue: $0.00";
            lblTotalRevenue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Dock = DockStyle.Fill;
            lblCustomer.Location = new Point(277, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(69, 31);
            lblCustomer.TabIndex = 7;
            lblCustomer.Text = "Customer:";
            lblCustomer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxCustomers
            // 
            cbxCustomers.Dock = DockStyle.Fill;
            cbxCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCustomers.FormattingEnabled = true;
            cbxCustomers.Location = new Point(352, 3);
            cbxCustomers.Name = "cbxCustomers";
            cbxCustomers.Size = new Size(168, 25);
            cbxCustomers.TabIndex = 8;
            // 
            // panelSale
            // 
            panelSale.Controls.Add(gbSale);
            panelSale.Dock = DockStyle.Top;
            panelSale.Location = new Point(0, 0);
            panelSale.Name = "panelSale";
            panelSale.Padding = new Padding(12);
            panelSale.Size = new Size(884, 98);
            panelSale.TabIndex = 9;
            // 
            // gbSale
            // 
            gbSale.Controls.Add(tlpSale);
            gbSale.Dock = DockStyle.Fill;
            gbSale.Location = new Point(12, 12);
            gbSale.Name = "gbSale";
            gbSale.Padding = new Padding(12);
            gbSale.Size = new Size(860, 74);
            gbSale.TabIndex = 11;
            gbSale.TabStop = false;
            gbSale.Text = "New Sale";
            // 
            // tlpSale
            // 
            tlpSale.ColumnCount = 7;
            tlpSale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpSale.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpSale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tlpSale.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpSale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 68F));
            tlpSale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tlpSale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpSale.Controls.Add(lblProduct, 0, 0);
            tlpSale.Controls.Add(cbxProducts, 1, 0);
            tlpSale.Controls.Add(lblCustomer, 2, 0);
            tlpSale.Controls.Add(cbxCustomers, 3, 0);
            tlpSale.Controls.Add(lblQuantity, 4, 0);
            tlpSale.Controls.Add(tbxQuantity, 5, 0);
            tlpSale.Controls.Add(btnSell, 6, 0);
            tlpSale.Dock = DockStyle.Fill;
            tlpSale.Location = new Point(12, 31);
            tlpSale.Name = "tlpSale";
            tlpSale.RowCount = 1;
            tlpSale.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSale.Size = new Size(836, 31);
            tlpSale.TabIndex = 0;
            // 
            // panelTotalRev
            // 
            panelTotalRev.Controls.Add(lblTotalRevenue);
            panelTotalRev.Dock = DockStyle.Bottom;
            panelTotalRev.Location = new Point(0, 456);
            panelTotalRev.Name = "panelTotalRev";
            panelTotalRev.Padding = new Padding(12);
            panelTotalRev.Size = new Size(884, 52);
            panelTotalRev.TabIndex = 10;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgwSalesHistory);
            panelGrid.Location = new Point(0, 92);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(12, 12, 12, 6);
            panelGrid.Size = new Size(884, 416);
            panelGrid.TabIndex = 12;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(884, 508);
            Controls.Add(panelTotalRev);
            Controls.Add(panelGrid);
            Controls.Add(panelSale);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryFlow - Sales";
            Load += SalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwSalesHistory).EndInit();
            panelSale.ResumeLayout(false);
            gbSale.ResumeLayout(false);
            tlpSale.ResumeLayout(false);
            tlpSale.PerformLayout();
            panelTotalRev.ResumeLayout(false);
            panelTotalRev.PerformLayout();
            panelGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblProduct;
        private Label lblQuantity;
        private ComboBox cbxProducts;
        private TextBox tbxQuantity;
        private Button btnSell;
        private DataGridView dgwSalesHistory;
        private Label lblTotalRevenue;
        private Label lblCustomer;
        private ComboBox cbxCustomers;
        private Panel panelSale;
        private Panel panelTotalRev;
        private GroupBox gbSale;
        private TableLayoutPanel tlpSale;
        private Panel panelGrid;
    }
}