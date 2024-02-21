using LibreriaGestionBiblioteca;

GestorBiblioteca gestor = new();

Libro libro = new("El Quijote", "Miguel de Cervantes", "785475172", "1622");
Libro libro2 = new("El señor de los anillos", "J.R.R. Tolkien", "255877455", "1954");
Libro libro3 = new("Cien años de soledad", "Gabriel García Márquez", "785425368", "1967");
Libro libro4 = new("Sin noticias de Gurb", "Eduardo Mendoza", "412054057", "1991");
Libro libro5 = new("El amor en los tiempos del cólera", "Gabriel García Márquez", "325478545", "1985");

gestor.AddLibro(libro, libro2, libro3, libro4, libro5);

Console.WriteLine("--- Libros añadidos ---");
Console.WriteLine(gestor.ListarLibros());
Console.WriteLine();

Usuario usuario = new("Juan", "Pérez García", "juan.perez@gmail.com");
Usuario usuario2 = new("María", "López Fernández", "");
Usuario usuario3 = new("Carlos", "Gómez Hernández", "carlos.gomez@gmail.com");

gestor.AddUsuario(usuario, usuario2, usuario3);

Console.WriteLine("--- Usuarios añadidos ---");
Console.WriteLine(gestor.ListarUsuarios());
Console.WriteLine();

Prestamo prestamo = new(usuario, libro);
Prestamo prestamo2 = new(usuario, libro2);
Prestamo prestamo3 = new(usuario2, libro3);
Prestamo prestamo4 = new(usuario3, libro4);
Prestamo prestamo5 = new(usuario3, libro5);

gestor.AddPrestamo(prestamo, prestamo2, prestamo3, prestamo4, prestamo5);

Console.WriteLine("--- Préstamos añadidos ---");
Console.WriteLine(gestor.ListarPrestamos());

Console.WriteLine("--- Préstamos por usuario ---");
