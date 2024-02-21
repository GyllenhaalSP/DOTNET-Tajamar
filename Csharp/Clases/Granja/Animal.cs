using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Granja
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Sonido { get; set; }

        public Animal(string nombre, string raza, string sonido)
        {
            Nombre = nombre;
            Raza = raza;
            Sonido = sonido;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Raza} - {Sonido}";
        }
    }
}
