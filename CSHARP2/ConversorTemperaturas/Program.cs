// Creamos un menu de opciones para la selección de temperatura

using Utilidades;

var opcion = "";

while (opcion != "s")
{
    Console.WriteLine("Por favor introduzca C para Celsius o F para Fahrenheit o K para Kelvin");
    Console.WriteLine("Escriba S para salir");

    opcion = Console.ReadLine();

    string temperatura = "";
    double fahrenheit, celsius;


    switch (opcion.ToLower())
    {
        // En caso de Celsius
        case "c":
            Console.WriteLine("Por favor, introduzca la temperatura en grados Celsius");
            temperatura = Console.ReadLine();
            fahrenheit = ConvertidorTemperaturas.CelsiusFahrenheit(temperatura);
            Console.WriteLine($"Temperatura en Fahrenheit {fahrenheit}");
            break;

        // En caso de Fahrenheit
        case "f":
            Console.WriteLine("Por favor, introduzca la temperatura en grados Fahrenheit");
            temperatura = Console.ReadLine();
            celsius = ConvertidorTemperaturas.FahrenheitCelsius(temperatura);
            Console.WriteLine($"Temperatura en Celsius {celsius}");
            break;

        // En caso de Kelvin
        case "k":
            Console.WriteLine("Por favor, introduzca la temperatura en grados Celsius");
            temperatura = Console.ReadLine();
            double kelvin = ConvertidorTemperaturas.CelsiusKelvin(temperatura);
            Console.WriteLine($"Temperatura en Kelvin {kelvin}");
            break;

        // En caso de Salir
        case "s":
            Console.WriteLine("Finalizando programa....");
            break;

        default:
            Console.WriteLine("Opción no válida");
            break;
    }

}