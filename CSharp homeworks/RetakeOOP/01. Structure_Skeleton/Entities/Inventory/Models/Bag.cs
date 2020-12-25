using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory.Models
{
    public abstract class Bag : IBag
    {
        private List<Item> _items;

        
        protected Bag(int capacity)
        
        {
            this.Capacity = capacity;
            this._items = new List<Item>();

        }

        public int Capacity { get; set; } = 100;

        public int Load
        {
            get
            {
                return this._items.Sum(x => x.Weight);
            }
        }

        public IReadOnlyCollection<Item> Items
        {
            get
            {
                return this._items.AsReadOnly();
            }
        }
        public void AddItem(Item item)
        {
            int currItemWeight = item.Weight;
            if (this.Load + currItemWeight > this.Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.ExceedMaximumBagCapacity);
            }

            _items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this._items.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyBag);
            }

            Item wantedItem = _items.FirstOrDefault(x => x.GetType().Name == name);
            if (wantedItem == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.ItemNotFoundInBag, name));
            }

            _items.Remove(wantedItem);
            return wantedItem;
        }
    }
}
