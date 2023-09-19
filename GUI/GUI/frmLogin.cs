using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked == true)
                tbPassword.UseSystemPasswordChar = false;
            else
                tbPassword.UseSystemPasswordChar = true;

        }

        private void bLoginUserGuest_Click(object sender, EventArgs e)
        {
            frmMain windowGuest = new frmMain();
            windowGuest.ShowDialog();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (authentication())
            {
                frmMain windowUser = new frmMain();
                windowUser.showBottons(true);
                windowUser.ShowDialog();
                tbPassword.Text = "";
                tbUser.Text = "";

            }
            else
                MessageBox.Show("Login failed(User: Maxi - Password: programa)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private bool authentication()
        {
            if (tbUser.Text.ToLower() == "maxi" && tbPassword.Text == "programa")
                return true;
            else
                return false;
        }

   
    }
}
