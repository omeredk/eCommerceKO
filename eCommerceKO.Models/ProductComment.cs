using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Models
{
    public class ProductComment
    {
        [Key]
        public int ProductCommentID { get; set; }
        public string WebUserFullName { get; set; }
        public DateTime ProductCommentDate { get; set; }
        [Required(ErrorMessage = "{0} boş olamaz "), Display(Name = "Başlık"), StringLength(50, MinimumLength = 2, ErrorMessage = "{0} {2}-{1} karakter olmalı")]
        public string ProductCommentTitle { get; set; }
        [Required(ErrorMessage = "{0} boş olamaz "), Display(Name = "Yorum"), StringLength(400, MinimumLength = 10, ErrorMessage = "{0} {2}-{1} karakter olmalı")]
        public string ProductCommentParagraph { get; set; }
        [ForeignKey("WebUserFullName")]
        public WebUser WebUser { get; set; }

    }
}
