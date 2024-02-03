namespace ACME;

public class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<ITrabajador> Empleados { get; set; } = [];

    public Empresa(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
    }

    public void Contratar(ITrabajador empleado)
    {
        Empleados.Add(empleado);
    }

    public override string ToString()
    {
        var info = $"La empresa {Nombre} sita en {Direccion} tiene los siguientes empleados:";

        foreach (var empleado in Empleados)
        {
            if (empleado is Empleado)
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