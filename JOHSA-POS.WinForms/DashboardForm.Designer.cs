namespace JOHSA_POS.WinForms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel content;

        private System.Windows.Forms.Label brand;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Button logout;

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label subtitle;

        private System.Windows.Forms.Panel cardSales;
        private System.Windows.Forms.Panel cardOrders;
        private System.Windows.Forms.Panel cardLowStock;
        private System.Windows.Forms.Panel cardActiveProducts;

        private System.Windows.Forms.Label lblTodaysSales;
        private System.Windows.Forms.Label lblOrdersToday;
        private System.Windows.Forms.Label lblLowStockProducts;
        private System.Windows.Forms.Label lblActiveProducts;

        private System.Windows.Forms.Panel actions;
        private System.Windows.Forms.Panel recentSales;

        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnSalesAnalytics;
        private System.Windows.Forms.Button btnUserAdministration;

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
            this.header = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Panel();

            this.brand = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();

            this.heading = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();

            this.cardSales = new System.Windows.Forms.Panel();
            this.cardOrders = new System.Windows.Forms.Panel();
            this.cardLowStock = new System.Windows.Forms.Panel();
            this.cardActiveProducts = new System.Windows.Forms.Panel();

            this.lblTodaysSales = new System.Windows.Forms.Label();
            this.lblOrdersToday = new System.Windows.Forms.Label();
            this.lblLowStockProducts = new System.Windows.Forms.Label();
            this.lblActiveProducts = new System.Windows.Forms.Label();

            this.actions = new System.Windows.Forms.Panel();
            this.recentSales = new System.Windows.Forms.Panel();

            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnSalesAnalytics = new System.Windows.Forms.Button();
            this.btnUserAdministration = new System.Windows.Forms.Button();

            System.Windows.Forms.Label actionsTitle =
                new System.Windows.Forms.Label();

            System.Windows.Forms.Label recentTitle =
                new System.Windows.Forms.Label();

            System.Windows.Forms.Label emptyMessage =
                new System.Windows.Forms.Label();

            System.Windows.Forms.Label footer =
                new System.Windows.Forms.Label();

            System.Windows.Forms.Label salesTitle =
                new System.Windows.Forms.Label();

            System.Windows.Forms.Label ordersTitle =
                new System.Windows.Forms.Label();

            System.Windows.Forms.Label lowStockTitle =
                new System.Windows.Forms.Label();

            System.Windows.Forms.Label activeTitle =
                new System.Windows.Forms.Label();

            System.Windows.Forms.Panel salesAccent =
                new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel ordersAccent =
                new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel lowStockAccent =
                new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel activeAccent =
                new System.Windows.Forms.Panel();

            this.SuspendLayout();

            // Form
            this.Text = "Enterprise POS";
            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Header
            this.header.Dock =
                System.Windows.Forms.DockStyle.Top;
            this.header.Height = 80;
            this.header.BackColor =
                System.Drawing.Color.FromArgb(24, 42, 70);

            this.header.Resize +=
                new System.EventHandler(this.Header_Resize);

            this.Controls.Add(this.header);

            // Brand
            this.brand.Text = "Enterprise POS";
            this.brand.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.brand.ForeColor =
                System.Drawing.Color.White;
            this.brand.AutoSize = true;
            this.brand.Location =
                new System.Drawing.Point(28, 20);

            this.header.Controls.Add(this.brand);

            // Role
            this.role.Text = "STORE ADMINISTRATION";
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.role.ForeColor =
                System.Drawing.Color.LightSteelBlue;
            this.role.Location =
                new System.Drawing.Point(650, 30);

            this.header.Controls.Add(this.role);

            // Logout
            this.logout.Text = "Log Out";
            this.logout.Size =
                new System.Drawing.Size(100, 36);
            this.logout.Location =
                new System.Drawing.Point(850, 20);
            this.logout.BackColor =
                System.Drawing.Color.FromArgb(190, 65, 70);
            this.logout.ForeColor =
                System.Drawing.Color.White;
            this.logout.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.logout.FlatAppearance.BorderSize = 0;

            this.logout.Click +=
                new System.EventHandler(this.Logout_Click);

            this.header.Controls.Add(this.logout);

            // Main Content
            this.content.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.content.AutoScroll = true;
            this.content.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.Controls.Add(this.content);
            this.header.BringToFront();

            // Heading
            this.heading.Text = "Store Overview";
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.heading.ForeColor =
                System.Drawing.Color.FromArgb(24, 42, 70);
            this.heading.Location =
                new System.Drawing.Point(30, 28);

            this.content.Controls.Add(this.heading);

            // Subtitle
            this.subtitle.Text =
                "Manage your sales, products, and inventory in one place.";
            this.subtitle.AutoSize = true;
            this.subtitle.ForeColor =
                System.Drawing.Color.DimGray;
            this.subtitle.Location =
                new System.Drawing.Point(32, 82);

            this.content.Controls.Add(this.subtitle);

            // Today's Sales Card
            this.cardSales.Location =
                new System.Drawing.Point(30, 145);
            this.cardSales.Size =
                new System.Drawing.Size(260, 125);
            this.cardSales.BackColor =
                System.Drawing.Color.White;
            this.cardSales.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            salesAccent.Dock =
                System.Windows.Forms.DockStyle.Left;
            salesAccent.Width = 6;
            salesAccent.BackColor =
                System.Drawing.Color.FromArgb(31, 130, 145);
            this.cardSales.Controls.Add(salesAccent);

            salesTitle.Text = "TODAY'S SALES";
            salesTitle.AutoSize = true;
            salesTitle.Location =
                new System.Drawing.Point(22, 20);
            salesTitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            salesTitle.ForeColor =
                System.Drawing.Color.DimGray;
            this.cardSales.Controls.Add(salesTitle);

            this.lblTodaysSales.Text = "₱0.00";
            this.lblTodaysSales.AutoSize = true;
            this.lblTodaysSales.Location =
                new System.Drawing.Point(22, 55);
            this.lblTodaysSales.Font = new System.Drawing.Font(
                "Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTodaysSales.ForeColor =
                System.Drawing.Color.FromArgb(31, 130, 145);
            this.cardSales.Controls.Add(this.lblTodaysSales);

            this.content.Controls.Add(this.cardSales);

            // Orders Today Card
            this.cardOrders.Location =
                new System.Drawing.Point(310, 145);
            this.cardOrders.Size =
                new System.Drawing.Size(260, 125);
            this.cardOrders.BackColor =
                System.Drawing.Color.White;
            this.cardOrders.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            ordersAccent.Dock =
                System.Windows.Forms.DockStyle.Left;
            ordersAccent.Width = 6;
            ordersAccent.BackColor =
                System.Drawing.Color.FromArgb(76, 116, 190);
            this.cardOrders.Controls.Add(ordersAccent);

            ordersTitle.Text = "ORDERS TODAY";
            ordersTitle.AutoSize = true;
            ordersTitle.Location =
                new System.Drawing.Point(22, 20);
            ordersTitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            ordersTitle.ForeColor =
                System.Drawing.Color.DimGray;
            this.cardOrders.Controls.Add(ordersTitle);

            this.lblOrdersToday.Text = "0";
            this.lblOrdersToday.AutoSize = true;
            this.lblOrdersToday.Location =
                new System.Drawing.Point(22, 55);
            this.lblOrdersToday.Font = new System.Drawing.Font(
                "Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblOrdersToday.ForeColor =
                System.Drawing.Color.FromArgb(76, 116, 190);
            this.cardOrders.Controls.Add(this.lblOrdersToday);

            this.content.Controls.Add(this.cardOrders);

            // Low Stock Card
            this.cardLowStock.Location =
                new System.Drawing.Point(590, 145);
            this.cardLowStock.Size =
                new System.Drawing.Size(260, 125);
            this.cardLowStock.BackColor =
                System.Drawing.Color.White;
            this.cardLowStock.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            lowStockAccent.Dock =
                System.Windows.Forms.DockStyle.Left;
            lowStockAccent.Width = 6;
            lowStockAccent.BackColor =
                System.Drawing.Color.FromArgb(210, 135, 55);
            this.cardLowStock.Controls.Add(lowStockAccent);

            lowStockTitle.Text = "LOW STOCK PRODUCTS";
            lowStockTitle.AutoSize = true;
            lowStockTitle.Location =
                new System.Drawing.Point(22, 20);
            lowStockTitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lowStockTitle.ForeColor =
                System.Drawing.Color.DimGray;
            this.cardLowStock.Controls.Add(lowStockTitle);

            this.lblLowStockProducts.Text = "0";
            this.lblLowStockProducts.AutoSize = true;
            this.lblLowStockProducts.Location =
                new System.Drawing.Point(22, 55);
            this.lblLowStockProducts.Font = new System.Drawing.Font(
                "Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblLowStockProducts.ForeColor =
                System.Drawing.Color.FromArgb(210, 135, 55);
            this.cardLowStock.Controls.Add(this.lblLowStockProducts);

            this.content.Controls.Add(this.cardLowStock);

            // Active Products Card
            this.cardActiveProducts.Location =
                new System.Drawing.Point(870, 145);
            this.cardActiveProducts.Size =
                new System.Drawing.Size(260, 125);
            this.cardActiveProducts.BackColor =
                System.Drawing.Color.White;
            this.cardActiveProducts.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            activeAccent.Dock =
                System.Windows.Forms.DockStyle.Left;
            activeAccent.Width = 6;
            activeAccent.BackColor =
                System.Drawing.Color.MediumPurple;
            this.cardActiveProducts.Controls.Add(activeAccent);

            activeTitle.Text = "ACTIVE PRODUCTS";
            activeTitle.AutoSize = true;
            activeTitle.Location =
                new System.Drawing.Point(22, 20);
            activeTitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            activeTitle.ForeColor =
                System.Drawing.Color.DimGray;
            this.cardActiveProducts.Controls.Add(activeTitle);

            this.lblActiveProducts.Text = "0";
            this.lblActiveProducts.AutoSize = true;
            this.lblActiveProducts.Location =
                new System.Drawing.Point(22, 55);
            this.lblActiveProducts.Font = new System.Drawing.Font(
                "Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblActiveProducts.ForeColor =
                System.Drawing.Color.MediumPurple;
            this.cardActiveProducts.Controls.Add(this.lblActiveProducts);

            this.content.Controls.Add(this.cardActiveProducts);

            // Quick Actions Panel
            this.actions.Location =
                new System.Drawing.Point(30, 300);
            this.actions.Size =
                new System.Drawing.Size(320, 360);
            this.actions.BackColor =
                System.Drawing.Color.White;
            this.actions.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.content.Controls.Add(this.actions);

            // Quick Actions Title
            actionsTitle.Text = "Quick Actions";
            actionsTitle.AutoSize = true;
            actionsTitle.Font = new System.Drawing.Font(
                "Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            actionsTitle.ForeColor =
                System.Drawing.Color.FromArgb(24, 42, 70);
            actionsTitle.Location =
                new System.Drawing.Point(20, 18);

            this.actions.Controls.Add(actionsTitle);

            // Manage Products Button
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.Location =
                new System.Drawing.Point(20, 65);
            this.btnManageProducts.Size =
                new System.Drawing.Size(275, 42);
            this.btnManageProducts.BackColor =
                System.Drawing.Color.Teal;
            this.btnManageProducts.ForeColor =
                System.Drawing.Color.White;
            this.btnManageProducts.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProducts.FlatAppearance.BorderSize = 0;
            this.btnManageProducts.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageProducts.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnManageProducts.Click +=
                new System.EventHandler(this.ManageProducts_Click);

            this.actions.Controls.Add(this.btnManageProducts);

            // View Inventory Button
            this.btnViewInventory.Text = "View Inventory";
            this.btnViewInventory.Location =
                new System.Drawing.Point(20, 125);
            this.btnViewInventory.Size =
                new System.Drawing.Size(275, 42);
            this.btnViewInventory.BackColor =
                System.Drawing.Color.SteelBlue;
            this.btnViewInventory.ForeColor =
                System.Drawing.Color.White;
            this.btnViewInventory.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInventory.FlatAppearance.BorderSize = 0;
            this.btnViewInventory.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewInventory.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnViewInventory.Click +=
                new System.EventHandler(this.ViewInventory_Click);

            this.actions.Controls.Add(this.btnViewInventory);

            // POS Button
            this.btnPOS.Text = "Point of Sale";
            this.btnPOS.Location =
                new System.Drawing.Point(20, 185);
            this.btnPOS.Size =
                new System.Drawing.Size(275, 42);
            this.btnPOS.BackColor =
                System.Drawing.Color.RoyalBlue;
            this.btnPOS.ForeColor =
                System.Drawing.Color.White;
            this.btnPOS.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPOS.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnPOS.Click +=
                new System.EventHandler(this.POS_Click);

            this.actions.Controls.Add(this.btnPOS);

            // Sales Analytics Button
            this.btnSalesAnalytics.Text = "Sales Analytics";
            this.btnSalesAnalytics.Location =
                new System.Drawing.Point(20, 245);
            this.btnSalesAnalytics.Size =
                new System.Drawing.Size(275, 42);
            this.btnSalesAnalytics.BackColor =
                System.Drawing.Color.RoyalBlue;
            this.btnSalesAnalytics.ForeColor =
                System.Drawing.Color.White;
            this.btnSalesAnalytics.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesAnalytics.FlatAppearance.BorderSize = 0;
            this.btnSalesAnalytics.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalesAnalytics.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnSalesAnalytics.Click +=
                new System.EventHandler(this.SalesAnalytics_Click);

            this.actions.Controls.Add(this.btnSalesAnalytics);

            // User Administration Button
            this.btnUserAdministration.Text = "User Administration";
            this.btnUserAdministration.Location =
                new System.Drawing.Point(20, 305);
            this.btnUserAdministration.Size =
                new System.Drawing.Size(275, 42);
            this.btnUserAdministration.BackColor =
                System.Drawing.Color.FromArgb(45, 75, 110);
            this.btnUserAdministration.ForeColor =
                System.Drawing.Color.White;
            this.btnUserAdministration.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdministration.FlatAppearance.BorderSize = 0;
            this.btnUserAdministration.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUserAdministration.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnUserAdministration.Click += new System.EventHandler(this.UserAdministration_Click);

            this.actions.Controls.Add(this.btnUserAdministration);

            // Recent Sales Panel
            this.recentSales.Location =
                new System.Drawing.Point(370, 300);
            this.recentSales.Size =
                new System.Drawing.Size(650, 270);
            this.recentSales.BackColor =
                System.Drawing.Color.White;
            this.recentSales.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.recentSales.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.content.Controls.Add(this.recentSales);

            // Recent Sales Title
            recentTitle.Text = "Recent Sales";
            recentTitle.AutoSize = true;
            recentTitle.Font = new System.Drawing.Font(
                "Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            recentTitle.ForeColor =
                System.Drawing.Color.FromArgb(24, 42, 70);
            recentTitle.Location =
                new System.Drawing.Point(20, 18);

            this.recentSales.Controls.Add(recentTitle);

            // Empty Sales Message
            emptyMessage.Text = "No sales have been recorded yet.";
            emptyMessage.AutoSize = true;
            emptyMessage.ForeColor =
                System.Drawing.Color.DimGray;
            emptyMessage.Location =
                new System.Drawing.Point(22, 75);

            this.recentSales.Controls.Add(emptyMessage);

            // Footer
            footer.Text =
                "Enterprise POS | Sales and Inventory Management";
            footer.AutoSize = true;
            footer.ForeColor = System.Drawing.Color.Gray;
            footer.Location =
                new System.Drawing.Point(30, 595);

            this.content.Controls.Add(footer);

            this.ResumeLayout(false);
        }
    }
}