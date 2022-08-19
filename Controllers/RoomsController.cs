using CoderResort.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderResort.Controllers
{
    public class RoomsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RoomsController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Featured Rooms
        public IActionResult Index()
        {
            var rooms = _db.Rooms.Where(r => r.FeaturedRoom == true).ToList();

            if (rooms == null)
            {
                return View("NotFoundData");
            }

            return View(rooms);
        }

        public IActionResult Rooms()
        {
            var rooms = _db.Rooms.ToList();

            if (rooms == null)
            {
                return View("NotFoundData");
            }

            return View(rooms);
        }

        public IActionResult SingleRoom(int id)
        {
            var room = _db.Rooms.FirstOrDefault(r => r.RoomId == id);

            if (room == null)
                return NotFound();

            return View(room);
        }
    }
}
