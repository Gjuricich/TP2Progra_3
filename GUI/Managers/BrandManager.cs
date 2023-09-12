using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Managers
{
    public class BrandManager
    {
       
        public List<Brand> listar()
        {
            List<Brand> list = new List<Brand>();
            DataManager dataManager = new DataManager();

            try
            {

                dataManager.setQuery("SELECT Id, Descripcion FROM MARCAS");
                dataManager.executeRead();
                while (dataManager.Lector.Read())
                {
                    Brand brand = new Brand();
                    brand.Id = (int)dataManager.Lector["Id"];
                    brand.Descripcion = (string)dataManager.Lector["Descripcion"];

                    list.Add(brand);
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
