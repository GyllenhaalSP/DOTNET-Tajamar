using ConversorDeMonedasMAUI.Paginas;

namespace ConversorDeMonedasMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBtnListaMonedasClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaListadoMonedas());
        }

        private void OnBtnConvertirMonedasClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaConversionMonedas());
        }

        private void OnBtnListaDeUsuariosClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaListadoUsuarios());
        }

        private void OnBtnSalirClicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}