using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JOHSA_POS.Domain;
using JOHSA_POS.Services.Services;

namespace JOHSA_POS.WinForms
{
    public partial class ProductsForm : Form
    {
        private ProductService productService;

        public ProductsForm(JOHSA_POS.Domain.UserRole userRole)
        {
            InitializeComponent();

            if (userRole == JOHSA_POS.Domain.UserRole.Cashier)
            {
                MessageBox.Show("You do not have permission to access Product Management.");

                this.Close();
                return;
            }

            productService = new ProductService();

            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                List<Product> products =
                    productService.GetAllProducts();

                dgvProducts.AutoGenerateColumns = false;
                dgvProducts.Columns.Clear();

                dgvProducts.Columns.Add("ProductId", "ID");
                dgvProducts.Columns["ProductId"].DataPropertyName = "Id";

                dgvProducts.Columns.Add("Sku", "SKU");
                dgvProducts.Columns["Sku"].DataPropertyName = "Sku";

                dgvProducts.Columns.Add("Barcode", "Barcode");
                dgvProducts.Columns["Barcode"].DataPropertyName = "Barcode";

                dgvProducts.Columns.Add("Name", "Product Name");
                dgvProducts.Columns["Name"].DataPropertyName = "Name";

                dgvProducts.Columns.Add("CostPrice", "Cost");
                dgvProducts.Columns["CostPrice"].DataPropertyName = "CostPrice";
                dgvProducts.Columns["CostPrice"].DefaultCellStyle.Format = "N2";

                dgvProducts.Columns.Add("SellingPrice", "Selling Price");
                dgvProducts.Columns["SellingPrice"].DataPropertyName = "SellingPrice";
                dgvProducts.Columns["SellingPrice"].DefaultCellStyle.Format = "N2";

                dgvProducts.Columns.Add("StockQuantity", "Stock");
                dgvProducts.Columns["StockQuantity"].DataPropertyName = "StockQuantity";

                dgvProducts.Columns.Add("ReorderLevel", "Reorder Level");
                dgvProducts.Columns["ReorderLevel"].DataPropertyName = "ReorderLevel";

                dgvProducts.Columns.Add("IsActive", "Active");
                dgvProducts.Columns["IsActive"].DataPropertyName = "IsActive";

                dgvProducts.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load products: " + ex.Message,
                    "Products Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            using (AddProductForm form = new AddProductForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            int productId = Convert.ToInt32(
                dgvProducts.SelectedRows[0].Cells["ProductId"].Value);

            EditProductForm editForm = new EditProductForm(productId);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void BtnDeactivateProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            int productId =
                Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductId"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to deactivate this product?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    productService.DeleteProduct(productId);

                    MessageBox.Show(
                        "Product deactivated successfully.",
                        "Enterprise POS",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Unable to deactivate product: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

    }
}