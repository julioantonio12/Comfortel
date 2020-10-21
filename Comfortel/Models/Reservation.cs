using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comfortel.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int NumAdults { get; set; }
        public int NumKids { get; set; }
        public DateTime DateBeg { get; set; }
        public DateTime DateEnd { get; set; }
        public int Status { get; set; }
        public float Total { get; set; }
        public string ReservationMedium { get; set; }
        public string ReservationCode { get; set; }
        public int IdRoom { get; set; }
        public int IdGuest { get; set; }

        public virtual Room Room { get; set; }
        public virtual Guest Guest { get; set; }

    }
}