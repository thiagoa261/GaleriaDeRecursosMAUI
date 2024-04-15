namespace GaleriaDeRecursos2.Views.Forms;

public partial class EntryPage : ContentPage
{
	public EntryPage()
	{
		InitializeComponent();
	}

    private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
    {
		lblText.Text = "Antes: " + e.OldTextValue + " / Depois: "
			+ e.NewTextValue;
    }

    private void txtNome_Completed(object sender, EventArgs e)
    {
        lblText.Text = "Concluído";
    }
}