using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KictureCollege
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void pnlLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm("", "");
            loginForm.Show();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm("", "");
            loginForm.Show();
        }

        private void pnlRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
