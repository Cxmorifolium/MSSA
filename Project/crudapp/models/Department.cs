using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace crudapp.models
{
    // master table for department (1 to many relationship w/ employees
    public class Department
    {
        [Key]
        public int DepartmentID {  get; set; }
        public string? DepartmentName { get; set; }
        public string? Location { get; set; }
        public virtual ObservableCollectionListSource<Employee>? Employees { get; set; }

    }
}
