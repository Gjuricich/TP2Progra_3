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
    
        private List<UrlImage> listUrlImage;

        public frmAdd()
        {
            InitializeComponent();
            pbAddImage.AllowDrop = false;
            listUrlImage = new List<UrlImage>();
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
                artNew.Images = listUrlImage;
                artNew.Brand=(Brand)cbBrand.SelectedItem;
                artNew.Category= (Category)cbCategory.SelectedItem;

                iManager.add(artNew);
                MessageBox.Show("Successfully added");
                listUrlImage.Clear();
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
            CategoryManager cManager = new CategoryManager();
            cbBrand.DataSource = bManger.listar();
            cbCategory.DataSource = cManager.listar();

        }


        //borrar al final
        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {           
            
        }

        private void pbAddImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbAddImage_DragDrop(object sender, DragEventArgs e)
        {
            Image img;
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                
                img = Image.FromFile(pic);
                pbAddImage.Image = img;
            }
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            String img;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img = ofd.FileName;
                    pbAddImage.Image = Image.FromFile(ofd.FileName);
                }
            }

        }

        private void bAddImage_Click(object sender, EventArgs e)
        {
            pbAddImage.Load(tbUrlImage.Text);
        }

        private void bSaveImage_Click(object sender, EventArgs e)
        {
            UrlImage aux = new UrlImage();
            aux.Url = tbUrlImage.Text;
            listUrlImage.Add(aux);
            pbAddImage.Image = null;
            tbUrlImage.Clear();
        }
    }
}
