using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationLog.Models
{
    public class Membership
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}