namespace ConversorMonedasMVVM.MVVM.Views;

public partial class ListaMonedas : ContentPage
{
	public ListaMonedas()
	{
		InitializeComponent();
	}

	private async void BtnVolverClicked(object sender, EventArgs e)
	{
        await Navigation.PopAsync();
    }
}