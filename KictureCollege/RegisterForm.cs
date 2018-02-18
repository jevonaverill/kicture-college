using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace KictureCollege
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" && txtPassword.Text.Trim() == "" && txtConfirmPassword.Text.Trim() == "" && txtEmail.Text.Trim() == "")
            {
                lblError.Text = "Username, Password, Confirm Password, and Email must be filled";
                lblError.Visible = true;
            }
            else if (txtUsername.Text.Trim() == "" && txtPassword.Text.Trim() != "" && txtConfirmPassword.Text.Trim() == "" && txtEmail.Text.Trim() == "")
            {
                if (txtPassword.Text.Length <= 5 || txtUsername.Text.Length >= 11)
                {
                    lblError.Text = "Password's length must be between 5 and 11 characters";
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Text = "Username, Confirm Password and Email must be filled";
                    lblError.Visible = true;
                }
            }
            else if (txtUsername.Text.Trim() == "" && txtPassword.Text.Trim() == "" && txtConfirmPassword.Text.Trim() != "" && txtEmail.Text.Trim() == "")
            {
                if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    lblError.Text = "Password and Confirm Password must be same";
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Text = "Username, Password, and Email must be filled";
                    lblError.Visible = true;
                }

            }
            else if (txtUsername.Text.Trim() == "" && txtPassword.Text.Trim() == "" && txtConfirmPassword.Text.Trim() == "" && txtEmail.Text.Trim() != "")
            {
                string regexPattern = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[com]{2,4}$";
                
                Match matches = Regex.Match(txtEmail.Text.Trim(), regexPattern);
                if (matches.Success == true)
                {
                    lblError.Text = "Username, Password, and Confirm Password must be filled";
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Text = "Incorrect email format";
                    lblError.Visible = true;
                }
            }
            else if (txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() == "" && txtConfirmPassword.Text.Trim() == "" && txtEmail.Text.Trim() == "")
            {
                if (txtUsername.Text.Length <= 3 || txtUsername.Text.Length >= 10)
                {
                    lblError.Text = "Username's length must be between 3 and 10 characters";
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Text = "Password, Confirm Password, and Email must be filled";
                    lblError.Visible = true;
                }
            }
            else if (txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtConfirmPassword.Text.Trim() == "" && txtEmail.Text.Trim() == "")
            {
                if (txtUsername.Text.Length <= 3 || txtUsername.Text.Length >= 10)
                {
                    lblError.Text = "Username's length must be between 3 and 10 characters";
                    lblError.Visible = true;
                }
                else if (txtPassword.Text.Length <= 5 || txtUsername.Text.Length >= 11)
                {
                    lblError.Text = "Password's length must be between 5 and 11 characters";
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Text = "Confirm Password, and Email must be filled";
                    lblError.Visible = true;
                }
            }
            else if (txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtConfirmPassword.Text.Trim() != "" && txtEmail.Text.Trim() == "")
            {
                if (txtUsername.Text.Length <= 3 || txtUsername.Text.Length >= 10)
                {
                    lblError.Text = "Username's length must be between 3 and 10 characters";
                    lblError.Visible = true;
                }
                else if (txtPassword.Text.Length <= 5 || txtUsername.Text.Length >= 11)
                {
                    lblError.Text = "Password's length must be between 5 and 11 characters";
                    lblError.Visible = true;
                }
                else if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    lblError.Text = "Password and Confirm Password must be same";
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Text = "Email must be filled";
                    lblError.Visible = true;
                }
            }
            else
            {
                if (txtUsername.Text.Length <= 3 || txtUsername.Text.Length >= 10)
                {
                    lblError.Text = "Username's length must be between 3 and 10 characters";
                    lblError.Visible = true;
                }
                else if (txtPassword.Text.Length <= 5 || txtUsername.Text.Length >= 11)
                {
                    lblError.Text = "Password's length must be between 5 and 11 characters";
                    lblError.Visible = true;
                }
                else if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    lblError.Text = "Password and Confirm Password must be same";
                    lblError.Visible = true;
                }
                else
                {
                    //string regexPattern = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[com]{2,4}$";

                    //Match matches = Regex.Match(txtEmail.Text.Trim(), regexPattern);
                    //if (matches.Success == true)
                    //{

                    bool check = CheckValidEmail(txtEmail.Text.Trim());
                    if(check == true)
                    {
                        if (cbxAgreement.Checked == false)
                        {
                            lblError.Text = "Agreement must be checked";
                            lblError.Visible = true;
                        }
                        else
                        {
                            this.Hide();

                            LoginForm loginForm = new LoginForm(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                            loginForm.Show();
                        }
                    }
                    else
                    {
                        lblError.Text = "Incorrect email format";
                        lblError.Visible = true;
                    }
                }
            }
        }

        public bool CheckValidEmail(string email)
        {
            string[] splitEmail = email.Split('@');

            if (splitEmail.Count() != 2)
            {
                return false;
            }

            if (splitEmail[0].Length == 0 || splitEmail[1].Length < 3)
            {
                return false;
            }

            if (!splitEmail[1].Contains("."))
            {
                return false;
            }

            if (!Char.IsLetter((splitEmail[0])[0]))
            {
                return false;
            }

            foreach (char c in email)
            {
                if (!Char.IsLetter(c) && !Char.IsNumber(c) && c != '_' && c != '.' && c != '@')
                {
                    return false;
                }
            }

            if (email.Contains("..") || email.Contains(".@") || email.Contains("@.") || !email.Contains(".com"))
            {
                return false;
            }

            if (email.EndsWith("."))
            {
                return false;
            }

            return true;
        }
    }
}
