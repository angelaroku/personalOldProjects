using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1SocialLink
{
    public sealed partial class CrearNuevoUsuarioPage : Page
    {
        public CrearNuevoUsuarioPage()
        {
            this.InitializeComponent();
        }


        //metodo para volver al inicio
        private void Button_Atras(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));

        }




    }

    
}
