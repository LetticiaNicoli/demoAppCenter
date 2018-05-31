using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoAppCenter
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Punk IPA", Flavor = "#Hoppy #Fruity" , Brewing = "BrewDog" , Style = "IPA" , Description = "", Rating = 8 },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Heineken", Flavor = "#Light" , Brewing = "Heineken" , Style = "Lager" , Description = "", Rating = 2 },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Petroleum", Flavor = "#Coffee #Strong" , Brewing = "Wals" , Style = "Stout" , Description = "", Rating = 9 },
             };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
