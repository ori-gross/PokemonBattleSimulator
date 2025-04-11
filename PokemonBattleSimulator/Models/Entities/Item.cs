using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Entities
{
    public class Item
    {
        private string _name;
        private string _description;
        private string _itemImagePath;

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

        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Description cannot be null or empty.");
                }
                _description = value;
            }
        }

        public string ItemImagePath
        {
            get { return _itemImagePath; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Item image path cannot be null or empty.");
                }
                _itemImagePath = value;
            }
        }

        public Item(string name, string description, string itemImagePath)
        {
            Name = name;
            Description = description;
            ItemImagePath = itemImagePath;
        }
    }
}
