using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Granja
{
    public class Fruta
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Sabor { get; set; }
        public string Tipo { get; set; }

        public Fruta(string nombre, string color, string sabor, string tipo)
        {
            Nombre = nombre;
            Color = color;
            Sabor = sabor;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Color} - {Sabor} - {Tipo}";
        }
    }
}
