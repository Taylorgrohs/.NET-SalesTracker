using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    [Table("Sales")]
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int TotalPrice { get; set; }
        public string Notes { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Product> Products { get; }
    }
}
