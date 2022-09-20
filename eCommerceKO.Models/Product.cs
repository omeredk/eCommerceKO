using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace eCommerceKO.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "{0} boş olamaz "), Display(Name = "Ürün Adı"), StringLength(40, MinimumLength = 2, ErrorMessage = "{0} {2}-{1} karakter olmalı")]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductBarcode { get; set; }
        public double ProductPrice { get; set; }
        public string?  ProductPic { get; set; }
        public int CategoryID { get; set; }
        public int ProductColorID { get; set; }
        public int ProductSizeID { get; set; }
        public int DiscountID { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        [ForeignKey("ProductColorID")]
        public ProductColor ProductColor { get; set; }
        [ForeignKey("ProductSizeID")]
        public ProductSize ProductSize { get; set; }
        [ForeignKey("DiscountID")]
        public Discount Discount { get; set; }
    }
}
