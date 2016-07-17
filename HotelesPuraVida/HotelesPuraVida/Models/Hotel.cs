using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelesPuraVida.Models
{
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Rating { get; set; }

        
    }
}