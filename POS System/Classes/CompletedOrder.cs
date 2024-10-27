using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_System.Classes
{
    [Table("CompletedOrders")]
    public class CompletedOrder
    {
        [Key]
        public int OrderID { get; set; }  // primary key

        [Required]
        public string ItemIDs { get; set; }  // list of item IDs comma seperated

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public DateTime Date { get; set; }  
    }
}