using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMonedasMAUI.Modelos
{
    public class Moneda(string siglasMoneda, string nombreMoneda, string codigoPais)
    {
        public string NombreMoneda { get; set; } = nombreMoneda;
        public string SiglasMoneda { get; set; } = siglasMoneda;
        public string CodigoPais { get; set; } = codigoPais;
        public string UrlImagen => $"https://flagcdn.com/16x12/{CodigoPais}.png";
    }
}
