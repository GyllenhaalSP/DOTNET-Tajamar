namespace ACME;

public class Empleado : ITrabajador
{
    private const int DiasVacaciones = 25;

    public string Nombre { get; set; }

    public Empresa Empresa { get; set; }

    public Empleado(string nombre, Empresa empresa)
    {
        Nombre = nombre;
        Empresa = empresa;
    }

    public virtual int CalcularDiasVacaciones()
    {
        return DiasVacaciones;
    }
}