using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMonedasMAUI.Modelos
{
    public class Moneda
    {
        public string? NombreMoneda { get; set; }
        public string? SiglasMoneda { get; set; }
        public string? CodigoPais { get; set; }
        public string UrlImagen => $"https://flagcdn.com/32x24/{CodigoPais}.png";

        public Moneda() { }

        public Moneda(string siglasMoneda, string nombreMoneda, string codigoPais)
        {
            SiglasMoneda = siglasMoneda;
            NombreMoneda = nombreMoneda;
            CodigoPais = codigoPais;
        }
    }
}
