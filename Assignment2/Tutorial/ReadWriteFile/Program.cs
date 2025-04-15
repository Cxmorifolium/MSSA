using System;
using System.IO;

class Program {
    static void Main(string[] args) {
        
        string filePath = "Hello_World.txt";
            try
            {
                using (StreamReader sr = new StreamReader(filePath)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        Console.WriteLine(line);
                    }
                }

                using (StreamWriter sw = new StreamWriter((filePath), true)) //true means you can append in file
                {
                    sw.WriteLine("Added new line!");
                }
                Console.WriteLine("New lines appended successfully");
            }
            catch (Exception e) {
                Console.WriteLine("Exception:" + e.Message);
            }
    }
}