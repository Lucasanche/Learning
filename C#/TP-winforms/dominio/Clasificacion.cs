using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    /// Tanto las Categorias como las Marcas corresponden
    public class Clasificacion
    {
        public int ID { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            if (Descripcion != "")
            {
                return Descripcion;
            }
            else
            {
                return "-";
            }
        }
    }
}
