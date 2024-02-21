using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaGestionBiblioteca;
public class Usuario
{
    public string IdUsuario { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string? Email { get; set; }

    private static int _id = 1;

    public Usuario(string nombre, string apellidos, string? email)
    {
        IdUsuario = _id.ToString();
        Nombre = nombre;
        Apellidos = apellidos;
        Email = email;
        _id++;
    }

    public override string ToString() => $"{IdUsuario} - {Nombre} {Apellidos} - {Email ?? "Sin datos"}";
}
