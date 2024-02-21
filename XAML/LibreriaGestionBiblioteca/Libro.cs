using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaGestionBiblioteca;
public class Libro(string titulo, string autor, string isbn, string year)
{
    public string Titulo { get; set; } = titulo;
    public string Autor { get; set; } = autor;
    public string ISBN { get; set; } = isbn;
    public string Year { get; set; } = year;
    public override string ToString() => $"{Titulo} - {Autor} - {ISBN} - {Year}";
}
