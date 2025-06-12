using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using carinventory.Model;

namespace carinventory.Data
{
    public class CarInventoryContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=NELIEL;initial catalog=CarInventoryDB;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    CarId = 1,
                    VehicleMake = "Toyota",
                    VehicleModel = "Camry",
                    VehicleYear = 2023,
                    VehiclePrice = 25000.00f
                },
                new Car
                {
                    CarId = 2,
                    VehicleMake = "Honda",
                    VehicleModel = "Civic",
                    VehicleYear = 2022,
                    VehiclePrice = 22000.00f
                },
                new Car
                {
                    CarId = 3,
                    VehicleMake = "Ford",
                    VehicleModel = "Mustang",
                    VehicleYear = 2024,
                    VehiclePrice = 35000.00f
                }
            );
        }
    }
}
