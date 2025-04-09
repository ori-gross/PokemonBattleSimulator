using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Enums;

namespace PokemonBattleSimulator.Models.Entities
{
    public class Pokemon
    {
        private PokemonSpecies _species;
        private Gender _gender;
        private int _level;
        private PokemonStats _stats;
        private MoveSet _moveSet;
        private StatusConditionSet _statusConditions;
        private StatModifiers _statModifiers;

        public PokemonSpecies Species
        {
            get { return _species; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Species cannot be null.");
                }
                _species = value;
            }
        }

        public Gender Gender
        {
            get { return _gender; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Gender cannot be null.");
                }
                _gender = value;
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Level must be greater than 0.");
                }
                _level = value;
            }
        }

        public PokemonStats Stats
        {
            get { return _stats; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Stats cannot be null.");
                }
                _stats = value;
            }
        }

        public MoveSet MoveSet
        {
            get { return _moveSet; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("MoveSet cannot be null.");
                }
                _moveSet = value;
            }
        }

        public StatusConditionSet StatusConditions
        {
            get { return _statusConditions; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("StatusConditions cannot be null.");
                }
                _statusConditions = value;
            }
        }

        public StatModifiers StatModifiers
        {
            get { return _statModifiers; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("StatModifiers cannot be null.");
                }
                _statModifiers = value;
            }
        }

        public Pokemon(PokemonSpecies species, Gender gender, int level, PokemonStats stats, MoveSet moveSet)
        {
            Species = species;
            Gender = gender;
            Level = level;
            Stats = stats;
            MoveSet = moveSet;
            StatusConditions = new StatusConditionSet();
            StatModifiers = new StatModifiers();
        }
    }
}
