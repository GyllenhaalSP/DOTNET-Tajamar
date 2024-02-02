using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Empleado> Empleados { get; set; }

        public List<Externo> Externos { get; set; }

        public Empresa(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Empleados = new List<Empleado>();
            Externos = new List<Externo>();

        }

        public override string ToString()
        {
            string info = $"La empresa {Nombre} sita en {Direccion} tiene los siguientes empleados:";

            foreach (Empleado empleado in Empleados)
            {
                info += $"\n\t{empleado}";
            }

            info += "\nY los siguientes externos:";
            foreach (Externo externo in Externos)
            {
                info += $"\n\t{externo}";
            }
            return info ;
        }
    }
}