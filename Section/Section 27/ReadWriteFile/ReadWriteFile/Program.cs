using System;
using System.Collections.Generic;
using System.IO;

namespace FileReadWriteExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\Dog.txt";
            string content = "The dog is one of the common domestic animal.";

            //WriteAllText
            File.WriteAllText(filePath, content);
            Console.WriteLine("dog.txt created");

            //ReadAllText
            string s = File.ReadAllText(filePath);
            Console.WriteLine("\nFile read:");
            Console.WriteLine(s);

            Console.WriteLine("---------------------------------------------------------------------------");

            List<string> asia = new List<string>() { "Russia", "China", "India" };

            string filelocation = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\Asia.txt";

            //WRITEALL LINES 
            File.WriteAllLines(filelocation, asia);
            Console.WriteLine("asia.txt file created");
            string[] asiacontent = File.ReadAllLines(filelocation);
            foreach (string country in asiacontent)
            {
                    Console.WriteLine(country);
            }

            Console.ReadKey();
        }
    }
}
