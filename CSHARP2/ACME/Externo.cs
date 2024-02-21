namespace ACME;

public class Externo(string nombre, Empresa empresa) : ITrabajador
{
    public Empresa Empresa { get; set; } = empresa;
    public string Nombre { get; set; } = nombre;
    public IMensajeria AplicacionMensajeria { get; set; }

    public override string ToString()
    {
        return $"El trabajador externo {Nombre} trabaja para {Empresa.Nombre}. {CalcularDiasVacaciones()}";
    }

    public int CalcularDiasVacaciones()
    {
        throw new NoDatabaseFound($"El trabajador externo {Nombre} trabaja para {Empresa.Nombre}. Los empleados externos no tienen vacaciones gestionadas por ACME");
    }
}
