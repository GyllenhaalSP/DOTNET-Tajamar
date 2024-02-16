namespace Asincronia;
internal class Program
{
    static async Task Main(string[] args)
    {
        Task tareaA = OperacionLargaDuracionA();
        Task tareaB = OperacionLargaDuracionB();
        Task tareaC = OperacionLargaDuracionC();

        await Task.WhenAll(tareaA, tareaB, tareaC);
        Console.WriteLine("Continuamos con otras tareas...");
    }

    static async Task OperacionLargaDuracionA()
    {
        Console.WriteLine("Iniciando operación de larga duración...");
        await Task.Delay(3000); // Simula una operación que tarda 3 segundos
        Console.WriteLine("Operación de larga duración A finalizada");
    }

    static async Task OperacionLargaDuracionB()
    {
        Console.WriteLine("Iniciando operación de larga duración...");
        await Task.Delay(5000); // Simula una operación que tarda 5 segundos
        Console.WriteLine("Operación de larga duración B finalizada");
    }

    static async Task OperacionLargaDuracionC()
    {
        Console.WriteLine("Iniciando operación de larga duración...");
        await Task.Delay(1000); // Simula una operación que tarda 1 segundos
        Console.WriteLine("Operación de larga duración C finalizada");
    }
}
