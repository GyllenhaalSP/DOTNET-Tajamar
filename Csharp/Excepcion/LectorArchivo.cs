namespace Excepcion;

public class LectorArchivo
{
    public void LeerArchivo(string nombreArchivo)
    {
        string contenido;
        FileStream archivoStream;
        StreamReader archivoLector;

        Console.WriteLine("Abriendo archivo...");
        try
        {
            //contenido = File.ReadAllText(nombreArchivo);
            //Thread.Sleep(3000);

            archivoStream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            archivoLector = new StreamReader(archivoStream);

            contenido = archivoLector.ReadToEnd();

        }
        catch (FileNotFoundException e)
        {
            //contenido = $"Archivo no encontrado: {e.Message}";
            //Console.WriteLine(contenido);
            throw new ExcepcionPersonalizada(e.Message, DateTime.Now, nombreArchivo);
        }
        catch (Exception e)
        {
            contenido = $"Error al leer el archivo: {e.Message}";
            Console.WriteLine(contenido);
        }

        Console.WriteLine(contenido);
    }
}

