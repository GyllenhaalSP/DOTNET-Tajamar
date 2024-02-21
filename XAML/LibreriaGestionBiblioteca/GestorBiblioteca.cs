namespace LibreriaGestionBiblioteca;
public class GestorBiblioteca
{
    private List<Libro> _libros = [];
    private List<Usuario> _usuarios = [];
    private List<Prestamo> _prestamos = [];

    public void AddLibro(params Libro[] libros)
    {
        foreach (var libro in libros)
        {
            _libros.Add(libro);
        }
    }

    public void EliminarLibro(Libro libro) => _libros.Remove(libro);
    public void AddUsuario(params Usuario[] usuarios)
    {
        foreach (var usuario in usuarios)
        {
            _usuarios.Add(usuario);
        }
    }

    public void EliminarUsuario(Usuario usuario) => _usuarios.Remove(usuario);
    public void AddPrestamo(params Prestamo[] prestamos)
    {
        foreach (var prestamo in prestamos)
        {
            _prestamos.Add(prestamo);
        }
    }

    public void EliminarPrestamo(Prestamo prestamo) => _prestamos.Remove(prestamo);

    public string ListarLibros() => string.Join("\n", _libros);
    public string ListarUsuarios() => string.Join("\n", _usuarios);
    public string ListarPrestamos() => string.Join("\n", _prestamos);
}

