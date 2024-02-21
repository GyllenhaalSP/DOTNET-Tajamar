namespace Excepcion;

public class ExcepcionPersonalizada: Exception
{
    public string Archivo;
    public DateTime FechaHoraExcepcion { get; set; }

    public ExcepcionPersonalizada()
    {
    }

    public ExcepcionPersonalizada(string mensaje, DateTime fechaHoraExcepcion, string archivo) : base(mensaje)
    {
        Archivo = archivo;
        FechaHoraExcepcion = fechaHoraExcepcion;
    }
}

