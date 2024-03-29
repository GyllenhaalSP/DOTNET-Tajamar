﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversorMonedas;

/*
 * Crear la clase Moneda
 *  - ID
 *  - Código ISO (EUR, USD, GBP, JPY, etc.)
 *  - Nombre (Euro, Dólar, Libra, Yen, etc.)
 *
 * Crear una lista de monedas y mostrarla por pantalla
 *
 * Menú que muestre las opciones:
 *  L - Listar monedas
 *  N - Nueva moneda
 */

List<Moneda> monedas =
[
    new Moneda(1, "EUR", "Euro"),
    new Moneda(2, "USD", "Dólar"),
    new Moneda(3, "GBP", "Libra"),
    new Moneda(4, "JPY", "Yen")
];

string opcion;

do
{
    ImprimirMenu(out opcion);

    switch (opcion)
    {
        case "L":
            Console.Clear();
            ListarMonedas(monedas);
            break;
        case "N":
            Console.Clear();
            AgregarMoneda(monedas);
            break;
        case "E":
            Console.Clear();
            EliminarMoneda(monedas);
            break;
        case "S":
            Console.Clear();
            Console.WriteLine("Gracias por usar el conversor de ACME...");
            Console.WriteLine("Saliendo...");
            Thread.Sleep(2000);
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}
while (opcion != "S");

return;

static void ImprimirMenu(out string opcionUsuario)
{
    Console.WriteLine("Bienvenido al conversor de monedas de ACME.\n");
    Console.WriteLine("   L - Listar monedas");
    Console.WriteLine("   N - Nueva moneda");
    Console.WriteLine("   E - Eliminar moneda");
    Console.WriteLine("   S - Salir");
    Console.Write("\nSeleccione una opción: ");
    opcionUsuario = Console.ReadLine()?.ToUpper() ?? string.Empty;
}

static void ListarMonedas(List<Moneda> monedas)
{
    foreach (var moneda in monedas)
    {
        Console.WriteLine(moneda);
    }
    Console.WriteLine();
}

static void AgregarMoneda(List<Moneda> monedas)
{
    Console.Write("Introduzca el nombre de la moneda: ");
    var nombre = Console.ReadLine();
    Console.Write("Introduzca el código ISO de la moneda: ");
    var codigoIso = Console.ReadLine();
    if (!string.IsNullOrEmpty(codigoIso) && !string.IsNullOrEmpty(nombre))
    {
        monedas.Add(new Moneda(GenerarId(monedas), codigoIso, nombre));
        Console.WriteLine("\nMoneda agregada correctamente.\n");
    }
    else
    {
        Console.WriteLine("\nDatos de la moneda no válidos.\nNo se ha añadido nada.\n");
    }
}

static void EliminarMoneda(List<Moneda> monedas)
{
    Console.Write("Introduzca el ID de la moneda a eliminar: ");
    var id = Console.ReadLine();
    if (int.TryParse(id, out var idMoneda))
    {
        foreach (var moneda in monedas)
        {
            if (moneda.Id == idMoneda)
            {
                monedas.Remove(moneda);
                Console.WriteLine("\nMoneda eliminada correctamente.\n");
                return;
            }
            Console.WriteLine("\nID de moneda no encontrado.\n");
        }
    }
    else
    {
        Console.WriteLine("\nID de moneda no válido.\n");
    }
}

static int GenerarId(List<Moneda> monedas)
{
    return monedas[^1].Id + 1;
}
