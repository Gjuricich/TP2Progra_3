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
using System.Xml.Linq;
using Domain;
using Managers;

namespace GUI
{
    public partial class frmAddEdit : Form
    {
    
        private List<UrlImage> listUrlImage;
        private Item item = null;
        private int currentIndex = 0;
      

       
       

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
                    currentIndex = 0;
                    LoadImageAtIndex(currentIndex);



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //////////////////////////////           Index                ///////////////////////////////////

        private void LoadImageAtIndex(int index)
        {
            try
            {
                if (item.Images.Count() != 0 && index >= 0 && index < item.Images.Count())
                {
                    // Carga la URL en función del índice actual

                    if (item.Images[currentIndex].Url != "")
                        pbAddImage.Load(item.Images[index].Url);

                }
            }
            catch (System.Net.WebException)
            {

                pbAddImage.Load("https://lh3.googleusercontent.com/drive-viewer/AITFw-wS6RAUNTNl47sUUVoPu5qMvbp08NQ48aWAXQUFn-TsDK8497WjmJavnGyi0sS0Uvknmg17fx6wTY7MQYhYDIIRn551=w1366-h618");
                //MessageBox.Show(ex.ToString() + " La Ruta : " + url[index] + " es inaccesible");

            }
        }


        private void pbBackward_Click_1(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                LoadImageAtIndex(currentIndex);
            }
        }

        private void pbfoward_Click_1(object sender, EventArgs e)
        {
            if (currentIndex < item.Images.Count - 1)
            {
                currentIndex++;
                LoadImageAtIndex(currentIndex);
            }
        }

 

        //////////////////////////////           Bottons Events             ///////////////////////////////////

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void bAddArticle_Click(object sender, EventArgs e)
        {
            
            ItemManager iManager = new ItemManager();
            Item item = null;

            try
            {   
                if(item == null)
                {
                     item = new Item();
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

                if (item.Images != null && item.Images.Count > 0 && item.Images[0].Id != 0)
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
            string url = tbUrlImage.Text;

            do
            {
                if (IsValidUrl(url))
                {
                    pbAddImage.Load(url);
                    break; 
                }
                else
                {
                    MessageBox.Show("Plis, add a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            while (true);

            pbAddImage.Load(tbUrlImage.Text);
        }

        private bool IsValidUrl(string url)
        {
            Uri result;
            return Uri.TryCreate(url, UriKind.Absolute, out result) &&
                   (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);


        }


        private void bSaveImage_Click(object sender, EventArgs e)
        {
            UrlImage aux = new UrlImage();
            aux.Url = tbUrlImage.Text;
            //if (item == null)
            //{
             
                //listUrlImage.Add(aux);
                //pbAddImage.Image = null;
                //tbUrlImage.Clear();
            //}

            //else
            //{

            //pbAddImage.ImageLocation;
            //item.Images;
            //}

            do
            {
                if (IsValidUrl(aux.Url))
                {
                    pbAddImage.Load(aux.Url);
                    break;
                }
                else
                {
                    MessageBox.Show("Plis, add a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            while (true);
            listUrlImage.Add(aux);
            pbAddImage.Image = null;
            tbUrlImage.Clear();

        }

        private void bclear_Click(object sender, EventArgs e)
        {
            pbAddImage.Image = null;
            tbUrlImage.Clear();
        }

     

        //////////////////////////////           Methods Validation               ///////////////////////////////////
    }



}
