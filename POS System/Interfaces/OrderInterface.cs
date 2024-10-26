using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System.Classes
{

    public interface OrderInterface
    {
        void AddItem(POSItem item);
        void RemoveItem(POSItem item);
        decimal GetTotal();
        IEnumerable<POSItem> GetItems();
    }
}
