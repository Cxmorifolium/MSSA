using assignment4_1_followalong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_1_followalong
    {
        internal class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MobilePhone { get; set; }
            public string WorkPhone { get; set; }
            public string Address { get; set; }

            public Person()
            {
                // to create new person
            }

            // Constructor for dictionary
            public Person(string firstName, string lastName, string mobilePhone, string workPhone, string address)
            {
                FirstName = firstName;
                LastName = lastName;
                MobilePhone = mobilePhone;
                WorkPhone = workPhone;
                Address = address;
            }

            public string GetFullName()
            {
                return FirstName + " " + LastName;
            }


    }

    }
