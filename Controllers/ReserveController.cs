using CoderResort.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderResort.Controllers
{
    public class ReserveController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReserveController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Reserve(int id)
        {            
            Reserve newReservation = new Reserve();
            var room = _db.Rooms.FirstOrDefault(r => r.RoomId == id);

            if (room != null)
            {
                newReservation.RoomId = room.RoomId;

                return View(newReservation);
            }
            else
            {
                return RedirectToAction("Reserve");
            }
        }

        [HttpPost]
        public IActionResult Reserve(Reserve reserve)
        {
            if (ModelState.IsValid)
            {
                _db.Reserves.Add(reserve);
                _db.SaveChanges();

                return RedirectToAction("ReservationComplete");
            }
            return View(reserve);
        }

        public IActionResult ReservationComplete()
        {
            return View();
        }
    }
}
