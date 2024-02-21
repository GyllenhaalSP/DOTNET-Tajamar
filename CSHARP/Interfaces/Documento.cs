namespace Interfaces;

public class Documento(string archivo) : IAlmacenamiento, IImprimir
{
    public string NombreArchivo { get; set; }

    public void Escribir(string archivo)
    {
    }

    public void Leer(string archivo)
    {
    }

    public void Imprimir(string archivo)
    {
    }
}
