using System;
using System.Windows.Forms;
using BLL;

namespace WinFormUI
{
    public partial class LoginForm : Form
    {
        UserBLL userBLL = new UserBLL();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please enter username & password.");
                return;
            }

            bool ok = userBLL.Login(txtUser.Text, txtPass.Text);

            if (ok)
            {
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Username found!", "Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
