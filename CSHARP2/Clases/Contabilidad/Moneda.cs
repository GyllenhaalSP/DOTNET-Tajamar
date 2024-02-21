using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Contabilidad
{
    public class Moneda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Simbolo { get; set; }

        public Moneda(int id, string nombre, string simbolo)
        {
            Id = id;
            Nombre = nombre;
            Simbolo = simbolo;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Simbolo}";
        }
    }
}
