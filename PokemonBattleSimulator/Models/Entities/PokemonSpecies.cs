using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Enums;

namespace PokemonBattleSimulator.Models.Entities
{
    public class PokemonSpecies
    {
        private string _name;
        private int _pokedexNumber;
        private PokemonType _type1;
        private PokemonType _type2;
        private PokemonStats _baseStats;
        private LearnableMoveSet _learnableMoves;
        private PokemonSpriteSet _sprites;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                _name = value;
            }
        }

        public int PokedexNumber
        {
            get { return _pokedexNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Pokedex number must be greater than zero.");
                }
                _pokedexNumber = value;
            }
        }

        public PokemonType Type1
        {
            get { return _type1; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Type1 cannot be null.");
                }
                _type1 = value;
            }
        }

        public PokemonType Type2
        {
            get { return _type2; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Type2 cannot be null.");
                }
                _type2 = value;
            }
        }

        public PokemonStats BaseStats
        {
            get { return _baseStats; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "BaseStats cannot be null.");
                }
                _baseStats = value;
            }
        }

        public LearnableMoveSet LearnableMoves
        {
            get { return _learnableMoves; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "LearnableMoves cannot be null.");
                }
                _learnableMoves = value;
            }
        }

        public PokemonSpriteSet Sprites
        {
            get { return _sprites; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Sprites cannot be null.");
                }
                _sprites = value;
            }
        }

        public PokemonSpecies(string name, int pokedexNumber, PokemonType type1, PokemonType type2, PokemonStats baseStats, LearnableMoveSet learnableMoves, PokemonSpriteSet sprites)
        {
            Name = name;
            PokedexNumber = pokedexNumber;
            Type1 = type1;
            Type2 = type2;
            BaseStats = baseStats;
            LearnableMoves = learnableMoves;
            Sprites = sprites;
        }
    }
}
