using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pagos
{
    public class PagoConTarjeta : IPago
    {
        public string Servicio => "Tarjeta";
        public bool ProcesarPago(decimal total)
        {
            Console.WriteLine($"Procesando pago con tarjeta por importe de {total:C}");
            return true;
        }

        public bool VerificarPago()
        {
            Console.WriteLine("Verificando pago con tarjeta");
            return true;
        }
    }
}