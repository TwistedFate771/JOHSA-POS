namespace JOHSA_POS.WinForms
{
    partial class ProductsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeactivateProduct;

        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblProductCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeactivateProduct = new System.Windows.Forms.Button();

            this.pnlTable = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enterprise POS - Products";
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Header Panel
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 155;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(25);
            this.pnlHeader.Name = "pnlHeader";

            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(24, 42, 70);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Product Management";

            this.pnlHeader.Controls.Add(this.lblTitle);

            // Subtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(28, 68);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Manage your products and stock information.";

            this.pnlHeader.Controls.Add(this.lblSubtitle);

            // Refresh Button
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(70, 85, 105);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Location = new System.Drawing.Point(28, 105);
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

            this.pnlHeader.Controls.Add(this.btnRefresh);

            // Add Product Button
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.Location = new System.Drawing.Point(140, 105);
            this.btnAddProduct.Size = new System.Drawing.Size(130, 35);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);

            this.pnlHeader.Controls.Add(this.btnAddProduct);

            // Edit Product Button
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(37, 130, 105);
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.Location = new System.Drawing.Point(282, 105);
            this.btnEditProduct.Size = new System.Drawing.Size(125, 35);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);

            this.pnlHeader.Controls.Add(this.btnEditProduct);

            // Deactivate Button
            this.btnDeactivateProduct.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeactivateProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeactivateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivateProduct.FlatAppearance.BorderSize = 0;
            this.btnDeactivateProduct.Location = new System.Drawing.Point(419, 105);
            this.btnDeactivateProduct.Size = new System.Drawing.Size(145, 35);
            this.btnDeactivateProduct.Name = "btnDeactivateProduct";
            this.btnDeactivateProduct.Text = "Deactivate Product";
            this.btnDeactivateProduct.Click += new System.EventHandler(this.BtnDeactivateProduct_Click);

            this.pnlHeader.Controls.Add(this.btnDeactivateProduct);

            this.Controls.Add(this.pnlHeader);

            // Table Panel
            this.pnlTable.BackColor = System.Drawing.Color.White;
            this.pnlTable.Location = new System.Drawing.Point(25, 180);
            this.pnlTable.Size = new System.Drawing.Size(1040, 430);
            this.pnlTable.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.pnlTable.Name = "pnlTable";

            // Table Title
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font(
                "Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(24, 42, 70);
            this.lblTableTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Text = "Product List";

            this.pnlTable.Controls.Add(this.lblTableTitle);

            // Product Count
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProductCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblProductCount.Location = new System.Drawing.Point(850, 22);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Text = "Products";

            this.pnlTable.Controls.Add(this.lblProductCount);

            // DataGridView
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.Location = new System.Drawing.Point(20, 55);
            this.dgvProducts.Size = new System.Drawing.Size(1000, 350);
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.pnlTable.Controls.Add(this.dgvProducts);

            this.Controls.Add(this.pnlTable);

            // Finish
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}