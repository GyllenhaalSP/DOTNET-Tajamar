using ConversorMonedasMVVM.MVVM.ViewModels;

namespace ConversorMonedasMVVM.MVVM.Views;

public partial class ListaMonedas : ContentPage
{
	public ListaMonedas()
	{
		InitializeComponent();
        BindingContext = new ListaMonedasVM();
    }

	private async void BtnVolverClicked(object sender, EventArgs e)
	{
        await Navigation.PopAsync();
    }
}