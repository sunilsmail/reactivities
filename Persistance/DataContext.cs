using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Order> orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>().HasData(
                new Order { Id = 1, Name = "Order1" },
                new Order { Id = 2, Name = "Order2" },
                new Order { Id = 3, Name = "Order3" }
            );
        }
    }
}
