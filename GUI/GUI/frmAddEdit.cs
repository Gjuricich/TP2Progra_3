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
    
        private List<UrlImage> listUrlImage = null;
        private Item item = null;
        private int currentIndex = 0;
        private bool empty = false;

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
            UrlImageManager aux = new UrlImageManager();

            try
            {
                cbBrand.DataSource = bManger.listar();
                cbBrand.ValueMember = "Id";
                cbBrand.DisplayMember = "Descripcion";
                cbCategory.DataSource = cManager.listar();
                cbCategory.ValueMember = "Id";
                cbCategory.DisplayMember = "Descripcion";

                pbfoward.Visible = false;
                pbBackward.Visible = false;
                pbAddImage.BorderStyle = BorderStyle.Fixed3D;
                bDelete.Visible = false;
                bAddImage.Visible = false;
                bEditImage.Visible = false;
                bSaveChanges.Visible = false;

                if (item != null)
                {
                    pbfoward.Visible = true;
                    pbBackward.Visible = true;
                    bDelete.Visible = true;
                    bAddImage.Visible = true;
                    bEditImage.Visible = true;
                    bSaveImage.Visible = false;
                    bSaveChanges.Visible = true;
                    pbAddImage.BorderStyle = BorderStyle.None;

                    tbCodeArt.Text = item.ItemCode;
                    tbName.Text = item.Name;
                    tbDescription.Text = item.Description;
                    tbPrice.Text = item.Price.ToString();
                    cbBrand.SelectedValue = item.Brand.Id;
                    cbCategory.SelectedValue = item.Category.Id;
                    item.Images = aux.imagesOfItems(item.Id);
                   

                    if (item.Images != null && item.Images.Count > 0)
                    {      
                        LoadImageAtIndex(currentIndex);
                        tbUrlImage.Text = item.Images[currentIndex].Url;
                    }
                   
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
                        tbUrlImage.Text = item.Images[index].Url;


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
                tbUrlImage.Text = item.Images[currentIndex].Url;
            }
        }

        private void pbfoward_Click_1(object sender, EventArgs e)
        {
            if (currentIndex < item.Images.Count - 1)
            {
                currentIndex++;
                LoadImageAtIndex(currentIndex);
                tbUrlImage.Text = item.Images[currentIndex].Url;
            }
        }

 

        //////////////////////////////           Bottons Events             ///////////////////////////////////

    
        private void bAddArticle_Click(object sender, EventArgs e)
        {
            
            ItemManager iManager = new ItemManager();
            
          
            try
            {   
                if(item == null)
                {
                     item = new Item();
                     if(listUrlImage != null)
                    {
                        item.Images = listUrlImage;
                    }
                    else
                    {
                        empty = true;
                    }
                     
                }

                if (item.Images != null && item.Images.Count > 0)
                {
                    for (int i = 0; i < item.Images.Count(); i++)
                    {
                        item.Images[0].Url = listUrlImage[0].Url; //lo hace solo para una unica imagen con id existente

                    }
                }
                else
                {
                    empty = true;
                    item.Images = listUrlImage;
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
          

                if (item.Id != 0)
                {

                    iManager.edit(item,empty);
                    MessageBox.Show("Successfully edited");
                }
                else
                {

                    iManager.add(item, empty);
                    MessageBox.Show("Agregado exitosamente.");
                }
          

                listUrlImage.Clear();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            if (item == null)
            {
                listUrlImage.Add(aux);
                pbAddImage.Image = null;
                tbUrlImage.Clear();
            }
            else
            {
                //se guardan los cambios add, delete, edit
            }

     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbAddImage.Image = null;
            tbUrlImage.Clear();

        }

        private void bExit_Click(object sender, EventArgs e)
        {
          
            Close();

        }

        //SOLO FUNCIONA EN LA VENTANA EDIT - FALTA BOTON SAVE CAMBIOS Y CONSULTAS
        private void bAddImage_Click_1(object sender, EventArgs e)
        {   

        
            UrlImage aux = new UrlImage();
            aux.Url = tbUrlImage.Text;
            aux.IdArticulo = item.Images[0].IdArticulo;
            listUrlImage = item.Images;
            item.Images.Add(aux);
            pbAddImage.Image = null;
            tbUrlImage.Clear();
            LoadImageAtIndex(currentIndex);
        }


        //SOLO FUNCIONA EN LA VENTANA EDIT - FALTA BOTON SAVE CAMBIOS Y CONSULTAS
        private void bDelete_Click(object sender, EventArgs e)
        {
           
            listUrlImage = item.Images;
            item.Images.Remove(item.Images[currentIndex]);
            pbAddImage.Image = null;
            tbUrlImage.Clear();
            LoadImageAtIndex(currentIndex);

        }



        //SOLO FUNCIONA EN LA VENTANA EDIT - FALTA BOTON SAVE CAMBIOS Y CONSULTAS
        private void bEditImage_Click(object sender, EventArgs e)
        {
            item.Images[currentIndex].Url= tbUrlImage.Text;
            pbAddImage.Image = null;
            tbUrlImage.Clear();
            LoadImageAtIndex(currentIndex);
        }



        //////////////////////////////           Methods Validation               ///////////////////////////////////
    }



}
