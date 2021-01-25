using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingPlatform.Contexts;
using BookingPlatform.Models;
using BookingPlatform.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private IRoomService RoomService;
        public RoomController(IRoomService roomService)
        {
            RoomService = roomService;
        }

        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return RoomService.GetAll();
        }
    }
}