namespace GaleriaDeRecursos2.Views.Components;

public partial class ImageButtonPage : ContentPage
{
	bool estado = false;
	public ImageButtonPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		estado = !estado;
		var ligado = "poweron.png";
		var desligado = "poweroff.png";

		var botao = (ImageButton)sender;

		if(estado==false)
		{
			botao.Source = ImageSource.FromFile(desligado);
		} else {
            botao.Source = ImageSource.FromFile(ligado);
        }
    }
}