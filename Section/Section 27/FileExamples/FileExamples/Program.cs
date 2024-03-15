using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileExamples
{
    internal class Program
    {
        static void Main()
        {
            //File.Create("C:\\Users\\Coditas-Admin\\Documents\\C #\\Section\\Section 27\\TempFileCreated\\Temp.txt");

            string filedirectory = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\Temp.txt";

            string filedirectory2 = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\Temp2.txt";

            string filedirectory3 = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\Temp3.txt";
            File.Create(filedirectory).Close();
            Console.WriteLine("Temp.txt Created!");

            bool exists = File.Exists(filedirectory);
            if (exists)
            {
                File.Copy(filedirectory, filedirectory2);


                Console.WriteLine("Copied Temp.txt to Temp2.txt");

                File.Move(filedirectory2, filedirectory3);
                Console.WriteLine("Moved Temp2.txt to Temp3.txt");

                File.Delete(filedirectory3);
                Console.WriteLine("Temp3.txt deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }

            Console.WriteLine(File.Exists(filedirectory));
            Console.ReadKey();  
        }
    }
}
