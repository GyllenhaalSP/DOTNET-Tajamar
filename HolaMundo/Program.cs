namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- Pedir mi nombre
            Console.WriteLine("Escribe tu nombre");
            string? nombre = Console.ReadLine();

            // 2- Obtener la suma de dos números
            double suma = Suma(5, 6);

            // 3- Mostrar Hola Mundo, mi nombre y la suma
            Console.WriteLine("Hola Mundo!!!!!");
            Console.WriteLine($"Mi nombre es {nombre}");
            Console.WriteLine($"La suma es {suma}");
        }

        public static int Suma(int b, int a)
        {
            return a + b;
        }
    }

}