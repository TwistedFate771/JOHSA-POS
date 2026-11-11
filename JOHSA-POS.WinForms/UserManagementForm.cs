using JOHSA_POS.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JOHSA_POS.WinForms
{
    public partial class UserManagementForm : Form
    {

        private UserManagementService userManagementService;
        private int selectedUserId;
        private int loggedInUserId;

        public UserManagementForm(int userId)
        {
            InitializeComponent();

            loggedInUserId = userId;

            userManagementService = new UserManagementService();
            selectedUserId = 0;

            LoadRoles();
            LoadStatuses();
            LoadUsers();

            dgvUsers.CellClick += dgvUsers_CellClick;
            btnAddUser.Click += btnAddUser_Click;
            btnUpdateUser.Click += btnUpdateUser_Click;
            btnResetPassword.Click += btnResetPassword_Click;
            btnClear.Click += btnClear_Click;
            btnClose.Click += btnClose_Click;
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = userManagementService.GetAllUsers();

            if (dgvUsers.Columns["UserId"] != null)
            {
                dgvUsers.Columns["UserId"].Visible = false;
            }
        }

        private void LoadRoles()
        {
            cmbRole.Items.Clear();

            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Manager");
            cmbRole.Items.Add("Cashier");

            cmbRole.SelectedIndex = -1;
        }

        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");

            cmbStatus.SelectedIndex = -1;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                selectedUserId = Convert.ToInt32(row.Cells["UserId"].Value);

                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();

                cmbRole.Text = row.Cells["RoleName"].Value.ToString();

                if (Convert.ToBoolean(row.Cells["IsActive"].Value))
                {
                    cmbStatus.Text = "Active";
                }
                else
                {
                    cmbStatus.Text = "Inactive";
                }

                if (row.Cells["LastLoginAt"].Value == DBNull.Value)
                {
                    lblLastLogin.Text = "Never";
                }
                else
                {
                    lblLastLogin.Text =
                        Convert.ToDateTime(row.Cells["LastLoginAt"].Value)
                        .ToString();
                }

                txtPassword.Clear();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" ||
                txtFullName.Text == "" ||
                txtPassword.Text == "" ||
                cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            try
            {
                int roleId = cmbRole.SelectedIndex + 1;

                userManagementService.AddUser(
                    txtUsername.Text,
                    txtPassword.Text,
                    txtFullName.Text,
                    roleId
                );

                userManagementService.CreateAuditLog(
                    loggedInUserId,
                    "Add User",
                    "Added user: " + txtUsername.Text
                );

                MessageBox.Show("User added successfully!");

                LoadUsers();

                txtUsername.Clear();
                txtFullName.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add user: " + ex.Message);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            if (txtFullName.Text == "" ||
                cmbRole.SelectedIndex == -1 ||
                cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            try
            {
                int roleId = cmbRole.SelectedIndex + 1;
                bool isActive = cmbStatus.Text == "Active";

                userManagementService.UpdateUser(
                    selectedUserId,
                    txtFullName.Text,
                    roleId,
                    isActive
                );

                userManagementService.CreateAuditLog(
                    loggedInUserId,
                    "Update User",
                    "Updated user ID: " + selectedUserId
                );

                MessageBox.Show("User updated successfully!");

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update user: " + ex.Message);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter the new password.");
                return;
            }

            try
            {
                userManagementService.ResetPassword(
                    selectedUserId,
                    txtPassword.Text
                );

                userManagementService.CreateAuditLog(
                    loggedInUserId,
                    "Reset Password",
                    "Reset password for user ID: " + selectedUserId
                );

                MessageBox.Show("Password reset successfully!");

                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to reset password: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            selectedUserId = 0;

            txtUsername.Clear();
            txtFullName.Clear();
            txtPassword.Clear();

            cmbRole.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            lblLastLogin.Text = "Never";

            dgvUsers.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
