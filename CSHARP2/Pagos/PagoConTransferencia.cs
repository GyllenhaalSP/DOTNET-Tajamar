using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pagos
{
    public class PagoConTransferencia : IPago
    {
        public string Servicio => "Transferencia";
        public bool ProcesarPago(decimal total)
        {
            Console.WriteLine($"Procesando pago con transferencia por importe de {total:C}");
            return true;
        }

        public bool VerificarPago()
        {
            Console.WriteLine("Verificando pago con transferencia");
            return true;
        }
    }
}