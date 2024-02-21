public class Agenda
{
    private List<Contacto> contactos = new List<Contacto>();

    public void AgregarContacto(Contacto contacto)
    {
        contactos.Add(contacto);
    }

    public void MostrarContactos()
    {
        foreach (var contacto in contactos)
        {
            Console.WriteLine(contacto);
        }
    }

    public void BuscarContacto(string nombre)
    {
        var contacto = contactos.FirstOrDefault(c => string.Equals(c.Nombre, nombre));
        if (contacto != null)
        {
            Console.WriteLine(contacto);
        }
        else
        {
            Console.WriteLine("Contacto no encontrado");
        }
    }
}