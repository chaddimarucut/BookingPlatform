using BookingPlatform.Contexts;
using BookingPlatform.Dto;
using BookingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingPlatform.Services
{
    public class BookingService : IBookingService
    {
        private DataDbContext DataDbContext;

        public BookingService(DataDbContext dataDbContext)
        {
            DataDbContext = dataDbContext;
        }

        public IEnumerable<Booking> GetAll()
        {
            return DataDbContext.Booking.ToList();
        }

        public bool Add(NewBooking model)
        {
            var room = DataDbContext.Room.FirstOrDefault(x => x.Id == model.RoomId);

            if (room is null)
            {
                throw new NullReferenceException(nameof(room));
            }

            if (model.Pax > room.Capacity)
            {
                return false;
            }

            var booking = DataDbContext.Booking.FirstOrDefault(x => x.RoomId == model.RoomId && x.Date.Date == model.Date.Date);

            if (booking != null)
            {
                return false;
            }

            DataDbContext.Booking.Add(new Booking()
            {
                RoomId = model.RoomId,
                Date = model.Date,
                Email = model.Email
            }); ;
            
            return DataDbContext.SaveChanges() > 0;
        }
    }
}
