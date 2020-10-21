using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comfortel.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }

        public int RateId { get; set; }
        public virtual Rate Rate { get; set; }

    }
}