using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        private decimal precio;
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public Clasificacion Marca { get; set; }
        [DisplayName("Categoría")]
        public Clasificacion Categoria { get; set; }
        [DisplayName("URL de la imagen")]
        public string ImagenUrl { get; set; }
        public decimal Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = decimal.Round(value, 2, MidpointRounding.AwayFromZero);
            }
        }



    }
}
