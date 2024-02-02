namespace ACME;

public class Operario : Empleado
{
    public Turno TurnoOperario { get; set; }
    private const int DiasExtra = 6;

    public Operario(string nombre, Turno turnoOperario, Empresa empresa) : base(nombre, empresa)
    {
        TurnoOperario = turnoOperario;
    }

    public override int CalcularDiasVacaciones()
    {
        return base.CalcularDiasVacaciones() + DiasExtra;
    }

    public override string ToString()
    {
        return $"El operario {Nombre} trabaja para {Empresa.Nombre}, tiene {CalcularDiasVacaciones()} días de vacaciones y trabaja en el turno de {TurnoOperario}";
    }
}

public enum Turno
{
    Mañana,
    Tarde,
    Noche
}