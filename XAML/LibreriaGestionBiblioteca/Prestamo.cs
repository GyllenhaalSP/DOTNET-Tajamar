using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaGestionBiblioteca;
public class Prestamo
{
    public string IdPrestamo { get; set; }
    public Usuario Usuario { get; set; }
    public Libro Libro { get; set; }

    private static int _id = 1;

    private List<Libro> _prestamos = [];

    public Prestamo(Usuario usuario, Libro libro)
    {
        Usuario = usuario;
        Libro = libro;
        IdPrestamo = _id.ToString();
        _prestamos.Add(libro);
        _id++;
    }

    public override string ToString()
    {
        var prestamo = $"{Usuario.Nombre} {Usuario.Apellidos}\nID de Préstamo: {IdPrestamo}";
        foreach (var libro in _prestamos)
        {
            prestamo += $"\n\tISBN: {libro.ISBN}\n\tDatos: {libro.Titulo} - {libro.Autor} - {libro.Year}";
        }
        return "\n" + prestamo;
    }
}

