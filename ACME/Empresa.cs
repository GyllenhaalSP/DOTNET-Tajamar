namespace ACME;

public class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Object> Empleados { get; set; } = [];

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
            if (empleado is Administrador or Operario)
                info += $"\n\t{empleado}";
        }

        info += "\nY los siguientes externos:";

        foreach (var empleado in Empleados)
        {
            if (empleado is Externo)
                info += $"\n\t{empleado}";
        }
        return info ;
    }
}