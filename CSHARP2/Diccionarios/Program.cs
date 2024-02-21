using Listas;

Diccionarios();
return;

// Arrays, Listas y Diccionarios son estructuras de datos que permiten almacenar colecciones de elementos e implementan la interfaz IEnumerable<T>.
// LINQ - Language Integrated Query - es un conjunto de métodos de extensión que permiten realizar consultas sobre colecciones de datos que implementan IEnumerable<T>.

static void Diccionarios()
{
    // Crear un diccionario de empleados
    var empleados = new Dictionary<int, Empleado?>
    {
        { 1, new Empleado(1, "Juan", "Sistemas") },
        { 2, new Empleado(2, "Ana", "Ventas") },
        { 3, new Empleado(3, "Luis", "Sistemas") },
        { 4, new Empleado(4, "Elena", "Ventas") },
        { 5, new Empleado(5, "Carlos", "Sistemas") }
    };

    // Buscar un empleado por ID
    Console.WriteLine(empleados.TryGetValue(3, out var empleadoEspecifico)
        ? $"Empleado encontrado: {empleadoEspecifico?.Nombre}"
        : "Empleado no encontrado");

    // Actualizar un empleado
    if (empleados.ContainsKey(5))
    {
        empleados[5] = new Empleado(5, "Carlos", "Recursos Humanos");
    }

    // Eliminar un empleado
    empleados.Remove(4);
    Console.WriteLine("\nEmpleado 4 eliminado: ");

    // Iterar sobre los empleados
    Console.WriteLine("\nEmpleados: ");
    foreach (var empleado in empleados.Values)
    {
        Console.WriteLine(empleado?.Nombre);
    }

    // Filtrar empleados por departamento
    var empleadosSistemas = new List<Empleado>();
    foreach (var empleado in empleados.Values)
    {
        if (empleado?.Departamento == "Sistemas")
        {
            empleadosSistemas.Add(empleado);
        }
    }

    Console.WriteLine("\nEmpleados del departamento de sistemas: ");
    foreach (var empleado in empleadosSistemas)
    {
        Console.WriteLine(empleado?.Nombre);
    }

    // Mostrar todos los empleados
    Console.WriteLine("\nTodos los empleados: ");
    foreach (var (key, values) in empleados)
    {
        Console.WriteLine($"ID: {key}, Nombre: {values?.Nombre}, Departamento: {values?.Departamento}");
    }
}