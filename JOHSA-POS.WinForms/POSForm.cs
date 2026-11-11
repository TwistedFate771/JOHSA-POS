
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JOHSA_POS.Services.Services;
using JOHSA_POS.Domain;

namespace JOHSA_POS.WinForms
{
    public partial class POSForm : Form
    {
        private int loggedInUserId;
        private ProductService productService;
        private CustomerService customerService;
        private OrderService orderService;
        private List<JOHSA_POS.Domain.Product> products;
        private List<Customer> customers;
        private List<CartItem> cart;

        public POSForm(int userId)
        {
            InitializeComponent();

            loggedInUserId = userId;

            productService = new ProductService();
            customerService = new CustomerService();
            orderService = new OrderService();

            products = new List<JOHSA_POS.Domain.Product>();
            customers = new List<Customer>();
            cart = new List<CartItem>();

            LoadProducts();
            LoadCustomers();

            SetupCartGrid();

            btnAddToCart.Click += btnAddToCart_Click;
            btnRemoveItem.Click += btnRemoveItem_Click;
            btnClearCart.Click += btnClearCart_Click;
            btnCompleteSale.Click += btnCompleteSale_Click;

            numDiscount.ValueChanged += numDiscount_ValueChanged;
            txtAmountPaid.TextChanged += txtAmountPaid_TextChanged;
            cmbPaymentMethod.SelectedIndexChanged += cmbPaymentMethod_SelectedIndexChanged;

            cmbPaymentMethod.SelectedIndex = 0;

            CalculateTotal();
        }

        private void LoadProducts()
        {
            try
            {
                products = productService.GetAllProducts();

                List<JOHSA_POS.Domain.Product> activeProducts =
                    new List<JOHSA_POS.Domain.Product>();

                foreach (JOHSA_POS.Domain.Product product in products)
                {
                    if (product.IsActive)
                    {
                        product.Name = product.Name + " - Stock: " +
                            product.StockQuantity;

                        activeProducts.Add(product);
                    }
                }

                cmbProduct.DataSource = null;
                cmbProduct.DataSource = activeProducts;
                cmbProduct.DisplayMember = "Name";
                cmbProduct.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load products: " + ex.Message);
            }
        }

        private void LoadCustomers()
        {
            try
            {
                customers = customerService.GetAllCustomers();

                cmbCustomer.Items.Clear();
                cmbCustomer.Items.Add("Walk-in Customer");

                foreach (Customer customer in customers)
                {
                    cmbCustomer.Items.Add(customer.FullName);
                }

                cmbCustomer.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load customers: " + ex.Message);
            }
        }

        private void SetupCartGrid()
        {
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add("ProductId", "Product ID");
            dgvCart.Columns.Add("ProductName", "Product");
            dgvCart.Columns.Add("UnitPrice", "Unit Price");
            dgvCart.Columns.Add("Quantity", "Quantity");
            dgvCart.Columns.Add("LineTotal", "Subtotal");

            dgvCart.Columns["ProductId"].Visible = false;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            JOHSA_POS.Domain.Product selectedProduct =
                (JOHSA_POS.Domain.Product)cmbProduct.SelectedItem;

            int quantity = (int)numQuantity.Value;

            if (quantity > selectedProduct.StockQuantity)
            {
                MessageBox.Show("Not enough stock available.");
                return;
            }

            CartItem existingItem = null;

            foreach (CartItem item in cart)
            {
                if (item.ProductId == selectedProduct.Id)
                {
                    existingItem = item;
                    break;
                }
            }

            if (existingItem != null)
            {
                if (existingItem.Quantity + quantity > selectedProduct.StockQuantity)
                {
                    MessageBox.Show("Not enough stock available.");
                    return;
                }

                existingItem.Quantity += quantity;
                existingItem.LineTotal = existingItem.Quantity * existingItem.UnitPrice;
            }
            else
            {
                CartItem newItem = new CartItem();

                newItem.ProductId = selectedProduct.Id;
                newItem.ProductName = selectedProduct.Name;
                newItem.UnitPrice = selectedProduct.SellingPrice;
                newItem.Quantity = quantity;
                newItem.LineTotal = newItem.UnitPrice * quantity;

                cart.Add(newItem);
            }

            DisplayCart();

            numQuantity.Value = 1;
        }

        private void DisplayCart()
        {
            dgvCart.Rows.Clear();

            foreach (CartItem item in cart)
            {
                dgvCart.Rows.Add(
                    item.ProductId,
                    item.ProductName,
                    item.UnitPrice.ToString("N2"),
                    item.Quantity,
                    item.LineTotal.ToString("N2"));
            }

            CalculateTotal();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            int selectedIndex = dgvCart.SelectedRows[0].Index;

            cart.RemoveAt(selectedIndex);

            DisplayCart();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("The cart is already empty.");
                return;
            }

            cart.Clear();

            DisplayCart();
        }

        private void CalculateTotal()
        {
            decimal subtotal = 0;

            foreach (CartItem item in cart)
            {
                subtotal += item.LineTotal;
            }

            decimal discount = numDiscount.Value;

            if (discount > subtotal)
            {
                discount = subtotal;
                numDiscount.Value = subtotal;
            }

            decimal tax = Math.Round((subtotal - discount) * 12 / 100, 2);
            decimal total = subtotal + tax - discount;

            lblSubtotalValue.Text = "₱" + subtotal.ToString("N2");
            lblTaxValue.Text = "₱" + tax.ToString("N2");
            lblTotalValue.Text = "₱" + total.ToString("N2");

            CalculateChange();
        }

        private void CalculateChange()
        {
            decimal subtotal = 0;

            foreach (CartItem item in cart)
            {
                subtotal += item.LineTotal;
            }

            decimal discount = numDiscount.Value;

            if (discount > subtotal)
            {
                discount = subtotal;
            }

            decimal tax = Math.Round((subtotal - discount) * 12 / 100, 2);
            decimal total = subtotal + tax - discount;

            decimal amountPaid;

            if (decimal.TryParse(txtAmountPaid.Text, out amountPaid))
            {
                if (cmbPaymentMethod.Text == "Cash" && amountPaid >= total)
                {
                    lblChangeValue.Text =
                        "₱" + (amountPaid - total).ToString("N2");
                }
                else
                {
                    lblChangeValue.Text = "₱0.00";
                }
            }
            else
            {
                lblChangeValue.Text = "₱0.00";
            }
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Please add products to the cart first.");
                return;
            }

            decimal total = GetSaleTotal();

            if (txtAmountPaid.Text == "")
{
    MessageBox.Show("Please enter the amount paid.");
    return;
}

decimal amountPaid = Convert.ToDecimal(txtAmountPaid.Text);

            if (amountPaid < total)
            {
                MessageBox.Show("Amount paid is not enough.");
                return;
            }

            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            int? customerId = null;

            if (cmbCustomer.SelectedIndex > 0)
            {
                customerId = customers[cmbCustomer.SelectedIndex - 1].CustomerId;
            }

            try
            {
                int orderId = orderService.CompleteSale(
                    loggedInUserId,
                    customerId,
                    cmbPaymentMethod.Text,
                    numDiscount.Value,
                    12m,
                    amountPaid,
                    cart
                );

                MessageBox.Show(
                    "Sale completed successfully!\nOrder ID: " + orderId
                );

                cart.Clear();
                DisplayCart();

                numDiscount.Value = 0;
                txtAmountPaid.Clear();

                lblChangeValue.Text = "₱0.00";

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to complete sale: " + ex.Message);
            }
        }

        private decimal GetSaleTotal()
        {
            decimal subtotal = 0;

            foreach (CartItem item in cart)
            {
                subtotal += item.LineTotal;
            }

            decimal discount = numDiscount.Value;

            if (discount > subtotal)
            {
                discount = subtotal;
            }

            decimal tax = Math.Round((subtotal - discount) * 12 / 100, 2);

            return subtotal + tax - discount;
        }
        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }
    }
}
