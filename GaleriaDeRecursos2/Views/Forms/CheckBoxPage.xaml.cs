namespace GaleriaDeRecursos2.Views.Forms;

public partial class CheckBoxPage : ContentPage
{
	public CheckBoxPage()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		lblStatus.Text = e.Value.ToString();
    }
}