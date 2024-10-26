using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_System.Classes
{
    public class Order : OrderInterface
    {
        private readonly List<POSItem> items = new List<POSItem>();

        public void AddItem(POSItem Item)
        {
            items.Add(Item);
            Console.WriteLine($"{Item.Name} added to the order.");
        }

        public void RemoveItem(POSItem Item)
        {
            if (items.Contains(Item))
            {
                items.Remove(Item);
                Console.WriteLine($"{Item.Name} removed from the order");
            }
        }


        public decimal GetTotal()
        {
            return items.Sum(item => item.Price);
        }


        public IEnumerable<POSItem> GetItems()
        {
            return items;
        }


        public void Clear()
        {
            items.Clear();
            Console.WriteLine("Order has been cleared.");
        }
    }
}
