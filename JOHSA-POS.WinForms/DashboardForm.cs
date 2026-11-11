
using System;
using System.Windows.Forms;

namespace JOHSA_POS.WinForms
{
    public partial class DashboardForm : Form
    {
        private int loggedInUserId;
        private JOHSA_POS.Domain.UserRole loggedInUserRole;

        public DashboardForm(int userId, JOHSA_POS.Domain.UserRole userRole)
        {
            InitializeComponent();

            loggedInUserId = userId;
            loggedInUserRole = userRole;

            role.Text = loggedInUserRole.ToString().ToUpper();

            SetRoleAccess();

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                JOHSA_POS.Services.Services.DashboardService service =
                    new JOHSA_POS.Services.Services.DashboardService();

                lblTodaysSales.Text =
                    "₱" + service.GetTodaysSales().ToString("N2");

                lblOrdersToday.Text =
                    service.GetOrdersToday().ToString();

                lblLowStockProducts.Text =
                    service.GetLowStockProducts().ToString();

                lblActiveProducts.Text =
                    service.GetActiveProducts().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard data: " + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ManageProducts_Click(object sender, EventArgs e)
        {
            using (ProductsForm productsForm = new ProductsForm(loggedInUserRole))
            {
                productsForm.ShowDialog();
            }
        }

        private void ViewInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(loggedInUserId, loggedInUserRole);

            inventoryForm.ShowDialog();
        }

        private void POS_Click(object sender, EventArgs e)
        {
            POSForm posForm = new POSForm(loggedInUserId);
            posForm.ShowDialog();
        }

        private void SalesAnalytics_Click(object sender, EventArgs e)
        {
            SalesAnalyticsForm salesAnalyticsForm =
                new SalesAnalyticsForm();

            salesAnalyticsForm.ShowDialog();
        }

        private void UserAdministration_Click(object sender, EventArgs e)
        {
            UserManagementForm form = new UserManagementForm(loggedInUserId);
            form.ShowDialog();
        }

        private void Header_Resize(object sender, EventArgs e)
        {
            logout.Location = new System.Drawing.Point(
                header.ClientSize.Width - logout.Width - 25, 20);

            role.Location = new System.Drawing.Point(
                logout.Left - role.Width - 25, 30);
        }

        private void SetRoleAccess()
        {
            if (loggedInUserRole == JOHSA_POS.Domain.UserRole.Admin)
            {
                btnManageProducts.Visible = true;
                btnViewInventory.Visible = true;
                btnPOS.Visible = true;
                btnSalesAnalytics.Visible = true;
                btnUserAdministration.Visible = true;
            }
            else if (loggedInUserRole == JOHSA_POS.Domain.UserRole.Manager)
            {
                btnManageProducts.Visible = true;
                btnViewInventory.Visible = true;
                btnPOS.Visible = true;
                btnSalesAnalytics.Visible = true;
                btnUserAdministration.Visible = false;
            }
            else if (loggedInUserRole == JOHSA_POS.Domain.UserRole.Cashier)
            {
                btnManageProducts.Visible = false;
                btnViewInventory.Visible = false;
                btnPOS.Visible = true;
                btnSalesAnalytics.Visible = false;
                btnUserAdministration.Visible = false;
            }
        }
    }
}
