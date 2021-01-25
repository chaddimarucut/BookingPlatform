using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingPlatform.Dto
{
    public class NewBooking
    {
        public int RoomId { get; set; }

        public string Email { get; set; }

        public DateTime Date { get; set; }

        public int Pax { get; set; }
    }
}
