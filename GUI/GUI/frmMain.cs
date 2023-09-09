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

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void bFilter_Click(object sender, EventArgs e)
        {
            ControlManager Cmanager = new ControlManager();
            dgArticles.DataSource = Cmanager.FiltrarPornombredeColumna(tbSearch.Text);
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ControlManager Cmanager = new ControlManager();
            dgArticles.DataSource = Cmanager.FiltrarPornombredeColumna(tbSearch.Text);
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

            ControlManager Cmanager = new ControlManager();
            dgArticles.DataSource = Cmanager.Listacompleta();

        }
    }

}
