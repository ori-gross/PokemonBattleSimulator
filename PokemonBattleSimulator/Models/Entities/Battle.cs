using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Entities
{
    public class Battle
    {
        private Trainer _trainer1;
        private Trainer _trainer2;

        public Trainer Trainer1
        {
            get { return _trainer1; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Trainer cannot be null.");
                }
                _trainer1 = value;
            }
        }

        public Trainer Trainer2
        {
            get { return _trainer2; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Trainer cannot be null.");
                }
                _trainer2 = value;
            }
        }

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            Trainer1 = trainer1;
            Trainer2 = trainer2;
        }
        //public void StartBattle()
        //{
        //    // Implement battle logic here
        //    Console.WriteLine($"{_pokemon1.Name} vs {_pokemon2.Name}");
        //    // Example: Determine winner based on level and stats
        //}
    }
}
