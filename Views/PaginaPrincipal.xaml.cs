using SmartTradeFrontend.ViewModels;
using SmartTradeFrontend.Services;

namespace SmartTradeFrontend.Views;

public partial class PaginaPrincipal : ContentPage
{
	public PaginaPrincipal()
	{
		InitializeComponent();
		var viewModel = new PaginaPrincipalViewModel(new SmartTradeServices(), Navigation);
		BindingContext = viewModel;
	}
}