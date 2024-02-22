using ConversorDeMonedasMAUI.Modelos;

namespace ConversorDeMonedasMAUI.Paginas;

public partial class PaginaListadoMonedas : ContentPage
{
    public GestorMonedas gestorMonedas { get; set; } = new GestorMonedas();

    public PaginaListadoMonedas()
    {
        InitializeComponent();

        lvwListadoMonedas.ItemsSource = gestorMonedas.Monedas;

    }
}   