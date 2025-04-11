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
    public class ItemService
    {
        public static List<Item> LoadItems(string jsonFilePath)
        {
            try
            {
                // Read the JSON file from disk
                string jsonString = File.ReadAllText(jsonFilePath);
                // Deserialize to a list of items
                List<Item> items = JsonSerializer.Deserialize<List<Item>>(jsonString);
                return items;
            }
            catch (Exception ex)
            {
                // Handle exceptions (file not found, JSON errors, etc.)
                Console.WriteLine($"Error loading items: {ex.Message}");
                return new List<Item>();
            }
        }
    }
}
