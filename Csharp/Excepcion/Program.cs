namespace Excepcion;

internal class Program
{
    public static void Main(string[] args)
    {
        var lectorArchivo = new LectorArchivo();

        try
        {
            lectorArchivo.LeerArchivo(@"C:\Users\wizar\Downloads\Ejempldo.txt");
        }
        catch (ExcepcionPersonalizada e)
        {
            Console.WriteLine($"Mensajito: {e.Message}, Fecha: {e.FechaHoraExcepcion}, Ruta: {e.Archivo}");
        }
    }
}