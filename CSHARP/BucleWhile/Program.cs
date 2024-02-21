int contador = -1000;

do
{
    Console.WriteLine($" Valor actual del contador: {contador}");
    contador++;

} while (contador < 0);

Console.WriteLine("Hemos salido del bucle do-while");

while (contador < 0)
{
    Console.WriteLine($" Valor actual del contador: {contador}");
    contador++;
}

Console.WriteLine("¿Hemos entrado al bucle while?");