using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Entities
{
    public class LearnableMoveSet
    {
        private List<LearnableMove> _learnableMoves;

        public List<LearnableMove> LearnableMoves
        {
            get { return _learnableMoves; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Learnable moves cannot be null.");
                }
                _learnableMoves = value;
            }
        }

        public LearnableMoveSet()
        {
            _learnableMoves = new List<LearnableMove>();
        }
    }
}
