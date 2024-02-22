using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMonedasMAUI.Modelos
{
    public class GestorMonedas
    {
        public List<Moneda> Monedas { get; set; }

        public GestorMonedas()
        {
            Monedas =
            [
                new Moneda("EUR","Euro", "es"),
                new Moneda("USD", "Dolar", "us"),
                new Moneda("GBP","Libra Esterlina", "gb")
            ];
        }
    }
}
