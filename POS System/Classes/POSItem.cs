using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System.Classes
{
    public class POSItem
    {
        public string Name { get; }
        public decimal Price { get; }

        public POSItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
    }
}
