using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Entities;
using PokemonBattleSimulator.Services;

namespace PokemonBattleSimulator.ViewModels
{
    public class PokedexViewModel : ViewModelBase
    {
        public ObservableCollection<PokemonSpecies> PokemonSpeciesList { get; set; }

        public PokedexViewModel()
        {
            // Load data using the service
            var species = PokemonSpeciesService.LoadSpecies("Resources/Data/PokemonSpecies.json");
            PokemonSpeciesList = new ObservableCollection<PokemonSpecies>(species);
        }
    }
}
