using System;
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

            ItemManager iManager = new ItemManager();
            dgArticles.DataSource = iManager.Listacompleta();
        }
        private void loadGrid()
        {
            ItemManager iManager = new ItemManager();
            try
            {
                listArticle = iManager.Listacompleta();
                dgArticles.DataSource = listArticle;

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
            ItemManager iManager = new ItemManager();
            Item selected = (Item)dgArticles.CurrentRow.DataBoundItem;
            url = iManager.imagesOfItems(selected.ID());

            if (currentSelectedRow != null)
            {
                // La selección cambia de una fila a otra y cambio el currentIndex a cero para que comienze con la primer foto de la nueva selección.
                currentIndex = 0;
                LoadImageAtIndex(currentIndex);
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
                    pbImgArticles.Load(url[index]);
                }
            }
            catch (System.Net.WebException ex)
            {

                if (ex.ToString().Contains("404"))
                {
                    pbImgArticles.Load("https://www.antevenio.com/wp-content/uploads/2017/08/15-ejemplos-de-paginas-404-que-generan-engagement-1.jpg");
                    MessageBox.Show(ex.ToString());
                }
                else if (ex.ToString().Contains("403"))
                {
                    pbImgArticles.Load("https://i.insider.com/605a704f106eb50019d053e0?width=1200&format=jpeg");
                    MessageBox.Show(ex.ToString());
                }
                else
                {
                    pbImgArticles.Load("https://previews.123rf.com/images/yehorlisnyi/yehorlisnyi2104/yehorlisnyi210400016/167492439-sin-foto-o-icono-de-imagen-en-blanco-cargando-im%C3%A1genes-o-marca-de-imagen-faltante-imagen-no.jpg");
                    MessageBox.Show(ex.ToString() + " La Ruta : " + url[index] + " es inaccesible");
                }
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