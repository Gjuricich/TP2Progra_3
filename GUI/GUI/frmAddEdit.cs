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
    public partial class frmAddEdit : Form
    {
    
        private List<UrlImage> listUrlImage;
        private Item item = null;

        public frmAddEdit()
        {
            InitializeComponent();
            pbAddImage.AllowDrop = false;
            listUrlImage = new List<UrlImage>();
        }

        public frmAddEdit(Item item)
        {
            InitializeComponent();
            pbAddImage.AllowDrop = false;
            listUrlImage = new List<UrlImage>();
            this.item = item;
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
                artNew.Images = listUrlImage;
                
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

            try
            {
                cbBrand.DataSource = bManger.listar(); 
                cbBrand.ValueMember = "Id";      
                cbBrand.DisplayMember = "Descripcion";
                cbCategory.DataSource = cManager.listar();
                cbCategory.ValueMember = "Id";
                cbCategory.DisplayMember = "Descripcion";

                if (item != null)
                {
                    tbCodeArt.Text = item.ItemCode;
                    tbName.Text = item.Name;
                    tbDescription.Text = item.Description;
                    tbPrice.Text = item.Price.ToString();
                    cbBrand.SelectedValue = item.Brand.Id;
                    cbCategory.SelectedValue = item.Category.Id;
                    // falta cargar las imagenes


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //borrar al final
     

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

        private void bclear_Click(object sender, EventArgs e)
        {
            pbAddImage.Image = null;
            tbUrlImage.Clear();
        }
    }
}
