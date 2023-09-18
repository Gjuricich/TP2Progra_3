using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Domain;
using Managers;

namespace GUI
{
    public partial class frmMain : Form
    {
        private List<Item> listArticle;
        private int currentIndex = 0;
        private List<UrlImage> currentUrls;
        private int currentImage = 1;
        public frmMain()
        {
            InitializeComponent();
            loadGrid();

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
            bAddField.Visible = show;
            tituleUser.Text = "Maxi Programa";
        }
        private void bAddField_Click(object sender, EventArgs e)
        {
            frmAddField windowField = new frmAddField();
            windowField.ShowDialog();
            loadGrid();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit windowAdd = new frmAddEdit();
            windowAdd.ShowDialog();
            loadGrid();
        }

        private bool rowSelectedValidationOk()
        {
            
            if (dgArticles.CurrentRow ==null)
            {
                MessageBox.Show("Please select an item", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {  
                return true;
            }
         
        }


        private void bEdit_Click(object sender, EventArgs e)
        {
            ItemManager iManager = new ItemManager();
            Item selected;

            try
            {
                if (rowSelectedValidationOk())
                {
                    selected = (Item)dgArticles.CurrentRow.DataBoundItem;
                    frmAddEdit windowEdit = new frmAddEdit(selected);
                    windowEdit.ShowDialog();
                    loadGrid();
                }
                else
                {
                    return;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("You must select an item to modify");
            }


        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ItemManager iManager = new ItemManager();
           // dgArticles.DataSource = iManager.FiltbyName(tbSearch.Text);
            if (dgArticles.CurrentRow == null)
            {
                pbImgArticles.Load("https://previews.123rf.com/images/yehorlisnyi/yehorlisnyi2104/yehorlisnyi210400016/167492439-sin-foto-o-icono-de-imagen-en-blanco-cargando-im%C3%A1genes-o-marca-de-imagen-faltante-imagen-no.jpg");

            }

        }
        private void frmMain_Load_1(object sender, EventArgs e)
        {

            
            cbxField.Items.Add("Codigo");
            cbxField.Items.Add("Nombre");
            cbxField.Items.Add("Precio");
            cbxField.Items.Add("Descripción");
            btnSerch_Click(sender, e);
        }
        private void loadGrid()
        {
            ItemManager iManager = new ItemManager();
            try
            {
                listArticle = iManager.Listacompleta();
                dgArticles.DataSource = listArticle;
                dgArticles.Columns["Id"].Visible = false;
                dgArticles.Columns["Description"].Visible = false;
   

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    
        private void bDelete_Click(object sender, EventArgs e)
        {
            ItemManager iManager = new ItemManager();
            Item selected;
            try
            {
                if (rowSelectedValidationOk())
                {
                    DialogResult answer = MessageBox.Show("The selected article will be deleted. Please confirm if you want to delete it.", "Removing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (answer == DialogResult.Yes)
                    {
                        selected = (Item)dgArticles.CurrentRow.DataBoundItem;
                        iManager.delete(selected.ItemCode);
                        loadGrid();
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void dgArticles_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentSelectedRow = dgArticles.CurrentRow;
            UrlImageManager uManager = new UrlImageManager();
            try
            {
                if (currentSelectedRow != null)
                {
                    Item selected = (Item)dgArticles.CurrentRow.DataBoundItem;
                    currentUrls = uManager.imagesOfItems(selected.ID());
                    // La selección cambia de una fila a otra y cambio el currentIndex a cero para que comienze con la primer foto de la nueva selección.
                    currentIndex = 0;
                    if (selected.Description != "")
                        rtbDescription.Text = selected.Description;
                    else
                        rtbDescription.Text = "";
                    LoadImageAtIndex(currentIndex);
                    
                    if (currentUrls.Count() > 0)
                    {
                        currentImage = 1;
                        ImagesCount.Text = currentImage.ToString() + "/" + currentUrls.Count().ToString();
                    }
                    else
                    {
                        ImagesCount.Text = 0 + "/" + 0;
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                throw ex;

            }


        }
        //divido la parte que se encarga de cargar la imagen segun un indice.
        private void LoadImageAtIndex(int index)
        {
            try
            {
                if (currentUrls.Count() != 0 && index >= 0 && index < currentUrls.Count())
                {
                    // Carga la URL en función del índice actual

                    if (currentUrls[currentIndex].Url != "")
                        pbImgArticles.Load(currentUrls[index].Url);
                    
                     

                }
                else
                    pbImgArticles.Image = null;
            }
            catch (System.Net.WebException)
            {

                pbImgArticles.Load("https://lh3.googleusercontent.com/drive-viewer/AITFw-wS6RAUNTNl47sUUVoPu5qMvbp08NQ48aWAXQUFn-TsDK8497WjmJavnGyi0sS0Uvknmg17fx6wTY7MQYhYDIIRn551=w1366-h618");
                //MessageBox.Show(ex.ToString() + " La Ruta : " + url[index] + " es inaccesible");

            }
        }

        private void pbBackward_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentImage--;
                currentIndex--;
                LoadImageAtIndex(currentIndex);
                ImagesCount.Text = currentImage.ToString() + "/" + currentUrls.Count().ToString();

            }

        }

        private void pbfoward_Click(object sender, EventArgs e)
        {
            if (currentIndex < currentUrls.Count - 1)
            {
                currentImage++;
                currentIndex++;
                LoadImageAtIndex(currentIndex);
                ImagesCount.Text = currentImage.ToString() + "/" + currentUrls.Count().ToString();
            }
        }




        private bool onlyNumbers(string aux)
        {
            foreach (char caracter in aux)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private bool numberValidation()
        {
            if (cbxField.SelectedItem.ToString() == "Precio")
            {            
                if (!(onlyNumbers(txbSerch.Text)))
                {
        
                    MessageBox.Show("Only numbers for filtering by a numeric field.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

            }
            return false;
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            ItemManager itemManager = new ItemManager();
            try
            {

                if (cbxField.SelectedIndex < 0 && cbxCriterion.SelectedIndex < 0 && txbSerch.Text.Count() > 0)
                {
                    MessageBox.Show("Please select both field and criterion to search", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbxCriterion.SelectedIndex < 0 && txbSerch.Text.Count() > 0)
                {
                    MessageBox.Show("Please select a criterion to search", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgArticles.DataSource = itemManager.Listacompleta();
                }
                else if (txbSerch.Text == "")
                {
                    dgArticles.DataSource = itemManager.Listacompleta();
                }
                else if (numberValidation())
                {
                    return;
                }
                else
                {
                    string field = cbxField.SelectedItem.ToString();
                    string criterion = cbxCriterion.SelectedItem.ToString();
                    string filter = txbSerch.Text;
                    listArticle = itemManager.filtedBy(field, criterion, filter);
                    dgArticles.DataSource = listArticle;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string opcion = cbxField.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                
                cbxCriterion.Items.Clear();
                cbxCriterion.Text = "";
                cbxCriterion.Items.Add("Greater than");
                cbxCriterion.Items.Add("Less than");
                cbxCriterion.Items.Add("Equal to");
            }

            else
            {
                cbxCriterion.Items.Clear();
                cbxCriterion.Text = "";
                cbxCriterion.Items.Add("Starts with");
                cbxCriterion.Items.Add("Ends with");
                cbxCriterion.Items.Add("Contains");
            }

        }

      
    }
}