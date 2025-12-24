namespace InventoryFlow.UI.Forms
{
    partial class ProductForm
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
            lblProductName = new Label();
            tbxProductName = new TextBox();
            lblUnitPrice = new Label();
            tbxUnitPrice = new TextBox();
            lblStock = new Label();
            tbxStockAmount = new TextBox();
            lblCategory = new Label();
            btnAdd = new Button();
            cbxCategory = new ComboBox();
            panelRoot = new Panel();
            gbProduct = new GroupBox();
            tlpFields = new TableLayoutPanel();
            flpActions = new FlowLayoutPanel();
            panelRoot.SuspendLayout();
            gbProduct.SuspendLayout();
            tlpFields.SuspendLayout();
            flpActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Location = new Point(3, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(119, 38);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name:";
            lblProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxProductName
            // 
            tbxProductName.Dock = DockStyle.Fill;
            tbxProductName.Location = new Point(128, 3);
            tbxProductName.Name = "tbxProductName";
            tbxProductName.Size = new Size(205, 26);
            tbxProductName.TabIndex = 1;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.Location = new Point(3, 38);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(119, 38);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "Unit Price:";
            lblUnitPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Dock = DockStyle.Fill;
            tbxUnitPrice.Location = new Point(128, 41);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(205, 26);
            tbxUnitPrice.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Dock = DockStyle.Fill;
            lblStock.Location = new Point(3, 76);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(119, 38);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock Amount:";
            lblStock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxStockAmount
            // 
            tbxStockAmount.Dock = DockStyle.Fill;
            tbxStockAmount.Location = new Point(128, 79);
            tbxStockAmount.Name = "tbxStockAmount";
            tbxStockAmount.Size = new Size(205, 26);
            tbxStockAmount.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(3, 114);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(119, 38);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category Id:";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Location = new Point(187, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 27);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbxCategory
            // 
            cbxCategory.Dock = DockStyle.Fill;
            cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(128, 117);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(205, 25);
            cbxCategory.TabIndex = 9;
            // 
            // panelRoot
            // 
            panelRoot.Controls.Add(gbProduct);
            panelRoot.Dock = DockStyle.Fill;
            panelRoot.Location = new Point(0, 0);
            panelRoot.Name = "panelRoot";
            panelRoot.Padding = new Padding(12);
            panelRoot.Size = new Size(384, 261);
            panelRoot.TabIndex = 10;
            // 
            // gbProduct
            // 
            gbProduct.Controls.Add(tlpFields);
            gbProduct.Dock = DockStyle.Fill;
            gbProduct.Location = new Point(12, 12);
            gbProduct.Name = "gbProduct";
            gbProduct.Padding = new Padding(12);
            gbProduct.Size = new Size(360, 237);
            gbProduct.TabIndex = 11;
            gbProduct.TabStop = false;
            gbProduct.Text = "Product Details";
            // 
            // tlpFields
            // 
            tlpFields.ColumnCount = 2;
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFields.Controls.Add(lblProductName, 0, 0);
            tlpFields.Controls.Add(tbxProductName, 1, 0);
            tlpFields.Controls.Add(lblUnitPrice, 0, 1);
            tlpFields.Controls.Add(tbxUnitPrice, 1, 1);
            tlpFields.Controls.Add(lblStock, 0, 2);
            tlpFields.Controls.Add(tbxStockAmount, 1, 2);
            tlpFields.Controls.Add(lblCategory, 0, 3);
            tlpFields.Controls.Add(cbxCategory, 1, 3);
            tlpFields.Controls.Add(flpActions, 0, 4);
            tlpFields.Dock = DockStyle.Fill;
            tlpFields.Location = new Point(12, 31);
            tlpFields.Name = "tlpFields";
            tlpFields.RowCount = 5;
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFields.Size = new Size(336, 194);
            tlpFields.TabIndex = 0;
            // 
            // flpActions
            // 
            tlpFields.SetColumnSpan(flpActions, 2);
            flpActions.Controls.Add(btnAdd);
            flpActions.Dock = DockStyle.Fill;
            flpActions.FlowDirection = FlowDirection.RightToLeft;
            flpActions.Location = new Point(3, 155);
            flpActions.Name = "flpActions";
            flpActions.Padding = new Padding(0, 6, 0, 6);
            flpActions.Size = new Size(330, 36);
            flpActions.TabIndex = 1;
            flpActions.WrapContents = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(384, 261);
            Controls.Add(panelRoot);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryFlow - Product";
            Load += ProductForm_Load;
            panelRoot.ResumeLayout(false);
            gbProduct.ResumeLayout(false);
            tlpFields.ResumeLayout(false);
            tlpFields.PerformLayout();
            flpActions.ResumeLayout(false);
            flpActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblProductName;
        private TextBox tbxProductName;
        private Label lblUnitPrice;
        private TextBox tbxUnitPrice;
        private Label lblStock;
        private TextBox tbxStockAmount;
        private Label lblCategory;
        private Button btnAdd;
        private ComboBox cbxCategory;
        private Panel panelRoot;
        private GroupBox gbProduct;
        private TableLayoutPanel tlpFields;
        private FlowLayoutPanel flpActions;
    }
}