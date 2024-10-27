using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POS_System.Classes
{
    [Table("POSItems")]
    public class POSItem
    {
        [Key]
        public int ItemID { get; set; }  // primary key

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public POSItem() { }

        public POSItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}