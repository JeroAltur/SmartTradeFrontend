using SmartTradeFrontend.Services;
using SmartTradeFrontend.ViewModels;

namespace SmartTradeFrontend.Views;

public partial class PaginaBuscador : ContentPage
{
	public PaginaBuscador(string textoBusqueda)
	{

		InitializeComponent();
		var viewModel = new PaginaBuscadorViewModel(new SmartTradeServices(), Navigation, textoBusqueda); ;
		BindingContext = viewModel;
	}
	
}