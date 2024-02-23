using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMonedasMVVM.MVVM.Models
{
    public class Moneda
    {
        public string? Nombre { get; set; }

        public string? CodigoIso { get; set; }

        public string? Pais { get; set; }

        public string? CodigoPais { get; set; }

        public SimbolosMonedas Simbolo { get; set; }

        public string? Imagen { get; set; }

        public Moneda() { }

        public Moneda(string nombre, string codigoIso, string pais, string codigoPais, SimbolosMonedas simbolo)
        {
            Nombre = nombre;
            CodigoIso = codigoIso;
            CodigoPais = codigoPais;
            Pais = pais;
            Simbolo = simbolo;
            Imagen = $"https://flagcdn.com/64x48/{codigoPais.ToLower()}.png";
        }
    }

    public enum SimbolosMonedas
    {
        Dolar = '$',
        Euro = '€',
        Libra = '£',
        Yen = '¥',
    }
}
