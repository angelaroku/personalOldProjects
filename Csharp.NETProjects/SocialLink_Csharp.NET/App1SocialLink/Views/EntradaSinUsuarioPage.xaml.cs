using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1SocialLink
{
    /// <summary>
    /// Página para entrar sin usuario.
    /// </summary>
    public sealed partial class EntradaSinUsuarioPage : Page
    {
        public EntradaSinUsuarioPage()
        {
            this.InitializeComponent();
        }


        //metodo para volver al inicio
        private void Button_Atras(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));

        }


        //metodo para acceder al espacio comunidad con restricciones
        private void Button_ComunidadSinUsuario(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ComunidadSinUsuarioPage));

        }
    }
}
