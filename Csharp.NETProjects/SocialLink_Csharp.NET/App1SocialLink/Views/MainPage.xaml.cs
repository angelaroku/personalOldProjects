using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1SocialLink
{
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Pagina principal inicial
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();
        }


        //Eventos navigate en cada boton para cambiar de pagina
        private void Button_EntradaConUsuario_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EntradaConUsuarioPage));
        }

        private void Button_EntradaSinUsuario_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (EntradaSinUsuarioPage));
        }

        private void Button_CrearNuevoUsuario_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CrearNuevoUsuarioPage));

        }
    }
}
