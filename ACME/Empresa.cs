namespace ACME;

public class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Empleado> Empleados { get; set; } = [];

    public List<Externo> Externos { get; set; } = [];

    public Empresa(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
    }

    public override string ToString()
    {
        var info = $"La empresa {Nombre} sita en {Direccion} tiene los siguientes empleados:";

        foreach (var empleado in Empleados)
        {
            info += $"\n\t{empleado}";
        }

        info += "\nY los siguientes externos:";

        foreach (var externo in Externos)
        {
            info += $"\n\t{externo}";
        }
        return info ;
    }
}