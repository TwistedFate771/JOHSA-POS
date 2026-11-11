using JOHSA_POS.Domain;
using JOHSA_POS.Services.Services;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JOHSA_POS.WinForms
{
    public partial class EditProductForm : Form
    {
        private ProductService productService;
        private Product product;

        public EditProductForm(int productId)
        {
            InitializeComponent();

            productService = new ProductService();

            LoadCategories();
            LoadProduct(productId);
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

        private void LoadProduct(int productId)
        {
            try
            {
                var products = productService.GetAllProducts();

                foreach (Product item in products)
                {
                    if (item.Id == productId)
                    {
                        product = item;
                        break;
                    }
                }

                if (product == null)
                {
                    MessageBox.Show("Product not found.");
                    Close();
                    return;
                }

                txtSku.Text = product.Sku;
                txtBarcode.Text = product.Barcode;
                txtName.Text = product.Name;
                txtCost.Text = product.CostPrice.ToString();
                txtPrice.Text = product.SellingPrice.ToString();
                txtStock.Text = product.StockQuantity.ToString();
                txtReorderLevel.Text = product.ReorderLevel.ToString();

                cmbCategory.SelectedValue = product.CategoryId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load product: " + ex.Message,
                    "Error",
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

            if (product == null)
            {
                MessageBox.Show("No product is selected.");
                return;
            }

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

            product.Sku = txtSku.Text.Trim();
            product.Barcode = txtBarcode.Text.Trim();
            product.Name = txtName.Text.Trim();
            product.CategoryId = (int)cmbCategory.SelectedValue;
            product.CostPrice = cost;
            product.SellingPrice = price;
            product.StockQuantity = stock;
            product.ReorderLevel = reorderLevel;

            try
            {
                productService.UpdateProduct(product);

                MessageBox.Show(
                    "Product updated successfully!",
                    "Enterprise POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update product: " + ex.Message,
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