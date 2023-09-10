using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class AddArticle
    {
        public List<Article> listar()
        {

            List<Article> list = new List<Article>();
            DataManager dataManager = new DataManager();

            try
            {

                dataManager.setQuery("SELECT A.Codigo,A.Nombre,A.Descripcion,M.Descripcion AS 'Marca', C.Descripcion AS 'Categoria' ,A.Precio FROM  ARTICULOS A LEFT JOIN  MARCAS M on M.Id= A.IdMarca LEFT JOIN CATEGORIAS C on C.Id= A.IdCategoria");
                dataManager.executeRead();
                while (dataManager.Lector.Read())
                {

                    Article article = new Article();

                    article.ArtCode = (string)dataManager.Lector["Codigo"];
                    article.Name = (string)dataManager.Lector["Nombre"];
                    article.Description = (string)dataManager.Lector["Descripcion"];
                    //Falta IdMarca
                   //Falta IdCategoria
                    article.Price = (decimal)dataManager.Lector["Precio"];

                    list.Add(article);
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

        public void add(Article add)
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
        public void edit(Article edit)
        {

        }
    }
}

