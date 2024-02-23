using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMonedasMVVM.MVVM.Models
{
    public class Moneda
    {
        public string Nombre { get; set; }

        public string CodigoIso { get; set; }

        public string CodigoPais { get; set; }

        public char Simbolo { get; set; }

        public string Imagen { get; set; }

        public Moneda() { }

        public Moneda(string nombre, string codigoIso, string codigoPais, char simbolo, string imagen)
        {
            Nombre = nombre;
            CodigoIso = codigoIso;
            CodigoPais = codigoPais;
            Simbolo = simbolo;
            Imagen = imagen;
        }
    }
}
