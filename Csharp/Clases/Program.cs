using Clases.RRHH;

Console.WriteLine("Hello, World!");


// Instancia de empleado Pedro
// Creamos la instancia asignando valores a cada propiedad 
// utilizando la instancia
Empleado pedro = new Empleado("Pedro", "Pérez", "IT");
pedro.DiasTrabajados = 40;
pedro.DiasVacaciones = 30;
pedro.GuardarDni("B12345678");


Console.WriteLine($" Nombre Completo: {pedro.NombreCompleto()}. " +
                  $"Quedan {pedro.CalcularDiasTrabajoRestantes(0)} dias por trabajar  ");


// Instancia de empleado Maria
// Creamos la instancia y asignamos valores a cada propiedad
// sin utilizar la instancia
Empleado maria = new Empleado("María", "Martínez", "Desarrollo APPS")
{
    DiasTrabajados = 20,
    DiasVacaciones = 10
};
maria.GuardarDni("A12345678");

var diasRestantes = maria.CalcularDiasTrabajoRestantes();
Console.WriteLine(maria.NombreCompleto());

// Instancia de empleado Juan
Empleado juan = new Empleado("Juan", "Lopez", "RRHH");
//juan.Nombre = "Juan";
//juan.Apellidos = "Lopez";
//juan.Puesto = "RRHH";
juan.GuardarDni("B12345678");
juan.DiasTrabajados = 20;
juan.DiasVacaciones = 10;
var diasRestantesJuan = juan.CalcularDiasTrabajoRestantes();

Console.WriteLine(juan.NombreCompleto());
