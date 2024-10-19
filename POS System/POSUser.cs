using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_System
{
    [Table("Users")]
    public class POSUser
    {
        [Key]
        public int UserID { get; set; }

        public string Password { get; set; }
        public string Name { get; set; }

        public int UserType { get; set; }  // 0 = crew, 1 = team lead, 2 = manager 
    }
}