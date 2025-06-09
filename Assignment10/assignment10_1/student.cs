using System;
using System.Xml.Serialization;

namespace assignment10_1
{
    [Serializable]
    public class Student
    {
        [XmlElement]
        public string Name { get; set; }

        [XmlElement]
        public int Age { get; set; }

        [XmlElement]
        public string Major { get; set; }

        [XmlElement]
        public int StudentID { get; set; }

        public Student()
        {

        }

        public Student(string name, int age, string major, int studentID)
        {
            Name = name;
            Age = age;
            Major = major;
            StudentID = studentID;
        }

        public override string ToString()
        {
            return $"ID: {StudentID}, Name: {Name}, Age: {Age}, Major: {Major}";
        }
    }
}