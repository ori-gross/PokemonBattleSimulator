using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PokemonBattleSimulator.Commands;
using PokemonBattleSimulator.Views;

namespace PokemonBattleSimulator.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand OpenBattleWindowCommand { get; set; }
        public ICommand OpenTrainerSetupWindowCommand { get; set; }
        public ICommand OpenAboutWindowCommand { get; set; }

        public MainViewModel()
        {
            OpenBattleWindowCommand = new RelayCommand(OpenBattleWindow);
            OpenTrainerSetupWindowCommand = new RelayCommand(OpenTrainerSetupWindow);
            OpenAboutWindowCommand = new RelayCommand(OpenAboutWindow);
        }

        private void OpenBattleWindow(object obj)
        {
            BattleWindow battleWindow = new BattleWindow();
            battleWindow.Show();
        }

        private void OpenTrainerSetupWindow(object obj)
        {
            TrainerSetupWindow trainerSetupWindow = new TrainerSetupWindow();
            trainerSetupWindow.Show();
        }

        private void OpenAboutWindow(object obj)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
        }
    }
}
