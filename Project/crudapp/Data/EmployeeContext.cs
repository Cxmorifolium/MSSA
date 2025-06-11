using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crudapp.models;

namespace crudapp.Data
{
    // Represents the database context for the Employee application
    public class EmployeeContext : DbContext
    {
        public DbSet<Department> DepartmentSet { get; set; }
        public DbSet<Employee> EmployeeSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=NELIEL;initial catalog=PCAD17Employees;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationship explicitly
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            // Seed data
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentID = 1,
                    DepartmentName = "HR",
                    Location = "New York"
                },
                new Department
                {
                    DepartmentID = 2,
                    DepartmentName = "IT",
                    Location = "Los Angeles"
                },
                new Department
                {
                    DepartmentID = 3,
                    DepartmentName = "Finance", // Fixed typo
                    Location = "Chicago"
                }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "Alice",
                    Salary = 90000,
                    DepartmentId = 1,
                },
                new Employee
                {
                    EmployeeId = 2,
                    Name = "Barbie",
                    Salary = 190000,
                    DepartmentId = 2,
                },
                new Employee
                {
                    EmployeeId = 3,
                    Name = "Charlie",
                    Salary = 85000,
                    DepartmentId = 3,
                }
            );
        }
    }
}
