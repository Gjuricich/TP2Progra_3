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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void bAddArticle_Click(object sender, EventArgs e)
        {
            Article artNew = new Article();
            AddArticle addArt = new AddArticle();

            try
            {
                artNew.ArtCode = tbCodeArt.Text;
                artNew.Name = tbName.Text;
                artNew.Description = tbDescription.Text;
                if (decimal.TryParse(tbPrice.Text, out decimal price))
                {
                    artNew.Price = price;
                }
                else
                {
                    MessageBox.Show("The price value is not valid.");
                    return;
                }

                //artNew.Marc   Falta

                addArt.add(artNew);
                MessageBox.Show("Successfully added");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            Marc addMarc = new Marc();
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
