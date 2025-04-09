// Preferred method class in a seperate .cs

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
