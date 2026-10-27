using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1SocialLink.Components
{
    public sealed partial class NuevaCosa : UserControl
    {
        /// <summary>
        /// Elemento cabecera de un perfil (rehutilizable)
        /// </summary>
        public NuevaCosa()
        {
            this.InitializeComponent();
        }
        //estaas variables las hemos bblindeau en el .aml
        public string csTextoDeMiNuevaCosa
        {
            get;
            set;
        }
        public Symbol csNuevoIconoNuevaCosa
        {
            get ;
            set ;
        }

        public Color csBackgroundColor
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);

        }

        //YA NO NECESITAMOS EL DPENDENCY, YA QUE USAMOS EL X:BLIND en nuestro textoooooo
        private static readonly DependencyProperty TitleProperty =
          DependencyProperty.Register(nameof(csTextoDeMiNuevaCosa), typeof(string), typeof(NuevaCosa), new PropertyMetadata(string.Empty, OnTitleChanged));
        
        //YA NO NECESITAMOS EL DPENDENCY, YA QUE USAMOS EL X:BLIND en nuestra Nueva Cosa
        private static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(csNuevoIconoNuevaCosa), typeof(Symbol), typeof(NuevaCosa), new PropertyMetadata(Symbol.Account, OnIconChanged));

        private static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register(nameof(csBackgroundColor), typeof(Color), typeof(NuevaCosa), new PropertyMetadata(string.Empty, OnBackgroundColorChanged));


        private static void OnTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (NuevaCosa)d;

            if ((string)e.NewValue != "")
            {
                control.Visibility = Visibility.Visible;
                control.TagTextBlock.Text = (string)e.NewValue;
            }
            else
            {
                control.Visibility = Visibility.Collapsed;
            }
        }
        //este callback del Icono tampoco nos hace falta ya
        
        private static void OnIconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (NuevaCosa)d;

            control.TagIcon.Visibility = Visibility.Visible;
            control.TagIcon.Symbol = (Symbol)e.NewValue;
        }

        private static void OnBackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (NuevaCosa)d;
            control.TagBorder.Background = new SolidColorBrush((Color)e.NewValue);
        }

    }

}