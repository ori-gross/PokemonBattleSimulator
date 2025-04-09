using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Enums;

namespace PokemonBattleSimulator.Models.Entities
{
    public class StatModifiers
    {
        private Dictionary<StatType, int> _statModifiers;

        public Dictionary<StatType, int> StatModifiersDictionary
        {
            get { return _statModifiers; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Stat modifiers cannot be null.");
                }
                _statModifiers = value;
            }
        }

        public StatModifiers()
        {
            _statModifiers = new Dictionary<StatType, int>
            {
                { StatType.Attack, 0 },
                { StatType.Defense, 0 },
                { StatType.SpecialAttack, 0 },
                { StatType.SpecialDefense, 0 },
                { StatType.Speed, 0 },
                { StatType.Accuracy, 0 },
                { StatType.Evasion, 0 }
            };
        }

        public void SetModifier(StatType statType, int modifier)
        {
            if (_statModifiers.ContainsKey(statType))
            {
                _statModifiers[statType] = modifier;
            }
            else
            {
                throw new ArgumentException($"Stat type {statType} does not exist.");
            }
        }

        public int GetModifier(StatType statType)
        {
            if (_statModifiers.ContainsKey(statType))
            {
                return _statModifiers[statType];
            }
            else
            {
                throw new ArgumentException($"Stat type {statType} does not exist.");
            }
        }

        public void ResetModifiers()
        {
            foreach (var key in _statModifiers.Keys.ToList())
            {
                _statModifiers[key] = 0;
            }
        }
    }
}
