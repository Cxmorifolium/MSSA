using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace assignment4_1
{
    internal class AddressBook
    {
        private Dictionary<string, Person> people = new Dictionary<string, Person>();

        private string Filepath = @"C:\Users\lemon\OneDrive\Documents\CsharpProjects\MSSA\Assignment4\assignment4_1\addressbook.json";

        public string Filename
        {
            get { return Filepath; }
        }

        public void AddPerson(string firstName, string lastName, string mobilePhone, string workPhone, string address)
        {
            string fullName = firstName + " " + lastName;
            if (!people.ContainsKey(fullName))
            {
                people[fullName] = new Person(firstName, lastName, mobilePhone, workPhone, address);
            }
        }

        public void SaveToFile()
        {
            string json = JsonConvert.SerializeObject(people, Formatting.Indented);
            File.WriteAllText(Filename, json); 
        }

        public void LoadFromFile()
        {
            if (File.Exists(Filename))
            {
                string json = File.ReadAllText(Filename);
                people = JsonConvert.DeserializeObject<Dictionary<string, Person>>(json);
                Console.WriteLine("Address book loaded from " + Filename);
            }
            else
            {
                Console.WriteLine("No address book file found.");
            }
        }


        public Person SearchPerson(string fullName)
        {
            if (people.ContainsKey(fullName))
            {
                return people[fullName];
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return people.Values;
        }

        public void ClearPeople()
        {
            people.Clear();
        }
    }
}
