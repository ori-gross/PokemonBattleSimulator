using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Commands;
using PokemonBattleSimulator.Stores;

namespace PokemonBattleSimulator.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

            //ShowPokedexCommand = new RelayCommand(_ =>_navigationStore.CurrentViewModel = new PokedexViewModel());
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
        //public void ChangeViewModel(ViewModelBase newViewModel)
        //{
        //    CurrentViewModel = newViewModel;
        //    OnPropertyChanged(nameof(CurrentViewModel));
        //}
    }
}
