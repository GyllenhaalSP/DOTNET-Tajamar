using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACME
{
    public class Teams() : IMensajeria
    {
        public string EnviarMensaje(string mensaje)
        {
            return $"\n\tMensaje por Teams: {mensaje}";
        }
    }
}