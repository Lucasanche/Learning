using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_métodos
{
    class Animal
    {
        public int coso { get; set; }
        public virtual string comunicarse()
        {
            return "ruido ruido";
        }
    }
}
