namespace MAUIAPP;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}


    /// <summary>
    /// Método que se encarga de generar el boton 3 una vez que se ha clicado el boton 2
    /// y añadirlo al layout
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Boton2_Clicked(object sender, EventArgs e)
    {
        Button Boton3 = new Button
        {
            FontAutoScalingEnabled = true,
            BackgroundColor = Colors.Blue,
            HeightRequest = 70,
            WidthRequest = 200,
            FontFamily = "verdana",
            FontAttributes = FontAttributes.Bold,
            FontSize = 16,
            BorderColor = Colors.Yellow,
            BorderWidth = 5,
            Margin = 30,
            Text = "Boton3",
            IsVisible = true,
            IsEnabled = true
        };
        Boton3.Clicked += Boton3_Clicked;
        layout.Children.Add(Boton3);
        Boton2.Clicked -= Boton2_Clicked;

    }



    /// <summary>
    /// Método que se encarga de hacer el boton1 invisible 
    /// y cambiar el text del boton2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Boton3_Clicked(object sender, EventArgs e)
    {
        Boton1.IsVisible = false;
        Boton2.Text = "Crear controles en tiempo de ejecución mola";
        Boton2.WidthRequest = 500;

    }
}


