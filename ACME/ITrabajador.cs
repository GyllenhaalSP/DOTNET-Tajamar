namespace ACME
{
    public interface ITrabajador
    {
        string Nombre { get; set; }
        Empresa Empresa { get; set; }
        IMensajeria AplicacionMensajeria { get; set; }
        int CalcularDiasVacaciones();
    }
}
