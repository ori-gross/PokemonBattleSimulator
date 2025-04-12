using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Enums;

namespace PokemonBattleSimulator.Models.Entities
{
    public class PokemonMove
    {
        private string _name;
        private PokemonType _type;
        private MoveCategory _category;
        private int _power;
        private int? _accuracy; // null means "always hits"
        private int _pp;
        private string _description;

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

        public PokemonType Type
        {
            get { return _type; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Type cannot be null.");
                }
                _type = value;
            }
        }

        public MoveCategory Category
        {
            get { return _category; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Category cannot be null.");
                }
                _category = value;
            }
        }

        public int Power
        {
            get { return _power; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Power cannot be negative.");
                }
                _power = value;
            }
        }

        public int? Accuracy
        {
            get { return _accuracy; }
            set
            {
                if (value != null && (value < 0 || value > 100))
                {
                    throw new ArgumentOutOfRangeException("Accuracy must be between 0 and 100, or null for always hits.");
                }
                _accuracy = value;
            }
        }

        public int PP
        {
            get { return _pp; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("PP cannot be negative.");
                }
                _pp = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Description cannot be null or empty.");
                }
                _description = value;
            }
        }

        public PokemonMove(string name, PokemonType type, MoveCategory category, int power, int accuracy, int pp, string description)
        {
            Name = name;
            Type = type;
            Category = category;
            Power = power;
            Accuracy = accuracy;
            PP = pp;
            Description = description;
        }
    }
}
