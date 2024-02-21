using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMonedas
{
    public class Moneda(int id, string? codigoIso, string? nombre)
    {
        public int Id { get; set; } = id;
        public string? CodigoIso { get; set; } = codigoIso;
        public string? Nombre { get; set; } = nombre;
        public override string ToString()
        {
            return $"{Id} - {CodigoIso} - {Nombre}";
        }
    }
}
