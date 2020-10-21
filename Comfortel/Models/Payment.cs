using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comfortel.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime DatePayment { get; set; }
        public int PaymentType { get; set; }
        public float Amount { get; set; }

        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }

    }
}