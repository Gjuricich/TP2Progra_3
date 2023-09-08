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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void showBottons(bool show)
        {
            bAdd.Visible = show;
            bEdit.Visible = show;
            bDelete.Visible = show;
            tituleUser.Text = "Maxi Programa";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            frmAdd windowAdd = new frmAdd();
            windowAdd.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            frmEdit windowEdit = new frmEdit();
            windowEdit.ShowDialog();

        }
    }
}
