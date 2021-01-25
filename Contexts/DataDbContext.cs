using BookingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingPlatform.Contexts
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Room>()
               .HasData(
               new Room()
               {
                   Id = 1,
                   Title = "Foo Room",
                   Images = "http://",
                   Price = 12345,
                   Description = "Foo Room",
                   Address = "Foo Village",
                   Capacity = 4
               },
               new Room()
               {
                   Id = 2,
                   Title = "Bar Room",
                   Images = "http://",
                   Price = 12,
                   Description = "Bar Room",
                   Address = "Bar Village",
                   Capacity = 1
               });
        }

        public DbSet<Room> Room { get; set; }

        public DbSet<Booking> Booking { get; set; }
    }   
}
