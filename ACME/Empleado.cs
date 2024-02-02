using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Empleado
    {
        protected const int DiasVacaciones = 25;
        protected int DiasExtra;

        public string Nombre { get; set; }

        public Empresa Empresa { get; set; }

        public Empleado(string nombre, int diasExtra, Empresa empresa)
        {
            Nombre = nombre;
            DiasExtra = diasExtra;
            Empresa = empresa;
        }
    }
}