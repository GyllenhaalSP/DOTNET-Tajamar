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
                new Moneda("EUR","Euro"),
                new Moneda("USD", "Dolar"),
                new Moneda("GBP","Libra Esterlina")
            ];
        }
    }
}
