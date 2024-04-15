namespace GaleriaDeRecursos2.Views.Forms;

public partial class SwitchPage : ContentPage
{
	public SwitchPage()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		lblStatus.Text = e.Value.ToString();
    }
}