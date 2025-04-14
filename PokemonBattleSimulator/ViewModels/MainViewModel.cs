﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using PokemonBattleSimulator.Commands;
using PokemonBattleSimulator.Views;

namespace PokemonBattleSimulator.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private double _volume = 1.0;
        public double Volume
        {
            get => _volume;
            set
            {
                if (_volume != value)
                {
                    _volume = value;
                    IsMuted = _volume == 0;
                    OnPropertyChanged();
                    UpdateMediaVolume();
                }
            }
        }

        private bool _isMuted = false;
        public bool IsMuted
        {
            get => _isMuted;
            set
            {
                _isMuted = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(MuteButtonText));
                UpdateMediaVolume();
            }
        }

        public string MuteButtonText => IsMuted ? "Unmute" : "Mute";

        public ICommand OpenBattleWindowCommand { get; set; }
        public ICommand OpenTrainerSetupWindowCommand { get; set; }
        public ICommand OpenAboutWindowCommand { get; set; }
        public ICommand OpenPokedexWindowCommand { get; set; }

        public ICommand ToggleMuteCommand { get; }

        public MainViewModel()
        {
            OpenBattleWindowCommand = new RelayCommand(OpenBattleWindow);
            OpenTrainerSetupWindowCommand = new RelayCommand(OpenTrainerSetupWindow);
            OpenAboutWindowCommand = new RelayCommand(OpenAboutWindow);
            OpenPokedexWindowCommand = new RelayCommand(OpenPokedexWindow);

            ToggleMuteCommand = new RelayCommand(_ => IsMuted = !IsMuted);
        }

        private void OpenBattleWindow(object obj)
        {
            BattleWindow battleWindow = new BattleWindow();
            battleWindow.Owner = Application.Current.MainWindow;
            battleWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            battleWindow.Show();
        }

        private void OpenTrainerSetupWindow(object obj)
        {
            TrainerSetupWindow trainerSetupWindow = new TrainerSetupWindow();
            trainerSetupWindow.Owner = Application.Current.MainWindow;
            trainerSetupWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            trainerSetupWindow.Show();
        }

        private void OpenAboutWindow(object obj)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Owner = Application.Current.MainWindow;
            aboutWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            aboutWindow.Show();
        }

        private void OpenPokedexWindow(object obj)
        {
            PokedexWindow pokedexWindow = new PokedexWindow();
            pokedexWindow.Owner = Application.Current.MainWindow;
            pokedexWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            pokedexWindow.Show();
        }

        private void UpdateMediaVolume()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                var main = Application.Current.MainWindow as MainWindow;
                if (main != null && main.BackgroundMusic != null)
                {
                    main.BackgroundMusic.Volume = IsMuted ? 0 : Volume;
                }
            });
        }
    }
}
