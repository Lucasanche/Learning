using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_métodos
{
    internal class Canario : AnimalDomestico, Iflyable
    {
        public override string comunicarse()
        {
            return "pio pio";
        }

        string Iflyable.volar()
        {
            return "vuela como un canario";
        }
    }
}
