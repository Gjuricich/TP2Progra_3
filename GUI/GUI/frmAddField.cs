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
    public partial class frmAddField : Form

    {
        private List<Brand> brandsDeleted = null, listBrandAux = null, brandsAdded = null, brandsEdited = null;
        private List<Category> categoriesDeleted = null, listCategoriesAux = null, categoriesAdded = null, categoriesEdited = null;



        public frmAddField()
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
            try
            {
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


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

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to save this changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    updateCategoriesChanges();
                    updateBrandChanges();
                    nullBrandValidationAndExecuts();
                    nullCategoryValidationAndExecuts();
                    MessageBox.Show("Successfully changed");
                    listCategoriesAux.Clear();
                    listBrandAux.Clear();
                    Close();
                }
                else
                {
                    listCategoriesAux.Clear();
                    listBrandAux.Clear();
                    Close();

                }
            }

            catch (Exception)
            {

                throw;

            }
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbSelect.Text == "Brands")
            {
                lBrand.Visible = true;
                cbBrandCategory.Visible = true;
                lNewBrand.Visible = true;
                lCategory.Visible = false;
                tbNew.Visible = true;
                lNewCategory.Text = "New / Edit  Brand";
                loadBrand();

            }
            else if (cbSelect.Text == "Categories")
            {
                lCategory.Visible = true;
                cbBrandCategory.Visible = true;
                lNewCategory.Visible = true;
                tbNew.Visible = true;
                lBrand.Visible = false;
                lNewCategory.Text = "New / Edit  Category";
                loadCategory();

            }
        }




        private void bdelete_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(cbSelect.Text))
            {
                MessageBox.Show("You must select a brand/category.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {   
                if (cbSelect.Text == "Brands")
                {
                  
                    Brand selectedBrand = (Brand)cbBrandCategory.SelectedItem;

                    if (isUsed("brand",selectedBrand.Id))
                    {
                        MessageBox.Show("This brand is currently in use by an item. If you wish to delete it, you must remove those items that contain it.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
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
                }
                else
                {
                    Category selectedCategory = (Category)cbBrandCategory.SelectedItem;


                    if (isUsed("category", selectedCategory.Id))
                    {
                        MessageBox.Show("This category is currently in use by an item. If you wish to delete it, you must remove those items that contain it.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
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
            }
        }



        private void bEdit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbNew.Text))
            {
                MessageBox.Show("You must select a brand/category and the edit/New field cannot be empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
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
        }

        private void bAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbNew.Text))
            {              
                MessageBox.Show("You must select a brand/category and the edit/New field cannot be empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
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
    


        private void updateBrandChanges()
        {

            for (int i = 0; i < brandsDeleted.Count; i++)
            {
                for (int j = 0; j < brandsEdited.Count; j++)
                {
                    if (brandsDeleted[i].Id == brandsEdited[j].Id)
                    {
                        brandsEdited.RemoveAt(j);
                        j--;
                    }
                }

                for (int k = 0; k < brandsAdded.Count; k++)
                {
                    if (brandsDeleted[i].Descripcion== brandsAdded[k].Descripcion)  
                    {
                        brandsAdded.RemoveAt(k);
                        k--;
                    }
                }
            }

            for (int m = 0; m < brandsDeleted.Count; m++)
            {
                if (brandsDeleted[m].Id == 0)
                {
                    brandsDeleted.RemoveAt(m);
                    m--;
                }
            }

        }


        private void updateCategoriesChanges()
        {

            for (int i = 0; i < categoriesDeleted.Count; i++)
            {
                for (int j = 0; j < categoriesEdited.Count; j++)
                {
                    if (categoriesDeleted[i].Id == categoriesEdited[j].Id)
                    {
                        categoriesEdited.RemoveAt(j);
                        j--;
                    }
                }

                for (int k = 0; k < categoriesAdded.Count; k++)
                {
                    if (categoriesDeleted[i].Descripcion == categoriesAdded[k].Descripcion)
                    {
                        categoriesAdded.RemoveAt(k);
                        k--;
                    }
                }
            }

            for (int m = 0; m < categoriesDeleted.Count; m++)
            {
                if (categoriesDeleted[m].Id == 0)
                {
                    categoriesDeleted.RemoveAt(m);
                    m--;
                }
            }

        }

        private void nullBrandValidationAndExecuts()
        {
            BrandManager bManager = new BrandManager();
          
            if (brandsDeleted != null && brandsDeleted.Count() > 0)
            {
                foreach (Brand element in brandsDeleted)
                {
                    bManager.deleteBrand(element.Id);
                }

            }

            if (brandsEdited!= null && brandsEdited.Count() > 0)
            {
                bManager.updateBrand(brandsEdited);

            }

            if (brandsAdded != null && brandsAdded.Count() > 0)
            {
                bManager.addBrand(brandsAdded);

            }
        }

        private void nullCategoryValidationAndExecuts()
        {
           
            CategoryManager cManager = new CategoryManager();

            if (categoriesDeleted != null && categoriesDeleted.Count() > 0)
            {
                foreach (Category element in categoriesDeleted)
                {
                    cManager.deleteCategory(element.Id);
                }
               
            }

            

            if (categoriesEdited != null && categoriesEdited.Count() > 0)
            {
                cManager.updateCategory(categoriesEdited);

            }

            if (categoriesAdded != null && categoriesAdded.Count() > 0)
            {
                cManager.addCategory(categoriesAdded);
                

            }
        }

        private bool isUsed(string type,int id) 
        {
            ItemManager iManager = new ItemManager();
            List<Item> itemList = new List<Item>();

            try
            {
                itemList = iManager.Listacompleta();

                if (type == "brand")
                {
                    for (int i = 0; i < itemList.Count; i++)
                    {
                        if (itemList[i].Brand.Id == id)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else
                {
                    for (int j = 0; j < itemList.Count; j++)
                    {
                        if (itemList[j].Category.Id == id)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;
            }

         





        }

  


    }
}
