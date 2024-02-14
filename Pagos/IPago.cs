using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pagos
{
    public interface IPago
    {
        string Servicio { get; }
        bool ProcesarPago(decimal total);
        bool VerificarPago();
    }
}