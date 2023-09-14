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
                    article.Id = (int)dataManager.Lector["Id"];
                    article.Name = (string)dataManager.Lector["Nombre"];
                    article.Description = (string)dataManager.Lector["Descripcion"];
                    article.ItemCode = (string)dataManager.Lector["Codigo"];
                    article.Brand.Descripcion = (string)dataManager.Lector["Marca"];
                    article.Brand.Id = (int)dataManager.Lector["Id"];
                    if (dataManager.Lector.IsDBNull(dataManager.Lector.GetOrdinal("Categoria")))
                    {
                        article.Category.Descripcion = " ";
                    }
                    else
                    {
                        article.Category.Descripcion = (string)dataManager.Lector["Categoria"];
                        article.Category.Id = (int)dataManager.Lector["Id"];
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
        public List<Item> FiltbyName(string palabra)
        {
            return uploadArticlesList("select A.Id As Id,A.Codigo As Codigo,A.Nombre As Nombre ,A.Descripcion As Descripcion ,M.Descripcion Marca, M.Id Marca,C.Descripcion As Categoria, C.Id Categoria ,A.Precio  As Precio FROM  ARTICULOS A left JOIN  MARCAS M on M.Id= A.IdMarca left JOIN CATEGORIAS C on C.Id= A.IdCategoria  WHERE A.Nombre LIKE '%" + palabra + "%'");
       }
        public List<Item> Listacompleta()
        {
            return uploadArticlesList("select A.Id As Id, A.Codigo As Codigo,A.Nombre As Nombre ,A.Descripcion As Descripcion ,M.Descripcion Marca,C.Descripcion As Categoria ,A.Precio  As Precio FROM  ARTICULOS A left JOIN  MARCAS M on M.Id= A.IdMarca left JOIN CATEGORIAS C on C.Id= A.IdCategoria");
        }


        public void add(Item add)
        {
            DataManager dataManager = new DataManager();
           

            try
            {
                dataManager.setQuery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion,Precio, IdMarca, IdCategoria) values(@codigo, @nombre, @descripcion, @precio, @idMarca, @idCategoria)");
                dataManager.setParameter("@codigo", add.ItemCode);
                dataManager.setParameter("@nombre", add.Name);
                dataManager.setParameter("@descripcion", add.Description);
                dataManager.setParameter("@precio", add.Price);
                dataManager.setParameter("@idMarca", add.Brand.Id);
                dataManager.setParameter("@idCategoria", add.Category.Id);
                dataManager.executeRead();
                dataManager.closeConection();

                dataManager = new DataManager();
                dataManager.setQuery("SELECT Id FROM ARTICULOS WHERE Codigo = @Codigo");
                dataManager.setParameter("@Codigo", add.ItemCode);
                dataManager.executeRead();
                dataManager.Lector.Read();

                    for (int i = 0; i < add.Images.Count(); i++)
                    {
                        add.Images[i].IdArticulo = (int)dataManager.Lector["Id"];
                    }

                dataManager.closeConection();

               
                for (int i = 0; i < add.Images.Count(); i++)
                {
                    dataManager = new DataManager();
                    dataManager.setQuery("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) values (@IdArt,@Url)");
                    dataManager.setParameter("@IdArt", add.Images[i].IdArticulo);
                    dataManager.setParameter("@Url", add.Images[i].Url);
                    dataManager.executeRead();
                    dataManager.closeConection();
                }

                
               


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

        public List<string> imagesOfItems(int ID_Item)
        {

            List<string> ArticleImages = new List<string>();
            try
            {
                DataManager dataManager = new DataManager();
                dataManager.setQuery(" select ImagenUrl from IMAGENES where IdArticulo  = " + ID_Item);
                dataManager.executeRead();
                while (dataManager.Lector.Read())
                {
                    string Url = (string)dataManager.Lector["ImagenUrl"];
                    ArticleImages.Add(Url);
                }
                dataManager.closeConection();
                return ArticleImages;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}