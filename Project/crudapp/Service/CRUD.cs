using crudapp.Data;
using crudapp.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudapp.Service
{
    public class CRUD
    {
        public void AddEmployee(Employee employee)
        {
            Records.employeeContext.EmployeeSet.Add(employee);
            Records.employeeContext.SaveChanges();
        }

        public Employee? FindEmployee(int id)
        {
            return Records.employeeContext.EmployeeSet
                .Include(e => e.Department) 
                .FirstOrDefault(e => e.EmployeeId == id);
        }

        public void DeleteEmployee(int id)
        {
            var emp = Records.employeeContext.EmployeeSet.Find(id);
            if (emp != null)
            {
                Records.employeeContext.EmployeeSet.Remove(emp);
                Records.employeeContext.SaveChanges();
            }
        }
        public void UpdateEmployee(int id, Employee updatedEmployee)
        {
            try
            {
                // Find the existing employee by ID
                var existingEmployee = Records.employeeContext.EmployeeSet.Find(id);

                if (existingEmployee != null)
                {
                    // Update the properties from the updated employee object
                    existingEmployee.Name = updatedEmployee.Name;
                    existingEmployee.Salary = updatedEmployee.Salary;
                    existingEmployee.DepartmentId = updatedEmployee.DepartmentId;

                    // Save changes
                    Records.employeeContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Handle exception as needed
                throw new Exception($"Failed to update employee: {ex.Message}");
            }
        }
        public List<Employee> GetAllEmployees()
        {
            return Records.employeeContext.EmployeeSet
                .Include(e => e.Department)
                .ToList();
        }

        public List<Department> GetAllDepartment()
        {
            return Records.employeeContext.DepartmentSet.ToList();
        }

        public int GetMaxId()
        {
            if (!Records.employeeContext.EmployeeSet.Any())
                return 0;
            return Records.employeeContext.EmployeeSet.Max(e => e.EmployeeId);
        }
    }
}
