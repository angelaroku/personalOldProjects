using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1SocialLink
{
    public sealed partial class ComunidadSinUsuarioPage : Page
    {
        public ComunidadSinUsuarioPage()
        {
            this.InitializeComponent();
        }


        //metodo para volver atras
        private void Button_Atras(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EntradaSinUsuarioPage));

        }
    }
}