using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderResort.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Capacity { get; set; }
        public decimal Size { get; set; }
        public bool FeaturedRoom { get; set; }
    }
}
