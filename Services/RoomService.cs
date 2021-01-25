using BookingPlatform.Contexts;
using BookingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingPlatform.Services
{
    public class RoomService : IRoomService
    {
        private DataDbContext DataDbContext;

        public RoomService(DataDbContext dataDbContext)
        {
            DataDbContext = dataDbContext;
        }

        public IEnumerable<Room> GetAll()
        {
            return DataDbContext.Room.ToList();
        }
    }
}
