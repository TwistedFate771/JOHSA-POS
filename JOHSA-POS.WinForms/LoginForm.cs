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

namespace JOHSA_POS.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Please enter your username and password.";
                return;
            }

            try
            {
                JOHSA_POS.Domain.User user =
                    loginService.Login(username, password);

                if (user == null)
                {
                    lblMessage.Text = "Invalid username or password.";
                    return;
                }

                DashboardForm dashboard = new DashboardForm(user.Id, user.Role);
                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login failed: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
