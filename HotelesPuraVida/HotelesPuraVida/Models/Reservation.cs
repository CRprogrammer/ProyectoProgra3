using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelesPuraVida.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public string UserName { get; set; }
        public int RoomID { get; set; }
        public int HotelID { get; set; }
        public int Peoples { get; set; }
        public string Dates { get; set; }

        
    }
}