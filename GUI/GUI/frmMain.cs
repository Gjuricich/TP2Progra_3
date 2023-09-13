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
using Domain;
using Managers;

namespace GUI
{
    public partial class frmMain : Form
    {
        private List<Item> listArticle;
        private int currentIndex = 0;
        private List<string> url;
        public frmMain()
        {
            InitializeComponent();


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
            frmAdd windowAdd = new frmAdd();
            windowAdd.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            frmEdit windowEdit = new frmEdit();
            windowEdit.ShowDialog();

        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ItemManager iManager = new ItemManager();
            dgArticles.DataSource = iManager.FiltbyName(tbSearch.Text);
            if (dgArticles.CurrentRow == null)
            {
                pbImgArticles.Load("https://previews.123rf.com/images/yehorlisnyi/yehorlisnyi2104/yehorlisnyi210400016/167492439-sin-foto-o-icono-de-imagen-en-blanco-cargando-im%C3%A1genes-o-marca-de-imagen-faltante-imagen-no.jpg");

            }

        }
        private void frmMain_Load_1(object sender, EventArgs e)
        {

            loadGrid();
            cbxBrand.DataSource=loadBrands();
            cbxCategory.DataSource=loadCategorys();
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
        List<string> loadBrands()
        {
            BrandManager brandManager = new BrandManager();
            List<Brand>brands = new List<Brand>();
            List<string>brandName = new List<string>();
           
            try
            {
                brands = brandManager.listar();

                foreach (Brand elemento in brands)
                {
                    brandName.Add(elemento.Descripcion);
                }
                return brandName;
            }
            catch (Exception)
            {

                throw;
            }
        }
        List<string> loadCategorys()
        {
            CategoryManager cManager = new CategoryManager();
            List<Category> categorys = new List<Category>();
            List<string>categoryName = new List<string>();
            try
            {
                categorys = cManager.listar();  
                foreach(Category elemento in categorys)
                {
                    categoryName.Add(elemento.Descripcion);
                }
                return categoryName;    
            }
            catch (Exception)
            {

                throw;
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
            ItemManager iManager = new ItemManager();
            try
            {
                if (currentSelectedRow != null)
                {
                    Item selected = (Item)dgArticles.CurrentRow.DataBoundItem;
                    url = iManager.imagesOfItems(selected.ID());
                    // La selección cambia de una fila a otra y cambio el currentIndex a cero para que comienze con la primer foto de la nueva selección.
                    currentIndex = 0;
                    if (selected.Description != "")
                        rtbDescription.Text = selected.Description;
                    LoadImageAtIndex(currentIndex);
                }
            }
            catch (NullReferenceException ex )
            {
                throw ex;
                 
            }

            
        }
        //divido la parte que se encarga de cargar la imagen segun un indice.
        private void LoadImageAtIndex(int index)
        {
            try
            {
                if (url.Count() != 0 && index >= 0 && index < url.Count())
                {
                    // Carga la URL en función del índice actual
                    
                    if (url[currentIndex] != "")
                        pbImgArticles.Load(url[index]);

                }
            }
            catch (System.Net.WebException)
            {

                    pbImgArticles.Load("https://lh3.googleusercontent.com/drive-viewer/AITFw-wS6RAUNTNl47sUUVoPu5qMvbp08NQ48aWAXQUFn-TsDK8497WjmJavnGyi0sS0Uvknmg17fx6wTY7MQYhYDIIRn551=w1366-h618");
                    //MessageBox.Show(ex.ToString() + " La Ruta : " + url[index] + " es inaccesible");
                
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                LoadImageAtIndex(currentIndex);
            }
        }
        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (currentIndex < url.Count - 1)
            {
                currentIndex++;
                LoadImageAtIndex(currentIndex);
            }

        }


    }

}