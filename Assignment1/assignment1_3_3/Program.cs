/* Write a program in C# to read n number of values in an array and display it in reverse order.
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2 

Is this user input?? Edit: no it wasn't lol. oops.
*/

// using System;

// class Program {
//     static void Main(string[] args){

//         // Ask user to enter the number of elements they want to store in array
//         Console.WriteLine("Please enter the number of elements you'd like in an array: ");

//         int userInput = Convert.ToInt32(Console.ReadLine());

//         // Create an array to store elements
//         double[] elements = new double[userInput];

//         // Method created call it after above
//         ElementEntry(elements);

//         // Display what values are stored; using foreach!!
//         Console.WriteLine("The values store into the array are:");
//         foreach (var item in elements)
//                 {
//                     Console.Write(item + " ");
//                 }

//         // Display the reverse of the array
//         Console.WriteLine("\nThe values stored in reverse order are:");
//         Array.Reverse(elements);  // Reverse the array
//         foreach (var item in elements) {
//             Console.Write(item + " ");
//         }

//     }

//     static void ElementEntry(double[] array) {
//         // Loop through array to get values from the user
//         for (int i = 0; i < array.Length; i++) {
//             // Ask user to enter their value
//             Console.WriteLine($"Please enter a value for Element [{i}]: ");
//             // Read user input and store it in the array
//             array[i] = Convert.ToDouble(Console.ReadLine());
//         }
//     }

// }

// Not using Array.Reverse but decrement instead
// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] temp = new int[] { 2, 5, 7 };
//         int n = temp.Length;

//         Console.WriteLine("The values stored into the array are:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write(temp[i] + " ");
//         }

//         Console.WriteLine("\nThe values stored into the array in reverse are:");
//         for (int i = n - 1; i >= 0; i--) //i-- decrement aka reads backwards
//         {
//             Console.Write(temp[i] + " ");
//         }
//     }
// }

// Via Math
using System;

class Program
{
    static void Main()
    {
        int[] temp = new int[] { 2, 5, 7 };
        int n = temp.Length;

        Console.WriteLine("The values stored into the array are:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(temp[i] + " ");
        }

        Console.WriteLine("\nThe values stored into the array in reverse are:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(temp[(n - 1) - i] + " ");
        }
    }
}
