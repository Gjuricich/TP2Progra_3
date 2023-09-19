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
    
       
        private Item item = null;
        private int currentIndex = 0;
        private int currentImage = 1;
        private List<UrlImage> listUrlImage = null;
        private List<UrlImage> listImageDeleted = null; 
        private List<UrlImage> listImageEdited = null;
        private List<UrlImage> listImageNewAdded = null;
        

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
            listImageDeleted = new List<UrlImage>();
            listImageEdited = new List<UrlImage>();
            listImageNewAdded =  new List<UrlImage>();

            this.item = item;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
           
            UrlImageManager aux = new UrlImageManager();

            try
            {        
                LoadComboBox();

                if(item == null)
                {
                    LoadAdd();
                }
                else 
                {
                    LoadEdit();

                    tbCodeArt.Text = item.ItemCode;
                    tbName.Text = item.Name;
                    rtbDescription.Text = item.Description;
                    tbPrice.Text = item.Price.ToString();
                    cbBrand.SelectedValue = item.Brand.Id;
                    cbCategory.SelectedValue = item.Category.Id;
                    item.Images = aux.imagesOfItems(item.Id);
                    if (item.Images.Count() > 0)
                    {
                        imageCount.Text = currentImage.ToString() + "/" + item.Images.Count().ToString();
                    }
                    else
                    {
                        imageCount.Text = 0 + "/" + 0;
                    }
                    if (item.Images != null && item.Images.Count > 0)
                    {      
                        LoadImageAtIndex(currentIndex);
                    }
                   
                }
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadComboBox()
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

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void LoadAdd()
        {
            imageCount.Visible = false;
            pbfoward.Visible = false;
            pbBackward.Visible = false;
            pbAddImage.BorderStyle = BorderStyle.Fixed3D;
            bDelete.Visible = false;
            bAddImage.Visible = false;
            bEditImage.Visible = false;
            bClear.Visible = true;

        }


        private void LoadEdit()
        {
            pbfoward.Visible = true;
            pbBackward.Visible = true;
            bDelete.Visible = true;
            bAddImage.Visible = true;
            bEditImage.Visible = true;
            bSaveImage.Visible = false;
            bClear.Visible = false;
            imageCount.Visible = true;
            bLoadImage.Visible = false;
            pbAddImage.BorderStyle = BorderStyle.None;

        }
        //////////////////////////////           NAVIGATION               ///////////////////////////////////

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
                currentImage--;
                currentIndex--;
                LoadImageAtIndex(currentIndex);
                imageCount.Text = currentImage.ToString() + "/" + item.Images.Count().ToString();

            }
        }

        private void pbfoward_Click_1(object sender, EventArgs e)
        {
            if (currentIndex < item.Images.Count - 1)
            {
                currentImage++;
                currentIndex++;
                LoadImageAtIndex(currentIndex);
                imageCount.Text = currentImage.ToString() + "/" + item.Images.Count().ToString();

              
            }
        }



        //////////////////////////////           Bottons Events            ///////////////////////////////////

        private void bClear_Click(object sender, EventArgs e)
        {
            pbAddImage.Image = null;
            tbUrlImage.Clear();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
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
                    MessageBox.Show("Please, add a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            while (true);

            pbAddImage.Load(tbUrlImage.Text);
        }


   
        private void bSaveImage_Click(object sender, EventArgs e)
        {
            UrlImage aux = new UrlImage();
            aux.Url = tbUrlImage.Text;
            do
            {
                if (IsValidUrl(aux.Url))
                {
                    listUrlImage.Add(aux);
                    break;
                }
                else
                {
                    MessageBox.Show("Please, add a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            while (true);
            pbAddImage.Image = null;
            tbUrlImage.Clear();
          
        }

        private bool itemCodeValidation(List<Item> aux,ItemManager iManager)
        {
            bool isNew = true;
            for (int i = 0; i < aux.Count(); i++)
            {
                if (aux[i].ItemCode == tbCodeArt.Text || aux[i].ItemCode == tbCodeArt.Text.ToUpper())
                {
                    MessageBox.Show("There is already an item with this code.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isNew = false;
                    
                }

            }
            return isNew;

        }

        private void bSave_Click(object sender, EventArgs e)
        {
           
            ItemManager iManager = new ItemManager();
            List<Item> aux = new List<Item>();
            aux = iManager.Listacompleta();
            try
            {
             
                if (item == null)
                {
                    item = new Item();
                    if(string.IsNullOrWhiteSpace(tbCodeArt.Text))
                    {
                        MessageBox.Show("The code field is mandatory.");
                        item = null;
                        return;
                    }
                    
                    if (itemCodeValidation(aux,iManager))
                         {
                          item.ItemCode = tbCodeArt.Text;
                         }
                    else
                    {
                        item = null;
                        return;
                    }
                    if (listUrlImage != null && listUrlImage.Count() > 0)
                    {
                        item.Images = listUrlImage;
                    }

                }


                if (string.IsNullOrWhiteSpace(tbCodeArt.Text))
                {
                    MessageBox.Show("The code field is mandatory.");
                    return;
                }

                item.Name = tbName.Text;
                if(string.IsNullOrWhiteSpace(tbName.Text))
                {
                    MessageBox.Show("The name is mandatory.");
                    return;
                }
                
                item.Description = rtbDescription.Text;
                if (string.IsNullOrWhiteSpace(tbPrice.Text))
                {
                    item.Price = 000;

                }
                else if (decimal.TryParse(tbPrice.Text, out decimal price))
                {
                    item.Price = price;
                }
                else
                {
                    MessageBox.Show("The price value is not valid.");
                    return;
                }

                item.Brand = (Brand)cbBrand.SelectedItem;
                if (string.IsNullOrEmpty(cbBrand.Text))
                {
                    MessageBox.Show("Add a brand before saving.");
                    return;
                }
                item.Category = (Category)cbCategory.SelectedItem;
                if(string.IsNullOrEmpty(cbCategory.Text)) 
                {
                    MessageBox.Show("Add a category before saving.");
                    return;
                }


                DialogResult result = MessageBox.Show("Do you want to save this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    if (item.Id != 0)
                    {
                        updateChanges();
                        nullImageValidationAndExecuts();
                        iManager.edit(item);
                        MessageBox.Show("Successfully edited");
                    }
                    else
                    {
                        iManager.add(item);
                        MessageBox.Show("Successfully added.");
                    }
                    Close();
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


            private void bAddImage_Click_1(object sender, EventArgs e)
          {
            
            if (string.IsNullOrEmpty(tbUrlImage.Text))
            {
                MessageBox.Show("URL field is mandatory.");
                return;
            }

            DialogResult result = MessageBox.Show("Do you add the image?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                UrlImage aux = new UrlImage();
                aux.Url = tbUrlImage.Text;
                aux.IdArticulo = item.Id;
                item.Images.Add(aux);
                listImageNewAdded.Add(aux);
                pbAddImage.Image = null;
                tbUrlImage.Clear();
                LoadImageAtIndex(item.Images.Count() - 1);
            }

        }


    
        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the image?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                try
                {
                    if (item.Images.Count() > 0)
                    {
                        listImageDeleted.Add(item.Images[currentIndex]);//si la id =0 nunca se guardó en la base
                        item.Images.Remove(item.Images[currentIndex]);
                        pbAddImage.Image = null;
                        tbUrlImage.Clear();
                        LoadImageAtIndex(currentIndex);
                        imageCount.Text = currentIndex + "/" + item.Images.Count().ToString();
                    }
                    else
                    {
                        DialogResult resulted = MessageBox.Show("This article does not have any images", "Attention", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }

                }
                catch (Exception)
                {

                    throw;
                }
               
            }

        }
   
        private void bEditImage_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUrlImage.Text))
            {
                MessageBox.Show("URL field is mandatory");
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to edit the image?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                item.Images[currentIndex].Url= tbUrlImage.Text;
                listImageEdited.Add(item.Images[currentIndex]);
                pbAddImage.Image = null;
                tbUrlImage.Clear();
                LoadImageAtIndex(currentIndex);
            }
        }


        //////////////////////////////         Validation  Methods  and  More           ///////////////////////////////////

        private bool IsValidUrl(string url)
        {
            Uri result;
            return Uri.TryCreate(url, UriKind.Absolute, out result) &&
                   (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
        }

        private void updateChanges()
        {

            for (int i = 0; i < listImageDeleted.Count; i++)
            {
                for (int j = 0; j < listImageEdited.Count; j++)
                {
                    if (listImageDeleted[i].Id == listImageEdited[j].Id)
                    {
                        listImageEdited.RemoveAt(j);
                        j--;
                    }
                }

                for (int k = 0; k < listImageNewAdded.Count; k++)
                {
                    if (listImageDeleted[i].Url == listImageNewAdded[k].Url)
                    {
                        listImageNewAdded.RemoveAt(k);
                        k--;
                    }
                }
            }

            for (int m = 0; m < listImageDeleted.Count; m++)
            {
                if (listImageDeleted[m].Id == 0)
                {
                    listImageDeleted.RemoveAt(m);
                    m--;
                }
            }
        }

        private void nullImageValidationAndExecuts()
        {
            ItemManager iManager = new ItemManager();
            UrlImageManager uManager = new UrlImageManager();
            try
            {
                
                    if (listImageDeleted != null && listImageDeleted.Count() > 0)
                    {
                        foreach (UrlImage element in listImageDeleted)
                        {
                            uManager.deleteImage(element.IdArticulo);
                        }

                    }

                    if (listImageEdited != null && listImageEdited.Count() > 0)
                    {
                        uManager.updateImage(listImageEdited);

                    }

                    if (listImageNewAdded != null && listImageNewAdded.Count() > 0)
                    {
                        uManager.addImage(listImageNewAdded);

                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

            
        
    }



}
