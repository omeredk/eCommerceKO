using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Models
{
    public class ProductSize
    {
        [Key]
        public int ProductSizeID { get; set; }
        public string ProductSizeName { get; set; }
    }
}
