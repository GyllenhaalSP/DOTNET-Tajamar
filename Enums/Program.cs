Console.Write("Introduce la edad: ");
var edad = int.Parse(Console.ReadLine());

// Hay que mostrar según la edad 
// si debe renovar el carnet de conducir
// Si es menor de 16 años no tiene carnet de conducir
// Si es mayor de 65 años renovar cada cinco años 
// Si está entre 18 y 65 renovar cada 10 años

switch (edad)
{
    case <= (int)Edades.NoTieneCarnet:
        Console.WriteLine("No tiene que renovar el carnet porque no lo tiene");
        break;
    case >= (int)Edades.ConductorHabitual and <= (int)Edades.Mayor65:
        Console.WriteLine("Renovar carnet cada 10 años");
        break;
    case >= (int)Edades.Mayor65:
        Console.WriteLine("Renovar carnet cada 5 años");
        break;
}

internal enum Edades
{
    NoTieneCarnet = 16,
    Mayor65 = 65,
    ConductorHabitual = 18
}