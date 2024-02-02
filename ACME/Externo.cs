namespace ACME;

public class Externo
{
    public Empresa Empresa { get; set;}
    public string Nombre { get; set; }

    public Externo(string nombre, Empresa empresa)
    {
        Nombre = nombre;
        Empresa = empresa;
    }

    public override string ToString()
    {
        return $"El trabajador externo {Nombre} trabaja para {Empresa.Nombre}";
    }
}
