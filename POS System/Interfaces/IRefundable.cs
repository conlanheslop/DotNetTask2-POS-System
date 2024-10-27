using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System.Classes
{
    public interface IRefundable
    {
        bool ProcessRefund(decimal amount); // if refund is successfull, return true
    }
}
