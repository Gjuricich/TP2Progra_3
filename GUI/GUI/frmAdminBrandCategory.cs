using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Managers;

namespace GUI
{
    public partial class frmAdminBrandCategory : Form

        

    {
        private List<Brand> brandsDeleted = null, listBrandAux = null, brandsAdded = null, brandsEdited = null;
        private List<Category> categoriesDeleted = null, listCategoriesAux = null, categoriesAdded = null, categoriesEdited = null;



        public frmAdminBrandCategory()
        {
            InitializeComponent();
            brandsDeleted = new List<Brand>();
            brandsAdded = new List<Brand>();
            brandsEdited = new List<Brand>();

            categoriesDeleted = new List<Category>();
            categoriesAdded = new List<Category>();
            categoriesEdited = new List<Category>();

        }

        private void frmAdminBrandCategory_Load(object sender, EventArgs e)
        {
            BrandManager bManager = new BrandManager();
            CategoryManager cManager = new CategoryManager();
            cbBrandCategory.Visible = false;
            lBrand.Visible = false;
            lCategory.Visible = false;
            lNewBrand.Visible = false;
            lNewCategory.Visible = false;
            tbNew.Visible = false;
            cbSelect.Items.Add("Brands");
            cbSelect.Items.Add("Categories");
            listCategoriesAux = cManager.listar();
            listBrandAux = bManager.listar();
 


        }


        private void loadCategory()
        {

            cbBrandCategory.DataSource = listCategoriesAux;
            cbBrandCategory.ValueMember = "Id";
            cbBrandCategory.DisplayMember = "Descripcion";


        }

        private void loadBrand()
        {

            cbBrandCategory.DataSource = listBrandAux;
            cbBrandCategory.ValueMember = "Id";
            cbBrandCategory.DisplayMember = "Descripcion";
        }

        private void bClose_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbSelect.Text == "Brands")
            {
                lBrand.Visible = true;
                cbBrandCategory.Visible = true;
                lNewBrand.Visible = true;
                tbNew.Visible = true;
                loadBrand();

            }
            else if(cbSelect.Text == "Categories")
            {
                lCategory.Visible = true;
                cbBrandCategory.Visible = true;
                lNewCategory.Visible = true;
                tbNew.Visible = true;
                loadCategory();
            }
        }




        private void bdelete_Click(object sender, EventArgs e)
        {
            if (cbSelect.Text == "Brands")
            {
                DialogResult result = MessageBox.Show("Do you want to delete this brand?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    brandsDeleted.Add((Brand)cbBrandCategory.SelectedItem);
                    listBrandAux.Remove((Brand)cbBrandCategory.SelectedItem);         
                    cbBrandCategory.DataSource = null;
                    loadBrand();
                   
                }
                else
                {
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to delete this Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    categoriesDeleted.Add((Category)cbBrandCategory.SelectedItem);
                    listCategoriesAux.Remove((Category)cbBrandCategory.SelectedItem);
                    cbBrandCategory.DataSource = null;          
                    loadCategory();

                }
                else
                {
                    return;
                }
            }
        }



        private void bEdit_Click(object sender, EventArgs e)
        {

            if (cbSelect.Text == "Brands")
            {

                DialogResult result = MessageBox.Show("Do you want to edit this Brand?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
              
                    listBrandAux[cbBrandCategory.SelectedIndex].Descripcion = tbNew.Text; 
                    brandsEdited.Add(listBrandAux[cbBrandCategory.SelectedIndex]);
                    tbNew.Clear();
                    cbBrandCategory.DataSource = null;
                    loadBrand();
                   

                }
                else
                {
                    return;
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to edit this Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    listCategoriesAux[cbBrandCategory.SelectedIndex].Descripcion = tbNew.Text;
                    categoriesEdited.Add(listCategoriesAux[cbBrandCategory.SelectedIndex]);
                    tbNew.Clear();
                    cbBrandCategory.DataSource = null;
                    loadCategory();

                }
                else
                {
                    return;
                }


            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {


            if (cbSelect.Text == "Brands")
            {

                DialogResult result = MessageBox.Show("Do you want to add this Brand?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Brand brand = new Brand();
                    brand.Descripcion = tbNew.Text;
                    brandsAdded.Add(brand);
                    listBrandAux.Add(brand);
                    tbNew.Clear();
                    cbBrandCategory.DataSource = null;
                    loadBrand();


                }
                else
                {
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to add this Brand?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Category category = new Category();
                    category.Descripcion = tbNew.Text;
                    categoriesAdded.Add(category);
                    listCategoriesAux.Add(category);
                    tbNew.Clear();
                    cbBrandCategory.DataSource = null;
                    loadCategory();
                }
                else
                {
                    return;
                }


            }



        }
    }
}
