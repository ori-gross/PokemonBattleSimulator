using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Entities
{
    public class PokemonTeam
    {
        private const int MaxTeamSize = 6;

        private List<Pokemon> _pokemonTeam;

        public List<Pokemon> PokemonList
        {
            get { return _pokemonTeam; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("Pokemon list cannot be null or empty.");
                }
                _pokemonTeam = value;
            }
        }

        public PokemonTeam()
        {
            _pokemonTeam = new List<Pokemon>(6);
        }

        public void AddPokemon(Pokemon pokemon)
        {
            if (pokemon == null)
            {
                throw new ArgumentNullException(nameof(pokemon), "Pokemon cannot be null.");
            }
            if (_pokemonTeam.Count >= MaxTeamSize)
            {
                throw new InvalidOperationException("Cannot add more than 6 Pokémon to the team.");
            }
            _pokemonTeam.Add(pokemon);
        }

        public void RemovePokemon(Pokemon pokemon)
        {
            if (pokemon == null)
            {
                throw new ArgumentNullException(nameof(pokemon), "Pokemon cannot be null.");
            }
            _pokemonTeam.Remove(pokemon);
        }

        public void ClearTeam()
        {
            _pokemonTeam.Clear();
        }
    }
}
