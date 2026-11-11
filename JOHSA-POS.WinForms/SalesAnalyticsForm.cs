using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JOHSA_POS.Services.Services;

namespace JOHSA_POS.WinForms
{
    public partial class SalesAnalyticsForm : Form
    {
        private SalesAnalyticsService salesAnalyticsService;

        public SalesAnalyticsForm()
        {
            InitializeComponent();

            salesAnalyticsService = new SalesAnalyticsService();

            LoadReports();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReports();

            MessageBox.Show("Sales reports refreshed successfully.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadReports()
        {
            try
            {
                // Load Sales Summary
                System.Data.DataTable summary =
                    salesAnalyticsService.GetSalesSummary();

                lblTotalOrders.Text =
                    summary.Rows[0]["TotalOrders"].ToString();

                lblTotalSales.Text =
                    "₱" + Convert.ToDecimal(
                        summary.Rows[0]["TotalSales"]).ToString("N2");

                lblTotalDiscounts.Text =
                    "₱" + Convert.ToDecimal(
                        summary.Rows[0]["TotalDiscounts"]).ToString("N2");

                lblTotalTax.Text =
                    "₱" + Convert.ToDecimal(
                        summary.Rows[0]["TotalTax"]).ToString("N2");

                // Load Daily Sales
                dgvDailySales.DataSource =
                    salesAnalyticsService.GetDailySales();

                // Load Monthly Sales
                dgvMonthlySales.DataSource =
                    salesAnalyticsService.GetMonthlySales();

                // Load Payment Methods
                dgvPaymentSales.DataSource =
                    salesAnalyticsService.GetSalesByPaymentMethod();

                // Load Top Selling Products
                dgvTopProducts.DataSource =
                    salesAnalyticsService.GetTopSellingProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load sales reports: " + ex.Message);
            }
        }
    }
}
