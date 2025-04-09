using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Enums;

namespace PokemonBattleSimulator.Models.Entities
{
    public class StatusConditionSet
    {
        private PrimaryStatusCondition _primaryStatusCondition;
        private List<VolatileStatusCondition> _volatileStatusConditions;

        public PrimaryStatusCondition PrimaryStatusCondition
        {
            get { return _primaryStatusCondition; }
            set
            {
                if (!Enum.IsDefined(typeof(PrimaryStatusCondition), value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Invalid primary status condition.");
                }
                _primaryStatusCondition = value;
            }
        }

        public List<VolatileStatusCondition> VolatileStatusConditions
        {
            get { return _volatileStatusConditions; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Volatile status conditions cannot be null.");
                }
                _volatileStatusConditions = value;
            }
        }

        public StatusConditionSet()
        {
            _primaryStatusCondition = PrimaryStatusCondition.None;
            _volatileStatusConditions = new List<VolatileStatusCondition>();
        }

        public StatusConditionSet(PrimaryStatusCondition primaryStatusCondition, List<VolatileStatusCondition> volatileStatusConditions)
        {
            PrimaryStatusCondition = primaryStatusCondition;
            VolatileStatusConditions = volatileStatusConditions ?? new List<VolatileStatusCondition>();
        }

        public void AddVolatileStatusCondition(VolatileStatusCondition condition)
        {
            if (!Enum.IsDefined(typeof(VolatileStatusCondition), condition))
            {
                throw new ArgumentOutOfRangeException(nameof(condition), "Invalid volatile status condition.");
            }
            if (!_volatileStatusConditions.Contains(condition))
            {
                _volatileStatusConditions.Add(condition);
            }
        }

        public void RemoveVolatileStatusCondition(VolatileStatusCondition condition)
        {
            if (_volatileStatusConditions.Contains(condition))
            {
                _volatileStatusConditions.Remove(condition);
            }
        }
    }
}
