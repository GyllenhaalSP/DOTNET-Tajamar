using ConversorMonedasMVVM.MVVM.Views;

namespace ConversorMonedasMVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnConvertirClicked(object sender, EventArgs e)
        {
            //Ir a la página del conversor
        }

        private async void BtnVerListaClicked(object sender, EventArgs e)
        {
            //Ir a la página de lista de monedas
            await Navigation.PushAsync(new ListaMonedas());
        }

        private void BtnHistorialClicked(object sender, EventArgs e)
        {
            //Ir a la página de historial
        }
    }
}
