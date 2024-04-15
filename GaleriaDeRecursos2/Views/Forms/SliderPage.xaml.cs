namespace GaleriaDeRecursos2.Views.Forms;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

    private void Slider_DragStarted(object sender, EventArgs e)
    {
        lblStatus.Text = "Início do movimento";
    }

    private void Slider_DragCompleted(object sender, EventArgs e)
    {
        lblStatus.Text = "Movimento completo";
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblValue.Text = e.NewValue.ToString();
    }
}