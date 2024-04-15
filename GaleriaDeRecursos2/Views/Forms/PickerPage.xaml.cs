namespace GaleriaDeRecursos2.Views.Forms;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var componente = ((Picker)sender);
		string nomeTipo = componente.SelectedItem.ToString();
		lblValue.Text = nomeTipo;
    }
}