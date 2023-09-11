using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Managers
{
    public class UrlImageManager
    {

        public List<UrlImage> list()
        {
            List<UrlImage> list = new List<UrlImage>();
            DataManager dataManager = new DataManager();
            

            try
            {

                dataManager.setQuery(" select ImagenUrl from IMAGENES where IdArticulo ");
                dataManager.executeRead();
                while (dataManager.Lector.Read())
                {
                    UrlImage url = new UrlImage();
                    url.Id = (int)dataManager.Lector["Id"];
                    url.Url = (string)dataManager.Lector["ImagenUrl"];
                    list.Add(url);
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
