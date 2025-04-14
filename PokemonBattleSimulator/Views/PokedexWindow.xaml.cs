using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PokemonBattleSimulator.ViewModels;

namespace PokemonBattleSimulator.Views
{
    /// <summary>
    /// Interaction logic for PokedexWindow.xaml
    /// </summary>
    public partial class PokedexWindow : Window
    {
        public PokedexWindow()
        {
            InitializeComponent();
            PokedexViewModel viewModel = new PokedexViewModel();
            this.DataContext = viewModel;
        }
    }
}
