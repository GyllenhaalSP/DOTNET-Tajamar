namespace Condicionales
{
    internal class Program
    {
        /// <summary>
        /// Ejemplo de Condicionales.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cual es tu edad?");
            
            // Obtenemos la edad en una variable
            // de tipo cadena (string)
            string edad = Console.ReadLine(); // Pide edad
            int edadNumero = int.Parse(edad);

            // Pedir el nombre
            Console.WriteLine("¿Cual es tu nombre?");
            var nombre = Console.ReadLine();
            nombre = nombre.ToUpper();


            // Mostrar nombre y edad por pantalla
            Console.WriteLine("Hola " + nombre + " tienes " + edadNumero);

            // Hay que mostrar según la edad 
            // si puede subir o no a la atracción
            // Si es menor de 6 años no puede subir
            // Si es mayor de 65 años no puede subir
            // Si está entre 7 y 65 puede subir

            // Si tienes menos de 6 años 
            if (edadNumero <= 6)
            {
                // No puedes subir, lo siento
                Console.WriteLine("No puedes subir, lo siento");
            }
            // Si es mayor de 65 años
            else if (edadNumero >= 65) 
            {
                // No puedes subir, lo siento
                Console.WriteLine("No puedes subir, lo siento");
            }
            // faltan los de 7 a 65
            else
            {
                Console.WriteLine("Felicidades, disfruta del viaje !!!!");
            }
        }
    }
}
