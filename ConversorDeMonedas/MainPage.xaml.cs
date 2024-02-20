namespace ConversorDeMonedas
{
    public partial class MainPage : ContentPage
    {
        int _count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;

            if (_count == 1)
                CounterBtn.Text = $"Se ha clicado {_count} vez";
            else
                CounterBtn.Text = $"Se ha clicado {_count} veces";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
