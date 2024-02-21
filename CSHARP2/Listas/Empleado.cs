namespace Listas;
public class Empleado(int id, string nombre, string departamento)
{
    public int Id { get; set; } = id;
    public string Nombre { get; set; } = nombre;
    public string Departamento { get; set; } = departamento;

    public override string ToString()
    {
        return $"ID: {Id}, {Nombre}, Dpt: {Departamento}";
    }
}