using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudapp.Data
{
    // Wrapper class: hold DbContext for employee application, but also ensure that 
    // it is only 1 instance of the context being used throughout the application
    public static class Records
    {
        public static EmployeeContext? employeeContext;

    }
}
