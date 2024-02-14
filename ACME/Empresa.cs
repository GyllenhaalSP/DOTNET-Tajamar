namespace ACME;

public class Empresa(string nombre, string direccion)
{
    public string Nombre { get; set; } = nombre;
    public string Direccion { get; set; } = direccion;
    public List<ITrabajador> Empleados { get; set; } = [];

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
            {
                info += $"\n\t{empleado}";
                info += empleado.AplicacionMensajeria.EnviarMensaje("Pocas vacaciones...");
            }
        }

        info += "\nY los siguientes externos:";

        foreach (var empleado in Empleados)
        {
            if (empleado is not Externo) continue;
            try
            {
                info += $"\n\t{empleado}";
                
            }
            catch (NoDatabaseFound e)
            {
                info += $"\n\t{e.Message}";
            }
            info += empleado.AplicacionMensajeria.EnviarMensaje("Ningunas vacaciones...");
        }
        return info ;
    }
}