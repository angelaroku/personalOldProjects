using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace App1SocialLink.Components
{
    public sealed partial class OtraCosaMas : UserControl
    {
        /// <summary>
        /// Elemento descriptivo de cada publicacion, comentarios, compartir(rehutilizable)
        /// </summary>
        public OtraCosaMas()
        {
            this.InitializeComponent();
        }

        public Symbol IconoNuevaCosa1 { get; set; }

        public Symbol  IconoNuevaCosa2 { get; set; }
        
        public Symbol IconoNuevaCosa3{ get; set; }

        public Symbol IconoNuevaCosa4 { get; set; }

        public Symbol IconoNuevaCosa5 { get; set; }


        private static readonly DependencyProperty IconProperty =
        DependencyProperty.Register(nameof(IconoNuevaCosa1), typeof(Symbol),
            typeof(NuevaCosa), new PropertyMetadata(Symbol.Favorite, OnIconChanged));

        private static readonly DependencyProperty IconProperty2 =
        DependencyProperty.Register(nameof(IconoNuevaCosa2), typeof(Symbol),
            typeof(NuevaCosa), new PropertyMetadata(Symbol.Favorite, OnIconChanged));

        private static readonly DependencyProperty IconProperty3 =
        DependencyProperty.Register(nameof(IconoNuevaCosa3), typeof(Symbol),
            typeof(NuevaCosa), new PropertyMetadata(Symbol.Favorite, OnIconChanged));

        private static readonly DependencyProperty IconProperty4 =
        DependencyProperty.Register(nameof(IconoNuevaCosa4), typeof(Symbol),
            typeof(NuevaCosa), new PropertyMetadata(Symbol.Favorite, OnIconChanged));

        private static readonly DependencyProperty IconProperty5 =
        DependencyProperty.Register(nameof(IconoNuevaCosa4), typeof(Symbol),
            typeof(NuevaCosa), new PropertyMetadata(Symbol.Favorite, OnIconChanged));

        private static readonly DependencyProperty IconProperty6 =
        DependencyProperty.Register(nameof(IconoNuevaCosa5), typeof(Symbol),
            typeof(NuevaCosa), new PropertyMetadata(Symbol.Favorite, OnIconChanged));


        //estaas variables las hemos bblindeau en el .aml
        //public string TextoDeMiNuevaCosa { get; set; }
        //public Symbol NuevoIconoNuevaCosa { get; set; }

        //        public Color BackgroundColor {  get => (Color)GetValue(ColorProperty);  set => SetValue(ColorProperty, value); }

        //YA NO NECESITAMOS EL DPENDENCY, YA QUE USAMOS EL X:BLIND en nuestro textoooooo
        //ivate static readonly DependencyProperty TitleProperty =
        //DependencyProperty.Register(nameof(Title), typeof(string), typeof(NuevaCosa), new PropertyMetadata(string.Empty, OnTitleChanged));

        //YA NO NECESITAMOS EL DPENDENCY, YA QUE USAMOS EL X:BLIND en nuestra Nueva Cosa
        //private static readonly DependencyProperty IconProperty =
        //DependencyProperty.Register(nameof(NuevoIconoNuevaCosa), typeof(Symbol), typeof(NuevaCosa), new PropertyMetadata(Symbol.Emoji, OnIconChanged));

        //COMENTAUUUU
        //private static readonly DependencyProperty ColorProperty =
        //   DependencyProperty.Register(nameof(BackgroundColor), typeof(Color), typeof(NuevaCosa), new PropertyMetadata(string.Empty, OnBackgroundColorChanged));

        /* mAS COMENTAU
        private static void OnTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (NuevaCosa)d;

            if ((string)e.NewValue != "")
            {
                control.Visibility = Visibility.Visible;
               // control.TagTextBlock.Text = (string)e.NewValue;
            }
            else
            {
                control.Visibility = Visibility.Collapsed;
            }
        }
        */


        private static void OnIconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (NuevaCosa)d;
        }


        /*
        private static void OnBackgroundColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (NuevaCosa)d;
            //control.TagBorder.Background = new SolidColorBrush((Color)e.NewValue);
        }
        */
    }

}