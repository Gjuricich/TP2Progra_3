using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Marc
    {
        public int Id { get; set; }
        public string Descripcion { get; private set; }

        public List<Marc>listar()
        {
            List<Marc> list = new List<Marc>();
            DataManager dataManager = new DataManager();

            try
            {

                dataManager.setQuery("SELECT Id, Descripcion FROM MARCAS");
                dataManager.executeRead();
                while (dataManager.Lector.Read())
                {
                   Marc addMarc = new Marc();
                    addMarc.Id = (int)dataManager.Lector["IdMarca"];
                    addMarc.Descripcion = (string)dataManager.Lector["Descripcion"];

                    list.Add(addMarc);
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
