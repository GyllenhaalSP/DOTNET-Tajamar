using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMonedasMAUI.Modelos
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Foto
        {
            get
            {
                var foto = GetRandomPicNumber();
                return $"https://randomuser.me/api/portraits/{foto[0]}/{foto[1]}";
            }
        }

        public string NombreCompleto => $"{Nombre} {Apellidos}";

        public char Genero { get; set;}

        public Usuario() { }

        public Usuario(string nombre, string apellidos, char genero)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Genero = genero;
        }

        public string[] GetRandomPicNumber()
        {
            var random = new Random().Next(1, 70);
            return [(Genero == 'V' ? "men" : "women"), random.ToString() + ".jpg"];
        }
    }
}
