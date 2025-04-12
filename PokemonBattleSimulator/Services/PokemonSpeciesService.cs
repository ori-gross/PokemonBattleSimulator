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
    public static class PokemonSpeciesService
    {
        public static List<PokemonSpecies> LoadSpecies(string jsonFilePath)
        {
            try
            {
                string json = File.ReadAllText(jsonFilePath);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<List<PokemonSpecies>>(json, options);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading Pokémon species: {ex.Message}");
                return new List<PokemonSpecies>();
            }
        }
    }
}
