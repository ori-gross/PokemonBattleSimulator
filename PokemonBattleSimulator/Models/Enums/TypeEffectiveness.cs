using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Enums
{
    public enum TypeEffectiveness
    {
        NoEffect,          // 0x
        NotVeryEffective,  // 0.5x
        Normal,            // 1x
        SuperEffective     // 2x
    }
}
