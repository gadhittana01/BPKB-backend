using System;
using System.Collections.Generic;
using BPKB_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace BPKB_Project.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=BPKB;User Id=SA;Password=MyPass@word;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    LocationID = "L001",
                    LocationName= "Bali",
                },
                new Location
                {
                    LocationID = "L002",
                    LocationName = "Jakarta",
                },
                new Location
                {
                    LocationID = "L003",
                    LocationName = "Sumatera",
                }
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<BPKB> bpkbs { get; set; }
        public DbSet<Location> locations { get; set; }
    }
}

