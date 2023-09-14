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
            
            ItemManager iManager = new ItemManager();


            try
            {   
                if(item == null)
                {
                    Item item = new Item();
                }
                item.ItemCode = tbCodeArt.Text;
                item.Name = tbName.Text;
                item.Description = tbDescription.Text;
                if (decimal.TryParse(tbPrice.Text, out decimal price))
                {
                    item.Price = price;
                }
                else
                {
                    MessageBox.Show("The price value is not valid.");
                    return;
                }

                item.Brand=(Brand)cbBrand.SelectedItem;
                item.Category= (Category)cbCategory.SelectedItem;
                //Pisa la lista que traia el objeto cuando modifico

                if (item.Images[0].Id != 0)
                {
                    for (int i = 0; i < item.Images.Count(); i++)
                    {
                        item.Images[i].Url= listUrlImage[i].Url;
                     
                    }                  
                                       
   
                }
                else
                {
                    item.Images = listUrlImage;
                }

                if (item.Id != 0)
                {

                    iManager.edit(item);
                    MessageBox.Show("Successfully edited");
                }
                else
                {
                    iManager.add(item);
                    MessageBox.Show("Successfully added");
                }
                
               
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
                    UrlImageManager aux = new UrlImageManager();
                    item.Images = aux.imagesOfItems(item.Id);
                    //tbUrlImage.Text =item.Images.

                  

                    foreach (UrlImage elemento in item.Images)
                    {
                        pbAddImage.Load(elemento.Url);
                    }


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            //if (item == null)
            //{
             
                listUrlImage.Add(aux);
                pbAddImage.Image = null;
                tbUrlImage.Clear();
            //}
           
            //else
            //{

                //pbAddImage.ImageLocation;
                //item.Images;
             //}

        }

        private void bclear_Click(object sender, EventArgs e)
        {
            pbAddImage.Image = null;
            tbUrlImage.Clear();
        }
    }
}
