using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Entities
{
    public class Trainer
    {
        private string _name;
        private PokemonTeam _pokemonTeam;
        private Bag _bag;

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

        public PokemonTeam PokemonTeam
        {
            get { return _pokemonTeam; }
            set
            {
                if (value == null || value.PokemonList.Count == 0)
                {
                    throw new ArgumentException("Pokemon team cannot be null or empty.");
                }
                _pokemonTeam = value;
            }
        }

        public Bag Bag
        {
            get { return _bag; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Bag cannot be null.");
                }
                _bag = value;
            }
        }

        public Trainer(string name, PokemonTeam pokemonTeam, Bag bag)
        {
            Name = name;
            PokemonTeam = pokemonTeam;
            Bag = bag;
        }

        public void AddPokemonToTeam(Pokemon pokemon)
        {
            if (pokemon == null)
            {
                throw new ArgumentNullException(nameof(pokemon), "Pokemon cannot be null.");
            }
            PokemonTeam.AddPokemon(pokemon);
        }

        public void RemovePokemonFromTeam(Pokemon pokemon)
        {
            if (pokemon == null)
            {
                throw new ArgumentNullException(nameof(pokemon), "Pokemon cannot be null.");
            }
            PokemonTeam.RemovePokemon(pokemon);
        }

        public void AddItemToBag(Item item, int quantity)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            Bag.AddItem(item, quantity);
        }

        public void RemoveItemFromBag(Item item, int quantity)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            Bag.RemoveItem(item, quantity);
        }

        public void UseItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            if (Bag.Items.ContainsKey(item) && Bag.Items[item] > 0)
            {
                // Implement item usage logic here
                Console.WriteLine($"{Name} used {item.Name}.");
                Bag.RemoveItem(item, 1);
            }
            else
            {
                Console.WriteLine($"{Name} does not have {item.Name} in the bag.");
            }
        }
    }
}
