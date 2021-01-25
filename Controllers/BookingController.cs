using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingPlatform.Contexts;
using BookingPlatform.Dto;
using BookingPlatform.Models;
using BookingPlatform.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private IBookingService BookingService;
        public BookingController(IBookingService bookingService)
        {
            BookingService = bookingService;
        }

        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return BookingService.GetAll();
        }

        [HttpPost]
        public bool Post(NewBooking model)
        {
            return BookingService.Add(model);
        }
    }
}