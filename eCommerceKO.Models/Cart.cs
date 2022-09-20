using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Models
{
    public class Cart
    {
        public Cart()
        {
            CartCount = 1;
        }
        [Key]
        public int CartID { get; set; }
        public string WebUserID { get; set; }
        public int ProductID { get; set; }
        public int CartCount { get; set; }
        public double CartPrice { get; set; }
        //NAV
        [ForeignKey("WebUserID")]
        public WebUser WebUser { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }
    }
}
