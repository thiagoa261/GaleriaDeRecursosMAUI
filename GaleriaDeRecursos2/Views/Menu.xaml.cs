using GaleriaDeRecursos2.Repositories;

namespace GaleriaDeRecursos2.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
		var categories = new CategoryRepository().GetCategories();

		//Buscar infos das categorias
		foreach(var category in categories)
		{
			//Nome
			var lblCategory = new Label();
			lblCategory.Text = category.Name;
			lblCategory.FontFamily = "OpenSansSemibold";
            MenuContainer.Children.Add(lblCategory);

            //Membros das categorias
            foreach (var component in category.Components)
			{
				var tap = new TapGestureRecognizer();
				tap.CommandParameter = component.Page;
				tap.Tapped += OnTapComponent;

                var lblComponentTitle = new Label();
                lblComponentTitle.Text = component.Title;
                lblComponentTitle.FontFamily = "OpenSansSemibold";
				lblComponentTitle.Margin = new Thickness(20,20,0,0);
				lblComponentTitle.GestureRecognizers.Add(tap);

                var lblComponentDescription = new Label();
                lblComponentDescription.Text = component.Description;
                lblComponentDescription.Margin = new Thickness(20, 0, 0, 0);
                lblComponentDescription.GestureRecognizers.Add(tap);

                MenuContainer.Children.Add(lblComponentTitle);
                MenuContainer.Children.Add(lblComponentDescription);
            }
		}
	}

	private void OnTapComponent(object sender, EventArgs e)
	{
		//Sender é o componente tocado/clicado
		var texto = (Label)sender;

		var tap = (TapGestureRecognizer)texto.GestureRecognizers[0];
		var page = (Type)tap.CommandParameter;
		//((FlyoutPage)App.Current.MainPage).Detail = (Page)Activator.CreateInstance(page);
		((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
		((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }

    private void OnTapInicio(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = 
			new NavigationPage(new GaleriaDeRecursos2.Views.Principal());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}