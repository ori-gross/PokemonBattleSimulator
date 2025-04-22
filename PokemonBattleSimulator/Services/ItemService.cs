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
    public static class ItemService
    {
        public static List<Item> LoadItems(string relativeJsonPath)
        {
            try
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeJsonPath);

                if (!File.Exists(fullPath))
                {
                    Console.WriteLine($"[ERROR] File not found: {fullPath}");
                    return new List<Item>();
                }

                string json = File.ReadAllText(fullPath);
                Console.WriteLine($"[DEBUG] JSON loaded: {json.Length} characters");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Converters = { new JsonStringEnumConverter() }
                };

                //return JsonSerializer.Deserialize<List<PokemonSpecies>>(json, options);
                var list = JsonSerializer.Deserialize<List<Item>>(json, options);
                Console.WriteLine($"[DEBUG] Loaded {list.Count} Pokémon species");
                return list;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[EXCEPTION] Error loading Pokémon species: {ex}");
                return new List<Item>();
            }
        }
    }
}
