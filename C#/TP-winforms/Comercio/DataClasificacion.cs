using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace Comercio
{
    public class DataClasificacion
    {
        public List<Clasificacion> listar(string nombretab)
        {
            
            List<Clasificacion> lista = new List<Clasificacion>();
            AccesData acceso = new AccesData();

            try
            {
                acceso.setQuery("SELECT ID,Description FROM " + nombretab);
                acceso.executeQuery();
                
                while (acceso.Reader.Read())
                {
                    Clasificacion aux = new Clasificacion();
                    aux.ID = (int)acceso.Reader["ID"];
                    aux.Descripcion = acceso.Reader["Description"] is DBNull ? "-No description-" : (string)acceso.Reader["Description"];
                    lista.Add(aux);
                }
                Clasificacion aux2 = new Clasificacion();
                aux2.Descripcion = "-Sin especificar-";
                aux2.ID = 0;
                lista.Add(aux2);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
 
            }



        }





    }
}
