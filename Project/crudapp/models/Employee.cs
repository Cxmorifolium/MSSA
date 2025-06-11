using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace crudapp.models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        public string? Name { get; set; }
        public double Salary { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }
}
