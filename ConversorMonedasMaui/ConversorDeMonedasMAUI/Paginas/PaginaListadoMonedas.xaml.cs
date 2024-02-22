using ConversorDeMonedasMAUI.Modelos;

namespace ConversorDeMonedasMAUI.Paginas;

public partial class PaginaListadoMonedas : ContentPage
{
    public GestorMoneda GestorMonedas { get; set; } = new GestorMoneda();

    public PaginaListadoMonedas()
    {
        InitializeComponent();

        lvwListadoMonedas.ItemsSource = GestorMonedas.Monedas;
    }
}   