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


        public List<UrlImage> imagesOfItems(int ID)
        {

            List<UrlImage> list = new List<UrlImage>();
            DataManager dataManager = new DataManager();
            try
            {
                
                dataManager.setQuery("Select ImagenUrl, Id, IdArticulo from IMAGENES where IdArticulo  =@ID ");
                dataManager.setParameter("@ID",ID);
                dataManager.executeRead();
                while (dataManager.Lector.Read())
                {
                    UrlImage url = new UrlImage();
                    url.Id = (int)dataManager.Lector["Id"];
                    url.Url = (string)dataManager.Lector["ImagenUrl"];
                    url.IdArticulo = (int)dataManager.Lector["IdArticulo"];
                    list.Add(url);

                }
                dataManager.closeConection();
                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





    }
}
