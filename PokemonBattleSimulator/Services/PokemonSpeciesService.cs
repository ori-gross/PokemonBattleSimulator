using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Entities;

namespace PokemonBattleSimulator.Services
{
    public class PokemonSpeciesService
    {
        public static List<PokemonMove> LoadPokemonMoves(string jsonFilePath)
        {
            try
            {
                // Read all text from the JSON file.
                string jsonString = File.ReadAllText(jsonFilePath);

                // Deserialize JSON to a list of moves.
                List<PokemonMove> moves = JsonSerializer.Deserialize<List<PokemonMove>>(jsonString);

                return moves;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading moves: {ex.Message}");
                return new List<PokemonMove>();
            }
        }
    }
}
