using ConversorDeMonedasMAUI.Modelos;

namespace ConversorDeMonedasMAUI.Paginas;

public partial class PaginaListadoUsuarios : ContentPage
{
	public GestorUsuario GestorUsuario { get; set; } = new GestorUsuario();

	public PaginaListadoUsuarios()
	{
		InitializeComponent();

        lvwListadoUsuarios.ItemsSource = GestorUsuario.Usuarios;
    }
}