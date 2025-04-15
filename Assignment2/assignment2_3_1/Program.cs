/*Write a console application to create a text file and save your basic details like name, 
age, address ( use dummy data). Read the details from same file and print on console.
 
 Stream Reader is used to read large files 
 TextReader/Writer used to read small; but going to follow documentation found for Stream Reader.
 */

using System;
using System.IO;

class Program {
    static void Main(string[] args) {

        // File Address & name
        string file = "dummydata.txt";

        var dummyData = new FileInfo(file);

        // Properties to store
        string fullName = "Jane Doe";
        int personAge = 30;
        string personAddress = "1234 Secret Ct, City, State, Country";

        // Tab-Seperated String for text columns
        string columns = $"{fullName}\t{personAge}\t{personAddress}";

        // try catch for data validation
        // using ensures streamwriter/reader is disposed properly.
        try {
            using (StreamWriter sw = dummyData.CreateText())
            {
                sw.WriteLine(columns); 
            }

            // Read text and output it
            using (StreamReader sr = dummyData.OpenText()) 
            {
                string? s;
                while ((s = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(s);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Oops! Something went wrong: {e.Message}");
        }
    }
}
