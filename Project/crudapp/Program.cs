using crudapp.Data;
using Microsoft.EntityFrameworkCore;

namespace crudapp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Records.employeeContext = new EmployeeContext(); // initialize the employee context
            Records.employeeContext.Database.EnsureCreated(); // ensure the database is created
            Records.employeeContext.DepartmentSet.Load();   //  load the employeeset
            Application.Run(new Form1());
        }
    }
}