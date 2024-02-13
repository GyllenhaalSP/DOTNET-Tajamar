using Listas;
using static System.String;

/*
 * Repositorio de Empleados
 * Es un patrón de diseño creacional que se utiliza en POO para separar la lógica que recupera los datos de una BB DD o de una API de la lógica de negocio.
 * Permite CRUD de una lista de empleados
 * C - Create
 * R - Retrieve
 * U - Update
 * D - Delete
 *
 * Un patrón de diseño es una solución general reutilizable a un problema común que se encuentra en el desarrollo de software.
 *
 * Tres tipos de patrones: Creacionales, Estructurales y de Comportamiento.
 */

// Crear una lista de empleados
List<Empleado> empleados =
[
    new Empleado(1, "Juan", "Ventas"),
    new Empleado(2, "Ana", "Ventas"),
    new Empleado(3, "Luis", "Ventas"),
    new Empleado(4, "Elena", "Ventas"),
    new Empleado(5, "Carlos", "Sistemas"),
    new Empleado(6, "María", "Sistemas"),
    new Empleado(7, "Pedro", "Sistemas"),
    new Empleado(8, "Carmen", "Sistemas")
];

empleados.Add(new Empleado(9, "Pablo", "Ventas"));

BuscarEmpleado(empleados, out var resultadoEmpleadoEspecifico);
Console.WriteLine($"Empleado encontrado: {resultadoEmpleadoEspecifico.Nombre}");

OrdenarEmpleados(empleados);
Console.WriteLine("\nEmpleados ordenados por nombre: ");
foreach (var empleado in empleados)
{
    Console.WriteLine(empleado.Nombre);
}

FiltrarEmpleados(empleados, out var resultadoEmpleadosSistemas);
Console.WriteLine("\nEmpleados del departamento de sistemas: ");
foreach (var empleado in resultadoEmpleadosSistemas)
{
    Console.WriteLine(empleado.Nombre);
}

ActualizarEmpleado(empleados);
Console.WriteLine("\nEmpleados actualizados: ");
foreach (var empleado in empleados)
{
    Console.WriteLine(empleado.Nombre);
}

EliminarEmpleado(empleados);
Console.WriteLine("\nEmpleados eliminados: ");
foreach (var empleado in empleados)
{
    Console.WriteLine(empleado.Nombre);
}

return;

static void BuscarEmpleado(List<Empleado> listaEmpleados, out Empleado empleadoEspecifico)
{
    foreach (var empleado in listaEmpleados)
    {
        if (empleado.Id != 5) continue;
        empleadoEspecifico = empleado;
        break;
    }
    empleadoEspecifico = new Empleado(0, "No encontrado", "No encontrado");
}

static void FiltrarEmpleados(List<Empleado> listaEmpleados, out List<Empleado> empleadosSistemas)
{
    empleadosSistemas = [];
    foreach (var empleado in listaEmpleados)
    {
        if (empleado.Departamento == "Sistemas")
        {
            empleadosSistemas.Add(empleado);
        }
    }
}


static void OrdenarEmpleados(IList<Empleado> listaEmpleados)
{
    // Bubble sort para ordenar listaEmpleados por nombre
    for (var i = 0; i < listaEmpleados.Count; i++)
    {
        for (var j = i + 1; j < listaEmpleados.Count; j++)
        {
            if (Compare(listaEmpleados[i].Nombre, listaEmpleados[j].Nombre, StringComparison.Ordinal) > 0)
            {
                (listaEmpleados[i], listaEmpleados[j]) = (listaEmpleados[j], listaEmpleados[i]);
            }
        }
    }
}

static void ActualizarEmpleado(List<Empleado> listaEmpleados)
{
    foreach (var empleado in listaEmpleados)
    {
        if (empleado.Id != 5) continue;
        empleado.Nombre = "Alberto";
        empleado.Departamento = "Sistemas";
    }
}

static void EliminarEmpleado(IList<Empleado> listaEmpleados)
{
    for (var i = listaEmpleados.Count - 1; i >= 0; i--)
    {
        if (listaEmpleados[i].Id == 1)
        {
            listaEmpleados.RemoveAt(i);
        }
    }
}