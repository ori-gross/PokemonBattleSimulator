using System.Configuration;
using System.Data;
using System.Windows;
using PokemonBattleSimulator.Commands;
using PokemonBattleSimulator.Stores;
using PokemonBattleSimulator.ViewModels;

namespace PokemonBattleSimulator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //var navigationStore = new NavigationStore();

            // Create the navigation commands
            //var pokedexNav = new NavigateCommand(navigationStore, () => new PokedexViewModel());

            // Initialize the navigation store with the initial view model
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore, CreatePokedexViewModel, CreateItemdexViewModel);

            //var homeVm = new HomeViewModel(pokedexNav, _navigationStore);

            // Set the main window
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
        }

        private PokedexViewModel CreatePokedexViewModel()
        {
            return new PokedexViewModel();
        }

        private ItemdexViewModel CreateItemdexViewModel()
        {
            return new ItemdexViewModel();
        }
    }
}
