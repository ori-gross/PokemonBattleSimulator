using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Enums
{
    public enum PrimaryStatusCondition
    {
        None,
        Burn,
        Freeze,
        Paralysis,
        Poison,
        Sleep
    }

    public enum VolatileStatusCondition
    {
        Confusion,
        Attract
    }
}
