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
    }
}