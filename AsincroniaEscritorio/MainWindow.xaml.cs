using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsincroniaEscritorio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WriteLine.Text = "BIENVENIDO AL GESTOR DE DESCARGAS\nMÁS INEFICIENTE DEL UNIVERSO";
            WriteLine.TextAlignment = TextAlignment.Center;
            WriteLine.FontSize = 32;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            WriteLine.TextAlignment = TextAlignment.Left;
            WriteLine.FontSize = 16;
            WriteLine.Text = "Bloqueo del Thread con Thread.Sleep...";
            await Task.Delay(1000);
            TareaLargaDuracion();
            WriteLine.Text = "Bloqueo finalizado.";
            await Task.Delay(1000);
            WriteLine.Text = "Iniciando descarga de larga duración...";
            await Task.Delay(1000);
            await SimularDescarga("https://www.downloadmoreram.com");
            await Task.Delay(1000);
            WriteLine.Text = "Procesos finalizados.";
        }

        public static void TareaLargaDuracion()
        {
            Thread.Sleep(5000);
        }

        async Task SimularDescarga(string url)
        {
            await Task.Delay(1000);
            WriteLine.Text = $"Iniciando descarga desde \n{url}...";
            await Task.Delay(5000);
            WriteLine.Text = $"Descarga finalizada desde\n{url}.";
            await Task.Delay(1000);
        }
    }
}