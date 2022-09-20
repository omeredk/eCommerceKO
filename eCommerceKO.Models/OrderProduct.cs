using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Models
{
    public class OrderProduct
    {
        [Key]
        public int OrderProductID { get; set; }
        public string WebUserID { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderPrice { get; set; }
        public string OrderStatus { get; set; }

        public string OrderPhone { get; set; }
        public string OrderAddress { get; set; }
        public string OrderPostalCode { get; set; }
        public string OrderFullName { get; set; }

        [ForeignKey("WebUserID")]
        public WebUser WebUser { get; set; }
    }
}
