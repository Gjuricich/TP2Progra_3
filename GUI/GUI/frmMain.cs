﻿using System;
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
       

        private List<Item> listItem;
        private int currentIndex = 0;
        List<string> url;
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


        private void bFilter_Click(object sender, EventArgs e)
        {
            ItemManager iManager = new ItemManager();
            dgArticles.DataSource = iManager.FiltbyName(tbSearch.Text);
          
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ItemManager iManager = new ItemManager();
            dgArticles.DataSource = iManager.FiltbyName(tbSearch.Text);
           
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid()
        {
            ItemManager iManager = new ItemManager();
            try

            {
                listItem = iManager.Listacompleta();
                dgArticles.DataSource = listItem;
                dgArticles.Columns["Id"].Visible = false;
                dgArticles.Columns["Description"].Visible = false;
               // rtbDescription.Text = listItem.Description;


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
            
            ItemManager iManager = new ItemManager();
            Item selected = (Item)dgArticles.CurrentRow.DataBoundItem;
            url = iManager.imagesOfItems(selected.ID());

            try
            {
                if (url.Count() != 0 && currentIndex < url.Count())
                {
                    // Carga la URL en función del índice actual
                    if (selected.Description != "")
                        rtbDescription.Text = selected.Description; 
                    if(url[currentIndex] != "")
                        pbImgArticles.Load(url[currentIndex]);

                }
            }
            catch (System.Net.WebException ex)
            {
                pbImgArticles.Load("https://lh3.googleusercontent.com/drive-viewer/AITFw-wS6RAUNTNl47sUUVoPu5qMvbp08NQ48aWAXQUFn-TsDK8497WjmJavnGyi0sS0Uvknmg17fx6wTY7MQYhYDIIRn551=w1366-h618");
                //MessageBox.Show("La Ruta : " + url[currentIndex] + " es inaccesible");
                //"https://w7.pngwing.com/pngs/22/842/png-transparent-picture-frame-blue-border-empty-blank-isolated-thumbnail.png"
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                // Vuelve a cargar la URL retrocedida
                dgArticles_SelectionChanged(sender, e);
            }
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (currentIndex < url.Count - 1)
            {
                currentIndex++;
                // Vuelve a cargar la URL avanzada
                dgArticles_SelectionChanged(sender, e);
            }

        }
    }

}