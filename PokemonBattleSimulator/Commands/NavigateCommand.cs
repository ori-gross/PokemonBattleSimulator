using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Stores;
using PokemonBattleSimulator.ViewModels;

namespace PokemonBattleSimulator.Commands
{
    public class NavigateCommand : RelayCommand
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<ViewModelBase> _createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<ViewModelBase> createViewModel) : base(execute: _ => navigationStore.CurrentViewModel = createViewModel(), canExecute: null)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        //public override bool CanExecute(object? parameter)
        //{
        //    return true; // Always allow navigation
        //}

        public override void Execute(object? parameter)
        {
            // Create a new instance of the ViewModel and set it as the current ViewModel
            _navigationStore.CurrentViewModel = _createViewModel();
            // Notify that the current ViewModel has changed
        }
    }
}
