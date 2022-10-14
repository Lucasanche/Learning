using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(new Gato());
            animales.Add(new Gato());

            List<Iflyable> listaVoladores = new List<Iflyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }
            Console.ReadKey();
            animales[1].coso = 3;
        }
    }
}
