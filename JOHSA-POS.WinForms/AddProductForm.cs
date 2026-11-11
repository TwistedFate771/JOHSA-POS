using System;
using System.Windows.Forms;
using JOHSA_POS.Domain;
using JOHSA_POS.Services.Services;

namespace JOHSA_POS.WinForms
{
    public partial class AddProductForm : Form
    {
        private ProductService productService;

        public AddProductForm()
        {
            InitializeComponent();

            productService = new ProductService();

            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                cmbCategory.DataSource = productService.GetCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load categories: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int stock;
            int reorderLevel;
            decimal cost;
            decimal price;

            if (string.IsNullOrWhiteSpace(txtSku.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter the SKU and product name.");
                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out stock) ||
                !int.TryParse(txtReorderLevel.Text, out reorderLevel) ||
                !decimal.TryParse(txtCost.Text, out cost) ||
                !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show(
                    "Please enter valid numbers for cost, price, stock, and reorder level.");
                return;
            }

            if (stock < 0 || reorderLevel < 0 ||
                cost < 0 || price < 0)
            {
                MessageBox.Show(
                    "Please enter non-negative values.");
                return;
            }

            int categoryId = (int)cmbCategory.SelectedValue;

            Product product = new Product();

            product.Sku = txtSku.Text.Trim();
            product.Barcode = txtBarcode.Text.Trim();
            product.Name = txtName.Text.Trim();
            product.CategoryId = categoryId;
            product.CostPrice = cost;
            product.SellingPrice = price;
            product.StockQuantity = stock;
            product.ReorderLevel = reorderLevel;
            product.IsActive = true;

            try
            {
                productService.AddProduct(product);

                MessageBox.Show(
                    "Product added successfully!",
                    "Enterprise POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add product: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}