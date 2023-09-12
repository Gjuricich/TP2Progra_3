using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Managers
{
    public class CategoryManager
    {
        public List<Category> listar()
        {
            List<Category> list = new List<Category>();
            DataManager dataManager = new DataManager();

            try
            {

                dataManager.setQuery("SELECT Id, Descripcion FROM CATEGORIAS");
                dataManager.executeRead();
                while (dataManager.Lector.Read())
                {
                    Category category= new Category();
                    category.Id = (int)dataManager.Lector["Id"];
                    category.Descripcion = (string)dataManager.Lector["Descripcion"];

                    list.Add(category);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                dataManager.closeConection();
            }
        }
    }
}
