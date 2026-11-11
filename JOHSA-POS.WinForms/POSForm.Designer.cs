
namespace JOHSA_POS.WinForms
{
    partial class POSForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblCart = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblChangeValue = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enterprise POS";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(35, 175);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(94, 16);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Select Product";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Location = new System.Drawing.Point(35, 200);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(350, 24);
            this.cmbProduct.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(405, 175);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(405, 200);
            this.numQuantity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(100, 22);
            this.numQuantity.TabIndex = 6;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(530, 195);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(130, 35);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCart.Location = new System.Drawing.Point(35, 260);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(178, 32);
            this.lblCart.TabIndex = 8;
            this.lblCart.Text = "Shopping Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.ColumnHeadersHeight = 29;
            this.dgvCart.Location = new System.Drawing.Point(35, 300);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(720, 300);
            this.dgvCart.TabIndex = 9;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(35, 615);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(130, 35);
            this.btnRemoveItem.TabIndex = 10;
            this.btnRemoveItem.Text = "Remove Item";
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(180, 615);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(130, 35);
            this.btnClearCart.TabIndex = 11;
            this.btnClearCart.Text = "Clear Cart";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(35, 100);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(125, 16);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer (Optional)";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Location = new System.Drawing.Point(35, 125);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(300, 24);
            this.cmbCustomer.TabIndex = 2;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(800, 100);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(59, 16);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Location = new System.Drawing.Point(1010, 100);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(40, 16);
            this.lblSubtotalValue.TabIndex = 13;
            this.lblSubtotalValue.Text = "₱0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(800, 145);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(62, 16);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Discount:";
            // 
            // numDiscount
            // 
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.Location = new System.Drawing.Point(1010, 140);
            this.numDiscount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(140, 22);
            this.numDiscount.TabIndex = 15;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(800, 190);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(33, 16);
            this.lblTax.TabIndex = 16;
            this.lblTax.Text = "Tax:";
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.AutoSize = true;
            this.lblTaxValue.Location = new System.Drawing.Point(1010, 190);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(40, 16);
            this.lblTaxValue.TabIndex = 17;
            this.lblTaxValue.Text = "₱0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(800, 245);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 30);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.Location = new System.Drawing.Point(1010, 245);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(72, 30);
            this.lblTotalValue.TabIndex = 19;
            this.lblTotalValue.Text = "₱0.00";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(800, 320);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(83, 16);
            this.lblPayment.TabIndex = 20;
            this.lblPayment.Text = "Amount Paid";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(1010, 315);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(140, 22);
            this.txtAmountPaid.TabIndex = 21;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(800, 365);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(57, 16);
            this.lblChange.TabIndex = 22;
            this.lblChange.Text = "Change:";
            // 
            // lblChangeValue
            // 
            this.lblChangeValue.AutoSize = true;
            this.lblChangeValue.Location = new System.Drawing.Point(1010, 365);
            this.lblChangeValue.Name = "lblChangeValue";
            this.lblChangeValue.Size = new System.Drawing.Size(40, 16);
            this.lblChangeValue.TabIndex = 23;
            this.lblChangeValue.Text = "₱0.00";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(800, 420);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(108, 16);
            this.lblPaymentMethod.TabIndex = 24;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "GCash",
            "Card"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(800, 450);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(350, 24);
            this.cmbPaymentMethod.TabIndex = 25;
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCompleteSale.ForeColor = System.Drawing.Color.White;
            this.btnCompleteSale.Location = new System.Drawing.Point(800, 530);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(350, 55);
            this.btnCompleteSale.TabIndex = 26;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = false;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblSubtotalValue);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTaxValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblChangeValue);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.btnCompleteSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblChangeValue;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Button btnCompleteSale;
    }
}
