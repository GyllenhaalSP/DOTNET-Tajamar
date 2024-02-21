using Pagos;

Console.OutputEncoding = System.Text.Encoding.UTF8;

IPago pagoConTarjeta = new PagoConTarjeta();
IPago pagoConPaypal = new PagoConPayPal();
IPago pagoConTransferencia = new PagoConTransferencia();

RealizarPago(pagoConTarjeta, 100m);
RealizarPago(pagoConPaypal, 200m);
RealizarPago(pagoConTransferencia, 300m);

static void RealizarPago(IPago pasarela, decimal total)
{
    if (pasarela.ProcesarPago(total))
    {
        Console.WriteLine($"Pago procesado con {pasarela.Servicio} por {total:C}");
    }
    else
    { 
        Console.WriteLine("Error");
    }

    if (pasarela.VerificarPago())
    {
        Console.WriteLine($"Pago verificado\n");
    }
    else
    {
        Console.WriteLine("Error");
    }
}