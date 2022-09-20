using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Models
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }
        [Required(ErrorMessage = "{0} boş olamaz "), Display(Name = "İndirim Yüzdesi"), Range(0, 99, ErrorMessage = "{0} {1} - {2} aralığında değer almalı")]
        public int DiscountAmounth { get; set; }
    }
}
