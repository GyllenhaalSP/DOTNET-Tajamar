using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMonedasMAUI.Modelos
{
    public class GestorMoneda
    {
        public List<Moneda> Monedas { get; set; }

        public GestorMoneda()
        {
            Monedas =
            [
                new Moneda("EUR","Euro", "eu"),
                new Moneda("USD", "Dolar", "us"),
                new Moneda("GBP","Libra Esterlina", "gb")
            ];
        }
    }
}
