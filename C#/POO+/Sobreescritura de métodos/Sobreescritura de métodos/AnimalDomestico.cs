using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_métodos
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"Animal: {Nombre}";
        }
        public override string comunicarse()
        {
            return "Dame de comer";
        }
    }
}
