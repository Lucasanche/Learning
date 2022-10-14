using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_métodos
{
    internal class Aguila : AnimalSalvaje, Iflyable
    {
        public override string comunicarse()
        {
            return "*ruido de águila*";
        }
        string Iflyable.volar()
        {
            return "vuela como un águila";
        }
    }
}
