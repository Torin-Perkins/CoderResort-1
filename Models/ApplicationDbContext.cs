using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderResort.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename = ./rooms.sqlite");
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reserve> Reserves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed rooms
            modelBuilder.Entity<Room>().HasData(new Room
            {
                RoomId = 1,
                Name = "Double Deluxe",
                Price = 400M,
                Description = "Double Deluxe Room.",
                ImageUrl = "https://i.ibb.co/L9bYkSZ/room-1.jpg",
                Capacity = 2,
                Size = 500,
                FeaturedRoom = true
            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                RoomId = 2,
                Name = "Standard",
                Price = 400M,
                Description = "Family Standard Room.",
                ImageUrl = "https://i.ibb.co/0yjxGxp/room-2.jpg",
                Capacity = 5,
                Size = 600M,
                FeaturedRoom = true

            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                RoomId = 3,
                Name = "Presidential",
                Price = 600M,
                Description = "Presidential Room.",
                ImageUrl = "https://i.ibb.co/2tCwhYF/room-3.jpg",
                Capacity = 8,
                Size = 1000M,
                FeaturedRoom = false
            });
        }
    }
}

