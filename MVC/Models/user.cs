using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class user
    {
        [Required]
        [StringLength(15)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(15)]
        public string LastName { get; set; }
    }
}