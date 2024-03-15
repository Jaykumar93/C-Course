using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main()
        {
            string countriesPath = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\countries";
            DirectoryInfo directoryInfo = new DirectoryInfo(countriesPath);

            //Create
            directoryInfo.Create();
            Console.WriteLine("countries folder created");

            //CreateSubdirectory
            directoryInfo.CreateSubdirectory("India");
            directoryInfo.CreateSubdirectory("UK");
            directoryInfo.CreateSubdirectory("USA");
            Console.WriteLine("'India', 'UK', 'USA' folders created");

            //FileInfo.Create()
            new FileInfo(directoryInfo.FullName + @"\capitals.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\sports.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\population.txt").Create().Close();
            Console.WriteLine("'capitals.txt', 'sports.txt', 'population.txt' files created");

            //MoveTo
            string worldPath = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\world";
            directoryInfo.MoveTo(worldPath);
            Console.WriteLine("'countries' moved to 'world'");

            //GetFiles
            FileInfo[] files = directoryInfo.GetFiles();
            Console.WriteLine("\nFiles:");
            foreach(FileInfo file in files)
            {
                Console.WriteLine(file.FullName, file.Length);
            }

            //GetDirectories
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            Console.WriteLine("\nSub directories:");
            foreach (DirectoryInfo dir in directories)
            {
                Console.WriteLine(dir.FullName);
            }

            //Delete
            directoryInfo.Delete(true);
            Console.WriteLine("'world' folder deleted");


            string dirPath = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\world";
            DirectoryInfo directoryInfo1 = new DirectoryInfo(dirPath);

            Console.WriteLine("Exists:" + directoryInfo1.Exists);
            if (directoryInfo1.Exists)
            {
                Console.WriteLine("Full Name:"+ directoryInfo1.FullName);
                Console.WriteLine("Name:" + directoryInfo1.Name); Console.WriteLine("Directory Name:" + directoryInfo1.Parent);
            }
            Console.WriteLine("Directory Name:" + directoryInfo1.Parent);
            Console.WriteLine("Root:" + directoryInfo1.Root);
            Console.WriteLine("Creation data and time:" + directoryInfo1.CreationTime);
            Console.WriteLine("Last modification date and time:" + directoryInfo1.LastAccessTime);
        
        Console.ReadKey();
        }
    }
}
