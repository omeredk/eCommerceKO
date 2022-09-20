using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "{0} boş olamaz "), Display(Name = "Kategori Adı"), StringLength(40, MinimumLength = 2, ErrorMessage = "{0} {2}-{1} karakter olmalı")]
        public string CategoryName { get; set; }
    }
}
