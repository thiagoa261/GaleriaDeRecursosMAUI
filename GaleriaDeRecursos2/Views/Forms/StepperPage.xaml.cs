namespace GaleriaDeRecursos2.Views.Forms;

public partial class StepperPage : ContentPage
{
	public StepperPage()
	{
		InitializeComponent();
	}

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {

    }

    private void Stepper_ValueChanged_1(object sender, ValueChangedEventArgs e)
    {
        lblValue.Text = "Antes: " + e.OldValue + " | " +
            "Agora: " + e.NewValue;
    }
}