using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelesPuraVida.Models
{
    public class Login
    {
        [Key]
        public int LoginID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }

        
    }
}