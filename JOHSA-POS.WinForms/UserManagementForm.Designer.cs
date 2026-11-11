
namespace JOHSA_POS.WinForms
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvUsers;

        private System.Windows.Forms.Label lblLastLoginTitle;
        private System.Windows.Forms.Label lblLastLogin;
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

            this.inputPanel = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.dgvUsers = new System.Windows.Forms.DataGridView();

            this.lblLastLoginTitle = new System.Windows.Forms.Label();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();

            this.headerPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Administration";
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Header Panel
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(28, 30, 34);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Size = new System.Drawing.Size(1100, 95);

            // Title
            this.lblTitle.Text = "User Administration";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 12);
            this.lblTitle.Size = new System.Drawing.Size(500, 40);

            // Subtitle
            this.lblSubtitle.Text = "Manage user accounts, roles and access";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitle.Location = new System.Drawing.Point(33, 55);
            this.lblSubtitle.Size = new System.Drawing.Size(500, 25);

            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

            // Input Panel
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.Location = new System.Drawing.Point(25, 115);
            this.inputPanel.Size = new System.Drawing.Size(1050, 190);

            // Username
            this.lblUsername.Text = "Username";
            this.lblUsername.Location = new System.Drawing.Point(20, 18);
            this.lblUsername.Size = new System.Drawing.Size(150, 23);

            this.txtUsername.Location = new System.Drawing.Point(20, 43);
            this.txtUsername.Size = new System.Drawing.Size(300, 27);

            // Full Name
            this.lblFullName.Text = "Full Name";
            this.lblFullName.Location = new System.Drawing.Point(360, 18);
            this.lblFullName.Size = new System.Drawing.Size(150, 23);

            this.txtFullName.Location = new System.Drawing.Point(360, 43);
            this.txtFullName.Size = new System.Drawing.Size(300, 27);

            // Password
            this.lblPassword.Text = "Password";
            this.lblPassword.Location = new System.Drawing.Point(700, 18);
            this.lblPassword.Size = new System.Drawing.Size(150, 23);

            this.txtPassword.Location = new System.Drawing.Point(700, 43);
            this.txtPassword.Size = new System.Drawing.Size(300, 27);
            this.txtPassword.UseSystemPasswordChar = true;

            // Role
            this.lblRole.Text = "Role";
            this.lblRole.Location = new System.Drawing.Point(20, 90);
            this.lblRole.Size = new System.Drawing.Size(150, 23);

            this.cmbRole.Location = new System.Drawing.Point(20, 115);
            this.cmbRole.Size = new System.Drawing.Size(300, 27);
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Status
            this.lblStatus.Text = "Account Status";
            this.lblStatus.Location = new System.Drawing.Point(360, 90);
            this.lblStatus.Size = new System.Drawing.Size(150, 23);

            this.cmbStatus.Location = new System.Drawing.Point(360, 115);
            this.cmbStatus.Size = new System.Drawing.Size(300, 27);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Buttons
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Location = new System.Drawing.Point(700, 105);
            this.btnAddUser.Size = new System.Drawing.Size(140, 38);
            this.btnAddUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.Location = new System.Drawing.Point(855, 105);
            this.btnUpdateUser.Size = new System.Drawing.Size(145, 38);
            this.btnUpdateUser.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // User Grid
            this.dgvUsers.Location = new System.Drawing.Point(25, 330);
            this.dgvUsers.Size = new System.Drawing.Size(1050, 245);
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Reset Password
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.Location = new System.Drawing.Point(25, 600);
            this.btnResetPassword.Size = new System.Drawing.Size(160, 40);
            this.btnResetPassword.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Clear
            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(200, 600);
            this.btnClear.Size = new System.Drawing.Size(120, 40);

            // Last Login
            this.lblLastLoginTitle.Text = "Last Login:";
            this.lblLastLoginTitle.Location = new System.Drawing.Point(370, 608);
            this.lblLastLoginTitle.Size = new System.Drawing.Size(100, 25);

            this.lblLastLogin.Text = "Select a user";
            this.lblLastLogin.Location = new System.Drawing.Point(470, 608);
            this.lblLastLogin.Size = new System.Drawing.Size(300, 25);

            // Close
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(955, 600);
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Add Controls
            this.inputPanel.Controls.Add(this.lblUsername);
            this.inputPanel.Controls.Add(this.txtUsername);
            this.inputPanel.Controls.Add(this.lblFullName);
            this.inputPanel.Controls.Add(this.txtFullName);
            this.inputPanel.Controls.Add(this.lblPassword);
            this.inputPanel.Controls.Add(this.txtPassword);
            this.inputPanel.Controls.Add(this.lblRole);
            this.inputPanel.Controls.Add(this.cmbRole);
            this.inputPanel.Controls.Add(this.lblStatus);
            this.inputPanel.Controls.Add(this.cmbStatus);
            this.inputPanel.Controls.Add(this.btnAddUser);
            this.inputPanel.Controls.Add(this.btnUpdateUser);

            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblLastLoginTitle);
            this.Controls.Add(this.lblLastLogin);
            this.Controls.Add(this.btnClose);

            this.headerPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
