using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Comfortel.Models
{
    public class ComfortelContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Payment> Payment { get; set; }

    }
}