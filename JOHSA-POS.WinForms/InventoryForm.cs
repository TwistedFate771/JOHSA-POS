using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JOHSA_POS.Domain;
using JOHSA_POS.Services.Services;

namespace JOHSA_POS.WinForms
{
    public partial class InventoryForm : Form
    {
        private InventoryService inventoryService;
        private List<JOHSA_POS.Domain.Product> inventory;
        private int userId;

        public InventoryForm(int loggedInUserId, JOHSA_POS.Domain.UserRole userRole)
        {
            InitializeComponent();

            if (userRole == JOHSA_POS.Domain.UserRole.Cashier)
            {
                MessageBox.Show("You do not have permission to access Inventory Management.");
                this.Close();
                return;
            }

            inventoryService = new InventoryService();
            inventory = new List<JOHSA_POS.Domain.Product>();
            userId = loggedInUserId;

            LoadInventory();
        }

        private void LoadInventory()
        {
            try
            {
                inventory = inventoryService.GetInventory();

                dgvInventory.DataSource = null;
                dgvInventory.DataSource = inventory;

                dgvInventory.Columns["Id"].HeaderText = "Product ID";
                dgvInventory.Columns["Sku"].HeaderText = "SKU";
                dgvInventory.Columns["Name"].HeaderText = "Product Name";
                dgvInventory.Columns["StockQuantity"].HeaderText = "Stock";
                dgvInventory.Columns["ReorderLevel"].HeaderText = "Reorder Level";
                dgvInventory.Columns["IsActive"].Visible = false;

                UpdateLowStockCount();
                SearchInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load inventory: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateLowStockCount()
        {
            int lowStockCount = 0;

            foreach (JOHSA_POS.Domain.Product product in inventory)
            {
                if (product.StockQuantity <= product.ReorderLevel)
                {
                    lowStockCount++;
                }
            }

            lblLowStock.Text = "Low Stock Items: " + lowStockCount;
        }

        private void SearchInventory()
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            List<JOHSA_POS.Domain.Product> filteredProducts =
                new List<JOHSA_POS.Domain.Product>();

            foreach (JOHSA_POS.Domain.Product product in inventory)
            {
                if (product.Name.ToLower().Contains(searchText) ||
                    product.Sku.ToLower().Contains(searchText))
                {
                    filteredProducts.Add(product);
                }
            }

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = filteredProducts;

            dgvInventory.Columns["Id"].HeaderText = "Product ID";
            dgvInventory.Columns["Sku"].HeaderText = "SKU";
            dgvInventory.Columns["Name"].HeaderText = "Product Name";
            dgvInventory.Columns["StockQuantity"].HeaderText = "Stock";
            dgvInventory.Columns["ReorderLevel"].HeaderText = "Reorder Level";
            dgvInventory.Columns["IsActive"].Visible = false;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchInventory();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadInventory();
        }

        private void BtnStockIn_Click(object sender, EventArgs e)
        {
            ChangeStock(true);
        }

        private void BtnStockOut_Click(object sender, EventArgs e)
        {
            ChangeStock(false);
        }

        private void ChangeStock(bool isStockIn)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            int productId = Convert.ToInt32(
                dgvInventory.SelectedRows[0].Cells["Id"].Value);

            string productName =
                dgvInventory.SelectedRows[0].Cells["Name"].Value.ToString();

            string action = isStockIn ? "add" : "remove";

            string quantityText = ShowInputDialog(
                "Enter the quantity to " + action + " for " + productName,
                isStockIn ? "Stock In" : "Stock Out");

            if (string.IsNullOrWhiteSpace(quantityText))
            {
                return;
            }

            int quantity;

            if (!int.TryParse(quantityText, out quantity) || quantity <= 0)
            {
                MessageBox.Show(
                    "Please enter a whole number greater than zero.");
                return;
            }

            string reason = ShowInputDialog(
                "Enter the reason for this inventory movement.",
                "Inventory Reason");

            if (string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Please enter a reason.");
                return;
            }

            try
            {
                if (isStockIn)
                {
                    inventoryService.AddStock(
                        productId, quantity, reason, userId);
                }
                else
                {
                    inventoryService.RemoveStock(
                        productId, quantity, reason, userId);
                }

                MessageBox.Show(
                    "Inventory updated successfully!",
                    "Enterprise POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update inventory: " + ex.Message,
                    "Inventory Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string ShowInputDialog(string message, string title)
        {
            Form inputForm = new Form();
            inputForm.Text = title;
            inputForm.Size = new System.Drawing.Size(400, 180);
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.MaximizeBox = false;
            inputForm.MinimizeBox = false;

            Label lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.Location = new System.Drawing.Point(15, 15);
            lblMessage.Size = new System.Drawing.Size(350, 35);

            TextBox txtInput = new TextBox();
            txtInput.Location = new System.Drawing.Point(15, 55);
            txtInput.Size = new System.Drawing.Size(350, 25);

            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new System.Drawing.Point(185, 95);
            btnOK.Size = new System.Drawing.Size(80, 30);
            btnOK.DialogResult = DialogResult.OK;

            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Location = new System.Drawing.Point(275, 95);
            btnCancel.Size = new System.Drawing.Size(90, 30);
            btnCancel.DialogResult = DialogResult.Cancel;

            inputForm.Controls.Add(lblMessage);
            inputForm.Controls.Add(txtInput);
            inputForm.Controls.Add(btnOK);
            inputForm.Controls.Add(btnCancel);

            inputForm.AcceptButton = btnOK;
            inputForm.CancelButton = btnCancel;

            if (inputForm.ShowDialog(this) == DialogResult.OK)
            {
                return txtInput.Text.Trim();
            }

            return "";
        }
    }
}