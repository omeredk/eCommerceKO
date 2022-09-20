using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Models
{
    public class ProductColor
    {
        [Key]
        public int ProductColorID { get; set; }
        public string ProductColorName { get; set; }
    }
}
