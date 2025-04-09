using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Entities
{
    public class MoveSet
    {
        private List<PokemonMove> _moves;
        private const int MaxMoves = 4;

        public List<PokemonMove> Moves
        {
            get { return _moves; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Moves cannot be null.");
                }
                if (value.Count > MaxMoves)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "A Pokemon can only have up to 4 moves.");
                }
                _moves = value;
            }
        }
        public MoveSet()
        {
            _moves = new List<PokemonMove>(MaxMoves);
        }
    }
}
