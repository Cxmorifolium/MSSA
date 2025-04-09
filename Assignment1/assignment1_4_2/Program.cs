/*
Write a class: “Student” with private data members: 
StudentId ( int), StudentFname (string), StudentLname (string ), StudentGrade ( char ) 
and public properties for each data member. 
Instantiate the class and assign data to properties. 
Display the data back on console.

Class "student" written outside Class Program so it's accessible

public: Code in any assembly can access this type or member. 
    The accessibility level of the containing type controls the accessibility level of public members of the type.
private: Only code declared in the same class or struct can access this member.

Encapsulation

Automatic properties: get (readable); set (writable). 

https://www.tutorialspoint.com/csharp/csharp_encapsulation.htm
https://www.c-sharpcorner.com/article/encapsulation-in-C-Sharp/

*/

using System;

class Student {

    private int studentId;
    private string? studentFn;  // Nullable string for first name
    private string? studentLn;  // Nullable string for last name
    private char studentGrade;

    public int StudentId {  
        get { return studentId; } 
        set { studentId = value; } 
    }

    public string? StudentFn { 
        get { return studentFn ?? "Default"; } 
        set { studentFn = value; } 
    }

    public string? StudentLn { 
        get { return studentLn ?? "Default"; } 
        set { studentLn = value; } 
    }

    public char StudentGrade { 
        get { return studentGrade; } 
        set { studentGrade = value; } 
    }
}


class Program {
    static void Main(string[] args) {

        Student student = new Student();
        student.StudentId = 1;
        student.StudentFn = "Jane";
        student.StudentLn = "Doe";
        student.StudentGrade = 'A';

        Console.WriteLine($@"Student data:
         ID: {student.StudentId}
         First Name: {student.StudentFn}
         Last Name: {student.StudentLn}
         Grade: {student.StudentGrade}");

    }
}
