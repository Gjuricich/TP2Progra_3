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

        private void tituleLogin_Click(object sender, EventArgs e)
        {

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked == true)
                tbPassword.UseSystemPasswordChar = true;
            else
                tbPassword.UseSystemPasswordChar = false;

        }

        private void bLoginUserGuest_Click(object sender, EventArgs e)
        {
            frmMain ventana = new frmMain();
            ventana.ShowDialog();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
