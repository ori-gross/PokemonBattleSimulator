using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Entities;

namespace PokemonBattleSimulator.Utilities.Classes
{
    public static class BattleUtilities
    {
        public static void ApplyMoveEffects(Pokemon target, PokemonMove move)
        {
            switch (move.Name) // Use the Name property from the parsed JSON
            {
                case "Tackle":
                    //target.TakeDamage(40);
                    target.Stats.HP -= 40; // Example damage calculation
                    break;
                case "ThunderShock":
                    //target.TakeDamage(40);
                    //target.ApplyStatusCondition(StatusCondition.Paralysis);
                    break;
                // Add more cases for other moves
                default:
                    throw new NotImplementedException($"Effect for {move.Name} not implemented.");
            }
        }

        public static void ApplyItemEffects(Pokemon target, Item item)
        {
            switch (item.Name)
            {
                case "Potion":
                    //target.Heal(20);
                    break;
                case "Revive":
                    //target.Revive();
                    break;
                // Add more cases for other items
                default:
                    throw new NotImplementedException($"Item effect for {item.Name} not implemented.");
            }
        }
    }
}
