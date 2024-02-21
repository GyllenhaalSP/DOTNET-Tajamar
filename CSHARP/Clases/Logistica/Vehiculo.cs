using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Logistica
{
    public class Vehiculo
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Anio { get; set; }

        public Vehiculo(string matricula, string marca, string modelo, string color, string anio)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Anio = anio;
        }
    }
}
