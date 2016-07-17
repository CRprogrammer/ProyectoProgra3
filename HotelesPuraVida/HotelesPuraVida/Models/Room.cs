using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelesPuraVida.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public string Name { get; set; }
        public string AvailableDays { get; set; }
        public int MaxPeoples { get; set; }

       
    }
}