using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter_System_UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "employee" && PasswordTextbox.Text == "employee")
            {
                new HomeForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
                UsernameTextbox.Clear();
                PasswordTextbox.Clear();
                UsernameTextbox.Focus();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
