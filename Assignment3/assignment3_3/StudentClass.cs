using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_3
{
    internal class Student
    {
        public enum Months 
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,

        }

        public int StudentId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Months MonthOfAdmission { get; set; }
        public string Grade { get; set; }

    }
}
