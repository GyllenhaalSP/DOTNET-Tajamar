namespace ConversorDeMonedasMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnListaMonedasClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaDeMonedas());
        }
    }
}