namespace BucleFor;

internal class Program
{
    public static void Main(string[] args)
    {
        const string titulo = "Ejercicio Bucles For";

        Console.WriteLine(titulo);
        // 1-Concatenación de cadenas
        //Console.WriteLine("Fecha de hoy: "+DateTime.Now+" "+titulo);

        // 2-Parámetros de cadena {0},{1},...{15}
        //                                                {0}       {1}
        //Console.WriteLine("Fecha de hoy {0} , {1} ",DateTime.Now,titulo);

        // 3-Interpolación de cadenas
        Console.WriteLine($"Fecha de hoy {DateTime.Now} , {titulo} ");



        // Ejemplo bucle for
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($" Contador: {i} ");
        }

        // Ejercicio de hoy: 
        // Mostrar por pantalla los números primos del 1 al 1000
        var resto = 10 % 2;

        Console.WriteLine("Números primos del 1 al 1000:");
        for (int i = 2; i <= 1000; i++) 
        { 
            if (EsPrimo(i)) 
            {
                Console.Write(i + " "); 
            } 
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}