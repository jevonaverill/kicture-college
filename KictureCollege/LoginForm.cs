using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KictureCollege
{
    public partial class LoginForm : Form
    {
        string loginUsername, loginPassword;

        public LoginForm(string Username, string Password)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            loginUsername = Username.Trim();
            loginPassword = Password.Trim();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" && txtPassword.Text.Trim() == "")
            {
                lblError.Text = "Username and Password must be filled";
                lblError.Visible = true;
            }
            else if (txtUsername.Text.Trim() == "")
            {
                lblError.Text = "Username must be filled";
                lblError.Visible = true;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                lblError.Text = "Password must be filled";
                lblError.Visible = true;
            }
            else
            {
                if (txtUsername.Text.Trim() == loginUsername && txtPassword.Text.Trim() == loginPassword)
                {
                    this.Hide();

                    HomeForm homeForm = new HomeForm();
                    homeForm.Show();
                }
                else
                {
                    lblError.Text = "Invalid Username or Password";
                    lblError.Visible = true;
                }
            }
        }

    }
}
