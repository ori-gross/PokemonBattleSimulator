using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Entities;

namespace PokemonBattleSimulator.Services
{
    public static class PokemonMovesService
    {
        public static List<PokemonMove> LoadPokemonMoves(string relativeJsonPath)
        {
            try
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeJsonPath);

                if (!File.Exists(fullPath))
                {
                    Console.WriteLine($"[ERROR] File not found: {fullPath}");
                    return new List<PokemonMove>();
                }

                string json = File.ReadAllText(fullPath);
                Console.WriteLine($"[DEBUG] JSON loaded: {json.Length} characters");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Converters = { new JsonStringEnumConverter() }
                };

                var list = JsonSerializer.Deserialize<List<PokemonMove>>(json, options);
                Console.WriteLine($"[DEBUG] Loaded {list.Count} Pokémon moves");
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[EXCEPTION] Error loading Pokémon moves: {ex}");
                return new List<PokemonMove>();
            }
        }
    }
}
