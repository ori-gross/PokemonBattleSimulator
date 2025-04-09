using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Entities
{
    public class Bag
    {
        private Dictionary<Item, int> _items;

        public Dictionary<Item, int> Items
        {
            get { return _items; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Items cannot be null.");
                }
                _items = value;
            }
        }

        public Bag()
        {
            _items = new Dictionary<Item, int>();
        }

        public void AddItem(Item item, int quantity)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            if (quantity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than zero.");
            }
            if (_items.ContainsKey(item))
            {
                _items[item] += quantity;
            }
            else
            {
                _items[item] = quantity;
            }
        }

        public void RemoveItem(Item item, int quantity)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            if (quantity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than zero.");
            }
            if (_items.ContainsKey(item))
            {
                _items[item] -= quantity;
                if (_items[item] <= 0)
                {
                    _items.Remove(item);
                }
            }
            else
            {
                throw new KeyNotFoundException("Item not found in bag.");
            }
        }

        public int GetItemQuantity(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            if (_items.ContainsKey(item))
            {
                return _items[item];
            }
            else
            {
                return 0;
            }
        }

        public void ClearBag()
        {
            _items.Clear();
        }
    }
}
