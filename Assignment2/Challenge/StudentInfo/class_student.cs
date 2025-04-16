/*
Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division. 
(May use a struct / class to represent the student)
Test Data :
Input the Roll Number of the student :784
Input the Name of the Student :James
Input the marks of Physics, Chemistry and Computer Application : 70 80 90
Expected Output :
Roll No : 784
Name of Student : James
Marks in Physics : 70
Marks in Chemistry : 80
Marks in Computer Application : 90
Total Marks = 240
Percentage = 80.00
Division = First
*/

using System;

public class Student {
    
    // Properties
    public int RollNumber { get; set; }
    public string StudentName { get; set; }
    public int Physics { get; set; }
    public int Chemistry { get; set; }
    public int ComputerApp { get; set; }

    // Methods
    
    // Calculate raw grades
    public int TotalMarks()
    {
        return Physics + Chemistry + ComputerApp;
    }

    // Calculate grade percentage
    public double Percentage()
    {
        return TotalMarks() / 3.0;
    }
    
    // Create division group
    public string Division()
    {
        double percentage = Percentage();

        if (percentage >= 90) return "First";
        if (percentage >= 80) return "Second";
        if (percentage >= 70) return "Third";
        return "Fail";
    }

    // Print result method
    public void PrintResult()
    {
        Console.WriteLine($"\nRoll No : {RollNumber}");
        Console.WriteLine($"Name of Student : {StudentName}");
        Console.WriteLine($"Marks in Physics : {Physics}");
        Console.WriteLine($"Marks in Chemistry : {Chemistry}");
        Console.WriteLine($"Marks in Computer Application : {ComputerApp}");
        Console.WriteLine($"Total Marks = {TotalMarks()}");
        Console.WriteLine($"Percentage = {Percentage():F2}");
        Console.WriteLine($"Division = {Division()}");
    }
    
}

// Upgrades: dictionary, enum