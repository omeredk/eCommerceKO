using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int OrderProductID { get; set; }
        public int ProductID { get; set; }
        public int OrderCount { get; set; }
        public double OrderPrice { get; set; }

        [ForeignKey("OrderProductID")]
        public OrderProduct OrderProduct { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }
    }
}
