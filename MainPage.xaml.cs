namespace MAUIAPP;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

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
            Margin = 30,
            Text = "Boton3",
            IsVisible = true,
            IsEnabled = true
        };
        Boton3.Clicked += Boton3_Clicked;
        layout.Children.Add(Boton3);
        Boton2.Clicked -= Boton2_Clicked;

    }




    private void Boton3_Clicked(object sender, EventArgs e)
    {
        Boton1.IsVisible = false;
        Boton2.Text = "Crear controles en tiempo de ejecución mola";

    }
}


