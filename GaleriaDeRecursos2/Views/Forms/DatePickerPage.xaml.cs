namespace GaleriaDeRecursos2.Views.Forms;

public partial class DatePickerPage : ContentPage
{
	public DatePickerPage()
	{
		InitializeComponent();
	}

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
		lblValue.Text = e.NewDate.ToString();
    }
}