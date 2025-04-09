using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Entities
{
    public class LearnableMove
    {
        private PokemonMove _move;
        private int _level;

        public PokemonMove Move
        {
            get { return _move; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Move cannot be null.");
                }
                _move = value;
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Level must be greater than 0.");
                }
                _level = value;
            }
        }

        public LearnableMove(PokemonMove move, int level)
        {
            Move = move;
            Level = level;
        }
    }
}
