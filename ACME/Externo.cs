namespace ACME;

public class Externo : ITrabajador
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
        return $"El trabajador externo {Nombre} trabaja para {Empresa.Nombre}. {CalcularDiasVacaciones()}";
    }

    public int CalcularDiasVacaciones()
    {
        throw new NoDatabaseFound($"El trabajador externo {Nombre} trabaja para {Empresa.Nombre}. Los empleados externos no tienen vacaciones gestionadas por ACME");
    }
}
