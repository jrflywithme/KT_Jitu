using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace blalogin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var people = new List<Route>();
            for (int i = 6; i < 106; i++)
            {
                people.Add(new Route() { Id = i, Routename = $"Person {i}" });
            }

            builder.Entity<Route>().HasData(people);

            base.OnModelCreating(builder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dailyproduct> Dailyproducts { get; set; }
        public DbSet<Route> Routes { get; set; }
    }
}
