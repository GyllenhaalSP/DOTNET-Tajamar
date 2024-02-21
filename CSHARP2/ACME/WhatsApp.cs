using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACME
{
    public class WhatsApp() : IMensajeria
    {
        public string EnviarMensaje(string mensaje)
        {
            return $"\n\tMensaje por WhatsApp: {mensaje}";
        }
    }
}