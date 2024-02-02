using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public class Operario : Empleado
    {
        public Turno Turno { get; set; }
        private const int DiasExtra = 6;

        public Operario(string nombre, Turno turno, Empresa empresa)
            : base(nombre, DiasExtra, empresa)
        {
            Turno = turno;
        }

        public override string ToString()
        {
            return $"El operario {Nombre} trabaja para {Empresa.Nombre}, tiene {DiasVacaciones + DiasExtra} días de vacaciones y trabaja en el turno de {Turno}";
        }
    }

    public enum Turno
    {
        Mañana,
        Tarde,
        Noche
    }
}