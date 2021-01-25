using BookingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingPlatform.Services
{
    public interface IRoomService
    {
        IEnumerable<Room> GetAll();
    }
}
