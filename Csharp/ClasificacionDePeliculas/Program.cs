namespace ClasificacionDePeliculas;

class Program
{
    public enum Clasificacion
    {
        General,
        Adolescentes,
        Adultos
    }

    public static void Main(string[] args)
    {
        const int edadMinimaAdolescentes = 13;
        const int edadMinimaAdultos = 18;
        while (true)
        {
            Console.Write("Introduce tu edad: ");
            if (int.TryParse(Console.ReadLine(), out var edad))
            {
                if (edad < edadMinimaAdolescentes)
                {
                    Console.WriteLine($"Puedes ver películas clasificadas como {Clasificacion.General}.");
                }
                else if (edad is >= edadMinimaAdolescentes and < edadMinimaAdultos)
                {
                    Console.WriteLine($"Puedes ver películas clasificadas como {Clasificacion.General} y para {Clasificacion.Adolescentes}.");
                }
                else
                {
                    Console.WriteLine($"Puedes ver películas de todas las categorías: {Clasificacion.General}, {Clasificacion.Adolescentes} y {Clasificacion.Adultos}.");
                }
            }
            else
            {
                Console.WriteLine("Edad no válida");
            }

            Console.Write("¿Deseas continuar? (s/n) ");
            var opcion = Console.ReadLine()?.ToLower();
            if (opcion != "s" && opcion != string.Empty) break;
        }
        Console.WriteLine("¡Hasta luego!");
    }
}
