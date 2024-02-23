using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMonedasMAUI.Modelos;

public class Usuario
{
    public string Nombre { get; set; }

    public string Apellidos { get; set; }

    public string Foto { get; set;}

    public string NombreCompleto => $"{Nombre} {Apellidos}";

    public char Genero { get; set; }

    public Usuario() { }

    public Usuario(string nombre, string apellidos, char genero)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Genero = genero;
        Foto = $"https://randomuser.me/api/portraits/{GetRandomPicNumber()}";
    }

    public string GetRandomPicNumber()
    {
        var random = new Random().Next(1, 70);
        return $"{(Genero == 'V' ? "men" : "women")}/{random}.jpg";
    }
}