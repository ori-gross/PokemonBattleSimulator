using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PokemonBattleSimulator.ViewModels;

namespace PokemonBattleSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer _backgroundMusic = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
            MainViewModel viewModel = new MainViewModel();
            this.DataContext = viewModel;

            //PlayBackgroundMusic();
        }

        private void BackgroundMusic_MediaEnded(object sender, RoutedEventArgs e)
        {
            BackgroundMusic.Position = TimeSpan.Zero;
            BackgroundMusic.Play();
        }
    }
}