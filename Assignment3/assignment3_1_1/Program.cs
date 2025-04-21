/* Return even numbers
Write a method that returns a string of even numbers greater than 0 and less than 100.
(Use StringBuilder class) */

using System;
using System.Text;

class Program {
    static void Main(string[] args) {
        //instantiate new sb object
        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= 98; i++)
        {
            if (i % 2 == 0)
            {
                sb.Append(i + " ");
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
