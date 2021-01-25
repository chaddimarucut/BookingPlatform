using BookingPlatform.Dto;
using BookingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingPlatform.Services
{
    public interface IBookingService
    {
        IEnumerable<Booking> GetAll();

        bool Add(NewBooking model);
    }
}
