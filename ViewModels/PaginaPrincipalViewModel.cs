using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartTradeFrontend.Models;
using SmartTradeFrontend.Views;
using SmartTradeFrontend.Services;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
//using UIKit;

namespace SmartTradeFrontend.ViewModels
{
    internal partial class PaginaPrincipalViewModel : ObservableObject
    {
        private readonly SmartTradeServices _dataService;
        private readonly INavigation _navigation;

        public ObservableCollection<Producto> Tendencias { get; }
        public ObservableCollection<Producto> MejorValorados { get; }
        public ObservableCollection<Producto> CompradosPorIronMan { get; }
        public ICommand SearchCommand { get; private set; }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set { SetProperty(ref _searchText, value); }
        }

        public PaginaPrincipalViewModel() { 
        }


        public PaginaPrincipalViewModel(SmartTradeServices dataService, INavigation navigation)
        {
            _dataService = dataService;
            _navigation = navigation;

            //Inicializamos las colecciones
            Tendencias = new ObservableCollection<Producto>();

            Tendencia();

            /*MejorValorados = new ObservableCollection<Producto>(dataService.MejorValorado());
            CompradosPorIronMan = new ObservableCollection<Producto>(dataService.CompradosPorIronman());*/

            SearchCommand = new RelayCommand(ExecuteSearch);
        }

        public async void Tendencia()
        {
            List<Producto> result = await _dataService.Tendencias();

            if (result != null && result.Count > 0)
            {
                foreach (var item in result)
                {
                    Tendencias.Add(item);
                }
            }
        }

        private async void ExecuteSearch()
        {
            string searchTerm = SearchText;
            await _navigation.PushAsync(new PaginaBuscador(searchTerm));
        }

    }
}
