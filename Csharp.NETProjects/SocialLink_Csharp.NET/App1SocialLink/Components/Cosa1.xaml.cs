using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;


namespace App1SocialLink.Components
{
    public sealed partial class Cosa1 : UserControl
    {
        /// <summary>
        /// Elemento publicación (rehutilizable)
        /// </summary>
        public Cosa1()
        {
            this.InitializeComponent();
        }

        //3. - RELACIONAR VARIABLES estaas variables no se ven
        public string csdescripcion 
        {
            get => (string)GetValue(descripcionProperty);
            set => SetValue(descripcionProperty, value);
        }
        public string csnombre
        {
            get => (string)GetValue(nombreProperty);
            set => SetValue(nombreProperty, value);
        }
        
        public double csprecio
        {
            get;
            set;
        }





        //1. - variable que quiero exponer -- EXPONER VARIABLES
        private static readonly DependencyProperty nombreProperty =
            DependencyProperty.Register(nameof(csnombre),
                                typeof(string), 
                                typeof(Cosa1),
                                new PropertyMetadata(string.Empty, OnNameChanged)); //valor por defecto + evento (callback)

        private static readonly DependencyProperty descripcionProperty =
            DependencyProperty.Register(nameof(csdescripcion),
                                typeof(string),
                                typeof(Cosa1),
                                new PropertyMetadata(string.Empty, OnNameChangedDescripcion));

                

        //2. - LO QUE QUIERO QUE HAGA 
        private static void OnNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) 
        { //d es mi tarjeta mi cosa1
            Cosa1 customCard = (Cosa1)d;
            //customCard.csnombre;  cambias la variable cs, esto puede producir un bucle infinito

            customCard.Temática_publicacion.Text = (string)e.NewValue; //cambiando la propiedad de la plantilla .xaml

        }

        private static void OnNameChangedDescripcion(DependencyObject d, DependencyPropertyChangedEventArgs e)
        { //d es mi tarjeta mi cosa1
            Cosa1 customCard = (Cosa1)d;
            //customCard.csnombre;  cambias la variable cs, esto puede producir un bucle infinito

            customCard.Descripcion.Text = (string)e.NewValue; //cambiando la propiedad de la plantilla .xaml

        }


        

    }
}