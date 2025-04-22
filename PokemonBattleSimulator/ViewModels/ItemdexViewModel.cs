using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Entities;
using PokemonBattleSimulator.Services;

namespace PokemonBattleSimulator.ViewModels
{
    public class ItemdexViewModel : ViewModelBase
    {
        public ObservableCollection<Item> ItemList { get; set; }

        public ItemdexViewModel()
        {
            // Load data using the service
            var items = ItemService.LoadItems("Resources/Data/Items.json");
            ItemList = new ObservableCollection<Item>(items);
        }
    }
}
