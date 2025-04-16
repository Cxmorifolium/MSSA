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

class Program {
    static void Main(string[] args) {

        Student student = new Student();

        Console.WriteLine("Please Enter The Student Roll No.: ");
        student.RollNumber =  int.Parse(Console.ReadLine());

        Console.WriteLine("Enter The Student First Name: ");
        student.StudentName = Console.ReadLine();

        Console.WriteLine("Enter the marks for Physics: ");
        student.Physics = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the marks for Chemistry: ");
        student.Chemistry = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the marks for Computer Applications: ");
        student.ComputerApp = int.Parse(Console.ReadLine());

        student.PrintResult();
        
    }
}