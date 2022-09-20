using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Models
{
    public class WebUser : IdentityUser
    {
        [Required]
        public string WebUserFullName { get; set; }
        public string WebUserAddress { get; set; }
        public string WebUserPostalCode { get; set; }
        public string WebUserPhone { get; set; }

        [NotMapped]
        public string WebUserRole { get; set; }
    }
}
