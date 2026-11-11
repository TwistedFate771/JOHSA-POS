
namespace JOHSA_POS.WinForms
{
    partial class SalesAnalyticsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label lblTotalOrdersTitle;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalSalesTitle;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalDiscountsTitle;
        private System.Windows.Forms.Label lblTotalDiscounts;
        private System.Windows.Forms.Label lblTotalTaxTitle;
        private System.Windows.Forms.Label lblTotalTax;

        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.TabPage tabProducts;

        private System.Windows.Forms.DataGridView dgvDailySales;
        private System.Windows.Forms.DataGridView dgvMonthlySales;
        private System.Windows.Forms.DataGridView dgvPaymentSales;
        private System.Windows.Forms.DataGridView dgvTopProducts;

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;

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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.summaryPanel = new System.Windows.Forms.Panel();
            this.lblTotalOrdersTitle = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalSalesTitle = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalDiscountsTitle = new System.Windows.Forms.Label();
            this.lblTotalDiscounts = new System.Windows.Forms.Label();
            this.lblTotalTaxTitle = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();

            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.tabProducts = new System.Windows.Forms.TabPage();

            this.dgvDailySales = new System.Windows.Forms.DataGridView();
            this.dgvMonthlySales = new System.Windows.Forms.DataGridView();
            this.dgvPaymentSales = new System.Windows.Forms.DataGridView();
            this.dgvTopProducts = new System.Windows.Forms.DataGridView();

            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.headerPanel.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabDaily.SuspendLayout();
            this.tabMonthly.SuspendLayout();
            this.tabPayment.SuspendLayout();
            this.tabProducts.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).BeginInit();

            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Analytics";
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Header Panel
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Size = new System.Drawing.Size(1100, 100);

            this.lblTitle.Text = "Sales Analytics";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Size = new System.Drawing.Size(400, 40);

            this.lblSubtitle.Text = "View your store sales performance and reports";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitle.Location = new System.Drawing.Point(33, 60);
            this.lblSubtitle.Size = new System.Drawing.Size(500, 25);

            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

            // Summary Panel
            this.summaryPanel.Location = new System.Drawing.Point(25, 120);
            this.summaryPanel.Size = new System.Drawing.Size(1050, 120);
            this.summaryPanel.BackColor = System.Drawing.Color.White;

            // Total Orders
            this.lblTotalOrdersTitle.Text = "TOTAL ORDERS";
            this.lblTotalOrdersTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTotalOrdersTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTotalOrdersTitle.ForeColor = System.Drawing.Color.Gray;

            this.lblTotalOrders.Text = "0";
            this.lblTotalOrders.Location = new System.Drawing.Point(25, 55);
            this.lblTotalOrders.Size = new System.Drawing.Size(200, 40);
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);

            // Total Sales
            this.lblTotalSalesTitle.Text = "TOTAL SALES";
            this.lblTotalSalesTitle.Location = new System.Drawing.Point(275, 20);
            this.lblTotalSalesTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTotalSalesTitle.ForeColor = System.Drawing.Color.Gray;

            this.lblTotalSales.Text = "₱0.00";
            this.lblTotalSales.Location = new System.Drawing.Point(275, 55);
            this.lblTotalSales.Size = new System.Drawing.Size(200, 40);
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);

            // Total Discounts
            this.lblTotalDiscountsTitle.Text = "TOTAL DISCOUNTS";
            this.lblTotalDiscountsTitle.Location = new System.Drawing.Point(525, 20);
            this.lblTotalDiscountsTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTotalDiscountsTitle.ForeColor = System.Drawing.Color.Gray;

            this.lblTotalDiscounts.Text = "₱0.00";
            this.lblTotalDiscounts.Location = new System.Drawing.Point(525, 55);
            this.lblTotalDiscounts.Size = new System.Drawing.Size(200, 40);
            this.lblTotalDiscounts.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);

            // Total Tax
            this.lblTotalTaxTitle.Text = "TOTAL TAX";
            this.lblTotalTaxTitle.Location = new System.Drawing.Point(775, 20);
            this.lblTotalTaxTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTotalTaxTitle.ForeColor = System.Drawing.Color.Gray;

            this.lblTotalTax.Text = "₱0.00";
            this.lblTotalTax.Location = new System.Drawing.Point(775, 55);
            this.lblTotalTax.Size = new System.Drawing.Size(200, 40);
            this.lblTotalTax.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);

            this.summaryPanel.Controls.Add(this.lblTotalOrdersTitle);
            this.summaryPanel.Controls.Add(this.lblTotalOrders);
            this.summaryPanel.Controls.Add(this.lblTotalSalesTitle);
            this.summaryPanel.Controls.Add(this.lblTotalSales);
            this.summaryPanel.Controls.Add(this.lblTotalDiscountsTitle);
            this.summaryPanel.Controls.Add(this.lblTotalDiscounts);
            this.summaryPanel.Controls.Add(this.lblTotalTaxTitle);
            this.summaryPanel.Controls.Add(this.lblTotalTax);

            // Tab Control
            this.tabReports.Location = new System.Drawing.Point(25, 260);
            this.tabReports.Size = new System.Drawing.Size(1050, 360);
            this.tabReports.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Daily Tab
            this.tabDaily.Text = "Daily Sales";
            this.tabDaily.Controls.Add(this.dgvDailySales);

            // Monthly Tab
            this.tabMonthly.Text = "Monthly Sales";
            this.tabMonthly.Controls.Add(this.dgvMonthlySales);

            // Payment Tab
            this.tabPayment.Text = "Payment Methods";
            this.tabPayment.Controls.Add(this.dgvPaymentSales);

            // Products Tab
            this.tabProducts.Text = "Top Selling Products";
            this.tabProducts.Controls.Add(this.dgvTopProducts);

            this.tabReports.Controls.Add(this.tabDaily);
            this.tabReports.Controls.Add(this.tabMonthly);
            this.tabReports.Controls.Add(this.tabPayment);
            this.tabReports.Controls.Add(this.tabProducts);

            // DataGridViews
            SetupGrid(this.dgvDailySales);
            SetupGrid(this.dgvMonthlySales);
            SetupGrid(this.dgvPaymentSales);
            SetupGrid(this.dgvTopProducts);

            // Buttons
            this.btnRefresh.Text = "Refresh Reports";
            this.btnRefresh.Location = new System.Drawing.Point(790, 640);
            this.btnRefresh.Size = new System.Drawing.Size(150, 40);
            this.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(955, 640);
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Add Controls
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.tabReports);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);

            this.headerPanel.ResumeLayout(false);
            this.summaryPanel.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabDaily.ResumeLayout(false);
            this.tabMonthly.ResumeLayout(false);
            this.tabPayment.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).EndInit();

            this.ResumeLayout(false);
        }

        private void SetupGrid(System.Windows.Forms.DataGridView grid)
        {
            grid.Dock = System.Windows.Forms.DockStyle.Fill;
            grid.BackgroundColor = System.Drawing.Color.White;
            grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            grid.AllowUserToAddRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;
        }
    }
}
