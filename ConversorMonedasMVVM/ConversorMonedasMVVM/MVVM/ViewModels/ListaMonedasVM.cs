using ConversorMonedasMVVM.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMonedasMVVM.MVVM.ViewModels
{
    public class ListaMonedasVM
    {
        public List<Moneda>? Monedas { get; set; }

        public ListaMonedasVM() 
        {
            Monedas = [

                new Moneda("Dólar", "USD", "Estados Unidos", "US", SimbolosMonedas.Dolar),
                new Moneda("Euro", "EUR", "Unión Europea", "EU", SimbolosMonedas.Euro),
                new Moneda("Libra", "GBP", "Reino Unido", "GB", SimbolosMonedas.Libra),
                new Moneda("Yuan", "CNY", "China", "CN", SimbolosMonedas.Yen),
                new Moneda("Yen", "JPY", "Japón", "JP", SimbolosMonedas.Yen),
                new Moneda("Peso Mexicano", "MXN", "México", "MX", SimbolosMonedas.Dolar),
                new Moneda("Peso Argentino", "ARS", "Argentina", "AR", SimbolosMonedas.Dolar),
             ];
        }
    }
}
