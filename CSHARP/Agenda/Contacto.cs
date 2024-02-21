public class Contacto(string nombre, string? telefono, string? correo)
{
    public string Nombre { get; set; } = nombre;
    public string? Telefono { get; set; } = telefono;
    public string? Correo { get; set; } = correo;

    public override string ToString()
    {
        string infoTelefono = Telefono?.ToString() ?? "Sin teléfono";
        string infoCorreo = Correo?.ToString() ?? "Sin correo";

        return $"{Nombre} - Teléfono: {infoTelefono} - Email: {infoCorreo}";
    }
}

