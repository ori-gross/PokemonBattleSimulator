using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Entities;
using PokemonBattleSimulator.Services;

namespace PokemonBattleSimulator.ViewModels
{
    public class AttackdexViewModel : ViewModelBase
    {
        public ObservableCollection<PokemonMove> MoveList { get; set; }

        public AttackdexViewModel()
        {
            // Load data using the service
            var moves = PokemonMovesService.LoadPokemonMoves("Resources/Data/PokemonMoves.json");
            MoveList = new ObservableCollection<PokemonMove>(moves);
        }
    }
}
