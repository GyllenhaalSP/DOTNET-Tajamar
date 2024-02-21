namespace ACME;

public class Administrador : Empleado
{
    public bool UsaParking { get; set; }
    public string Matricula { get; set; }

    private const int DiasExtra = 5;

    public Administrador(string nombre, Empresa empresa, bool usaParking, string matricula) : base(nombre, empresa)
    {
        UsaParking = usaParking;
        Matricula = matricula;
    }

    public Administrador(string nombre, Empresa empresa, bool usaParking) : this(nombre, empresa, usaParking,
        string.Empty) { }

    public override int CalcularDiasVacaciones()
    {
        return base.CalcularDiasVacaciones() + DiasExtra;
    }

    public override string ToString()
    {
        return $"El administrador {Nombre} trabaja para {Empresa.Nombre}, tiene {CalcularDiasVacaciones()} días de vacaciones {(UsaParking ? $"y usa parking con el coche {Matricula}" : "y no usa parking")}";
    }
}