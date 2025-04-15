/* 
Write a C# Sharp program to read temperature in Fahrenheit and display a suitable message according to temperature state below :
Temp 0< 10 then Freezing weather
Temp 11-20 then Very Cold weather
Temp 21-35 then Cold weather
Temp 36-50 then Normal in Weather
Temp 51-65 then Its Hot
Temp 66-80 then Its Very Hot
Test Data :
67
Expected Output :
Its very hot.
*/
using System;


class Program {
    static void Main(string[] args) {
        Console.WriteLine("Please enter a temperature value in fahrenheit: ");
        decimal temperature = Convert.ToDecimal(Console.ReadLine());


        string result = temperature switch
        {
            > 0 and < 10 => "Freezing weather",
            >= 11 and <= 20 => "Very Cold weather",
            >= 21 and <= 35 => "Cold weather",
            >= 36 and <= 50 => "Normal in Weather",
            >= 51 and <= 65 => "Its Hot",
            >= 66 and <= 80 => "Its Very Hot",
            _ => "Unpredictable Weather"
        };
        
        Console.WriteLine(result);
    }
}