using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_System.Classes
{
    public class Order : OrderInterface
    {
        private readonly List<POSItem> items = new List<POSItem>();


        public void AddItem(POSItem item) => items.Add(item);

        public void RemoveItem(POSItem item) => items.Remove(item);

        public decimal GetTotal() => items.Sum(item => item.Price);

        public IEnumerable<POSItem> GetItems() => items;


        public void Clear()
        {
            items.Clear();;
        }
    }
}
