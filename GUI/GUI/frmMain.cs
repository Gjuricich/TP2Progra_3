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
            tituleUser.Text = "Maxi Programa";
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit windowAdd = new frmAddEdit();
            windowAdd.ShowDialog();
            loadGrid();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            ItemManager iManager = new ItemManager();
            Item selected;

            try
            {
                selected = (Item)dgArticles.CurrentRow.DataBoundItem;
                frmAddEdit windowEdit = new frmAddEdit(selected);
                windowEdit.ShowDialog();
                loadGrid();
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
                DialogResult answer = MessageBox.Show("The selected article will be deleted. Please confirm if you want to delete it.", "Removing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    selected = (Item)dgArticles.CurrentRow.DataBoundItem;
                    iManager.delete(selected.ItemCode);
                    loadGrid();
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
                    LoadImageAtIndex(currentIndex);
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
                currentIndex--;
                LoadImageAtIndex(currentIndex);
            }

        }

        private void pbfoward_Click(object sender, EventArgs e)
        {
            if (currentIndex < currentUrls.Count - 1)
            {
                currentIndex++;
                LoadImageAtIndex(currentIndex);
            }
        }




        private void btnSerch_Click(object sender, EventArgs e)
        {
            ItemManager itemManager = new ItemManager();
            try
            {
                if (cbxField.SelectedIndex.ToString() != "")
                {
                    if (cbxCriterion.SelectedIndex.ToString() != "")
                    {
                        if (txbSerch.Text != "")
                        {

                            string field = cbxField.SelectedItem.ToString();
                            string criterion = cbxCriterion.SelectedItem.ToString();
                            string filter = txbSerch.Text;
                            listArticle = itemManager.filtedBy(field, criterion, filter);
                            dgArticles.DataSource = listArticle;
                        }
                        else
                        {
                            dgArticles.DataSource = itemManager.Listacompleta();

                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string opcion = cbxField.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                
                cbxCriterion.Items.Clear();
                cbxCriterion.Text = "";
                cbxCriterion.Items.Add("Mayor a");
                cbxCriterion.Items.Add("Menor a");
                cbxCriterion.Items.Add("Igual a");
            }

            else
            {
                cbxCriterion.Items.Clear();
                cbxCriterion.Text = "";
                cbxCriterion.Items.Add("Comienza con");
                cbxCriterion.Items.Add("Termina con");
                cbxCriterion.Items.Add("Contiene");
            }

        }

      
    }
}