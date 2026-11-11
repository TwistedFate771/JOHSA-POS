namespace JOHSA_POS.WinForms
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblReorderLevel;

        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtReorderLevel;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

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

            this.lblSku = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblReorderLevel = new System.Windows.Forms.Label();

            this.txtSku = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Add Product";
            this.ClientSize = new System.Drawing.Size(480, 550);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Title
            this.lblTitle.Text = "Add New Product";
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(400, 40);

            this.Controls.Add(this.lblTitle);

            // SKU Label
            this.lblSku.Text = "SKU";
            this.lblSku.Location = new System.Drawing.Point(25, 85);
            this.lblSku.Size = new System.Drawing.Size(140, 25);

            this.Controls.Add(this.lblSku);

            // SKU TextBox
            this.txtSku.Location = new System.Drawing.Point(175, 82);
            this.txtSku.Size = new System.Drawing.Size(250, 25);

            this.Controls.Add(this.txtSku);

            // Barcode Label
            this.lblBarcode.Text = "Barcode";
            this.lblBarcode.Location = new System.Drawing.Point(25, 133);
            this.lblBarcode.Size = new System.Drawing.Size(140, 25);

            this.Controls.Add(this.lblBarcode);

            // Barcode TextBox
            this.txtBarcode.Location = new System.Drawing.Point(175, 130);
            this.txtBarcode.Size = new System.Drawing.Size(250, 25);

            this.Controls.Add(this.txtBarcode);

            // Product Name Label
            this.lblName.Text = "Product Name";
            this.lblName.Location = new System.Drawing.Point(25, 181);
            this.lblName.Size = new System.Drawing.Size(140, 25);

            this.Controls.Add(this.lblName);

            // Product Name TextBox
            this.txtName.Location = new System.Drawing.Point(175, 178);
            this.txtName.Size = new System.Drawing.Size(250, 25);

            this.Controls.Add(this.txtName);

            // Category Label
            this.lblCategory.Text = "Category";
            this.lblCategory.Location = new System.Drawing.Point(25, 229);
            this.lblCategory.Size = new System.Drawing.Size(140, 25);

            this.Controls.Add(this.lblCategory);

            // Category ComboBox
            this.cmbCategory.Location = new System.Drawing.Point(175, 226);
            this.cmbCategory.Size = new System.Drawing.Size(250, 25);
            this.cmbCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.DisplayMember = "Value";
            this.cmbCategory.ValueMember = "Key";

            this.Controls.Add(this.cmbCategory);

            // Cost Label
            this.lblCost.Text = "Cost";
            this.lblCost.Location = new System.Drawing.Point(25, 277);
            this.lblCost.Size = new System.Drawing.Size(140, 25);

            this.Controls.Add(this.lblCost);

            // Cost TextBox
            this.txtCost.Location = new System.Drawing.Point(175, 274);
            this.txtCost.Size = new System.Drawing.Size(250, 25);

            this.Controls.Add(this.txtCost);

            // Selling Price Label
            this.lblPrice.Text = "Selling Price";
            this.lblPrice.Location = new System.Drawing.Point(25, 325);
            this.lblPrice.Size = new System.Drawing.Size(140, 25);

            this.Controls.Add(this.lblPrice);

            // Selling Price TextBox
            this.txtPrice.Location = new System.Drawing.Point(175, 322);
            this.txtPrice.Size = new System.Drawing.Size(250, 25);

            this.Controls.Add(this.txtPrice);

            // Stock Quantity Label
            this.lblStock.Text = "Stock Quantity";
            this.lblStock.Location = new System.Drawing.Point(25, 373);
            this.lblStock.Size = new System.Drawing.Size(140, 25);

            this.Controls.Add(this.lblStock);

            // Stock Quantity TextBox
            this.txtStock.Location = new System.Drawing.Point(175, 370);
            this.txtStock.Size = new System.Drawing.Size(250, 25);

            this.Controls.Add(this.txtStock);

            // Reorder Level Label
            this.lblReorderLevel.Text = "Reorder Level";
            this.lblReorderLevel.Location = new System.Drawing.Point(25, 421);
            this.lblReorderLevel.Size = new System.Drawing.Size(140, 25);

            this.Controls.Add(this.lblReorderLevel);

            // Reorder Level TextBox
            this.txtReorderLevel.Location = new System.Drawing.Point(175, 418);
            this.txtReorderLevel.Size = new System.Drawing.Size(250, 25);

            this.Controls.Add(this.txtReorderLevel);

            // Save Button
            this.btnSave.Text = "Save Product";
            this.btnSave.Location = new System.Drawing.Point(110, 475);
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Click +=
                new System.EventHandler(this.BtnSave_Click);

            this.Controls.Add(this.btnSave);

            // Cancel Button
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(245, 475);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Click +=
                new System.EventHandler(this.BtnCancel_Click);

            this.Controls.Add(this.btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}