using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_métodos
{
    internal class Pez : AnimalDomestico
    {
        public override string comunicarse()
        {
            return "glu glu";
        }
    }
}
