using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Managers;

namespace GUI
{
    public partial class frmAdd : Form
    {
        private List<Brand> listBrand;
        private List<Category> listCategory;
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
            Item artNew = new Item();
            ItemManager iManager = new ItemManager();


            try
            {
                artNew.ItemCode = tbCodeArt.Text;
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

               // artNew.Brand = cbBrand.//Me tiene que devolver el id
               // artNew.Category = cbCategory.//Me tiene que devolver el id

                iManager.add(artNew);
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

            BrandManager bManger = new BrandManager();
            listBrand = bManger.listar();

            for(int x=0; x<listBrand.Count(); x++)
            {
                 cbBrand.Items.Add(listBrand[x].Descripcion);
            }

            CategoryManager cManager = new CategoryManager();
            listCategory = cManager.listar();

            for (int i = 0; i < listCategory.Count(); i++)
            {
                cbCategory.Items.Add(listCategory[i].Descripcion);
            }
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {           
            
        }
    }
}
