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
        public List<Moneda> Monedas { get; set; }

        public ListaMonedasVM() { }

        public ListaMonedasVM(List<Moneda> monedas)
        {
            Monedas = monedas;
        }
    }
}
