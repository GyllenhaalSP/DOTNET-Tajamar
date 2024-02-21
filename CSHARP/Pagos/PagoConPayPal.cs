using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pagos
{
    public class PagoConPayPal : IPago
    {
        public string Servicio => "PayPal";
        public bool ProcesarPago(decimal total)
        {
            Console.WriteLine($"Procesando pago con PayPal por importe de {total:C}");
            return true;
        }

        public bool VerificarPago()
        {
            Console.WriteLine("Verificando pago con PayPal");
            return true;
        }
    }
}