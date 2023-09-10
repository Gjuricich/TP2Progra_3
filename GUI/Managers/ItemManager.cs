using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Managers
{

    public class ItemManager
    {
       
       
        public List<Item> uploadArticlesList(string query)
        {
            List<Item> articles = new List<Item>();
            try
            {
                DataManager dataManager = new DataManager();

                dataManager.setQuery(query);
                dataManager.executeRead();
                while (dataManager.Lector.Read())
                {
                    Item article = new Item();

                    article.Name = (string)dataManager.Lector["Nombre"];
                    article.Description = (string)dataManager.Lector["Descripcion"];
                    article.ArtCode = (string)dataManager.Lector["Codigo"];
                    article.Marc = (string)dataManager.Lector["Marca"];
                    if (dataManager.Lector.IsDBNull(dataManager.Lector.GetOrdinal("Categoria")))
                    {
                        article.Category = "Sin Categoria";
                    }
                    else
                    {
                        article.Category = (string)dataManager.Lector["Categoria"];
                    }



                    article.Price = (decimal)dataManager.Lector["Precio"];
                    articles.Add(article);
                }

                return articles;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public List<Item> FiltrarPornombredeColumna(string palabra)
        {
            return uploadArticlesList("select A.Codigo As Codigo,A.Nombre As Nombre ,A.Descripcion As Descripcion ,M.Descripcion Marca,C.Descripcion As Categoria ,A.Precio  As Precio FROM  ARTICULOS A left JOIN  MARCAS M on M.Id= A.IdMarca left JOIN CATEGORIAS C on C.Id= A.IdCategoria  WHERE A.Nombre LIKE '%" + palabra + "%'");
        }
        public List<Item> Listacompleta()
        {
            return uploadArticlesList("select A.Codigo As Codigo,A.Nombre As Nombre ,A.Descripcion As Descripcion ,M.Descripcion Marca,C.Descripcion As Categoria ,A.Precio  As Precio FROM  ARTICULOS A left JOIN  MARCAS M on M.Id= A.IdMarca left JOIN CATEGORIAS C on C.Id= A.IdCategoria");
        }


        public void add(Item add)
        {
            DataManager dataManager = new DataManager();

            try
            {
                dataManager.setQuery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion,Precio) values('" + add.ArtCode + "', '" + add.Name + "' , '" + add.Description + "', " + add.Price + ")");
                dataManager.executeRead();
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

        public void delete(string Codigo)
        {
            try
            {
                DataManager data = new DataManager();
                data.setQuery("delete from ARTICULOS where Codigo = @Codigo");
                data.setParameter("@Codigo", Codigo);
                data.executeRead();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}