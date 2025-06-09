using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

public class Student
{
    // Properties
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public double GPA { get; set; }

    public int Grade { get; set; }
    public DateTime Enrollment { get; set; }

    public override string ToString()
    {
        return $"ID: {StudentID}, Name: {StudentName}, GPA: {GPA}, Grade: {Grade}, Enrolled: {Enrollment:yyyy-MM-dd}";
    }

    // Default constructor for XML serialization
    public Student() { }

    // Constructor
        public Student(int studentID, string StudentName, double GPA, int Grade, DateTime Enrollment)
    {
        this.StudentID = studentID;
        this.StudentName = StudentName; 
        this.GPA = GPA;
        this.Grade = Grade;
        this.Enrollment = Enrollment;
    }

}