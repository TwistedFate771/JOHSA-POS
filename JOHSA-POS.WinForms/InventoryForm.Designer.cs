namespace JOHSA_POS.WinForms
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLowStock;

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnStockOut;

        private System.Windows.Forms.DataGridView dgvInventory;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();

            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();

            this.dgvInventory = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Inventory Management";
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Title
            this.lblTitle.Text = "Inventory Management";
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(500, 40);

            this.Controls.Add(this.lblTitle);

            // Description
            this.lblDescription.Text =
                "Monitor product stock and inventory levels.";
            this.lblDescription.Location = new System.Drawing.Point(28, 65);
            this.lblDescription.Size = new System.Drawing.Size(500, 25);
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;

            this.Controls.Add(this.lblDescription);

            // Low Stock Label
            this.lblLowStock.Text = "Low Stock Items: 0";
            this.lblLowStock.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLowStock.Location = new System.Drawing.Point(28, 105);
            this.lblLowStock.Size = new System.Drawing.Size(250, 30);
            this.lblLowStock.ForeColor = System.Drawing.Color.Firebrick;

            this.Controls.Add(this.lblLowStock);

            // Search
            this.txtSearch.Location = new System.Drawing.Point(28, 155);
            this.txtSearch.Size = new System.Drawing.Size(250, 30);


            this.Controls.Add(this.txtSearch);

            // Refresh Button
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(295, 153);
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.Controls.Add(this.btnRefresh);

            // Stock In Button
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.Location = new System.Drawing.Point(680, 153);
            this.btnStockIn.Size = new System.Drawing.Size(120, 35);
            this.btnStockIn.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStockIn.ForeColor = System.Drawing.Color.White;
            this.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.Controls.Add(this.btnStockIn);

            // Stock Out Button
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.Location = new System.Drawing.Point(815, 153);
            this.btnStockOut.Size = new System.Drawing.Size(130, 35);
            this.btnStockOut.BackColor = System.Drawing.Color.Firebrick;
            this.btnStockOut.ForeColor = System.Drawing.Color.White;
            this.btnStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.Controls.Add(this.btnStockOut);

            // Inventory Table
            this.dgvInventory.Location = new System.Drawing.Point(28, 210);
            this.dgvInventory.Size = new System.Drawing.Size(917, 350);
            this.dgvInventory.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.RowHeadersVisible = false;

            this.Controls.Add(this.dgvInventory);

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.txtSearch.TextChanged +=
                new System.EventHandler(this.TxtSearch_TextChanged);

            this.btnRefresh.Click +=
                new System.EventHandler(this.BtnRefresh_Click);

            this.btnStockIn.Click +=
                new System.EventHandler(this.BtnStockIn_Click);

            this.btnStockOut.Click +=
                new System.EventHandler(this.BtnStockOut_Click);
        }
    }
}