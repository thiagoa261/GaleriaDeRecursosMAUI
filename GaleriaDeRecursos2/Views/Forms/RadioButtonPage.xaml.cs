namespace GaleriaDeRecursos2.Views.Forms;

public partial class RadioButtonPage : ContentPage
{
	public RadioButtonPage()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (((RadioButton)sender).Content.ToString() == "Masculino")
        {
            lblResultado.Text = "Masculino selecionado";
        } else
        {
            lblResultado.Text = "Outra opção selecionada";
        }
    }
}