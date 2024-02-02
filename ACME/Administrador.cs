using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Administrador : Empleado
    {
        public bool UsaParking { get; set; }
        public string Matricula { get; set; }

        private const int DiasExtra = 5;

        public Administrador(string nombre, Empresa empresa, bool usaParking, string matricula)
            : base(nombre, DiasExtra, empresa)
        {
            UsaParking = usaParking;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $"El administrador {Nombre} trabaja para {Empresa.Nombre}, tiene {DiasVacaciones + DiasExtra} días de vacaciones {(UsaParking ? $"y usa parking con el coche {Matricula}" : "y no usa parking")}";
        }
    }
}