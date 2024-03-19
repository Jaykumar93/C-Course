using System;
using System.IO;

namespace FileInfoExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\japan.txt";
            string destPath = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\another.txt";
            string destPath2 = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\somethingelse.txt";

            FileInfo fileInfo = new FileInfo(filePath);
            File.WriteAllText(destPath, "My name is jay");
            //Create()
            fileInfo.Create().Close();
            Console.WriteLine("japan.txt created");

            //CopyTo()
            FileInfo fileInfo2 = fileInfo.CopyTo(destPath, true);
            Console.WriteLine(fileInfo2.Name + " created");

            //MoveTo()
            fileInfo2.MoveTo(destPath2);
            Console.WriteLine(fileInfo2.Name + " moved");

            //Delete()
            fileInfo2.Delete();
            Console.WriteLine(fileInfo2.Name + " deleted");

            string filePath1 = @"c:\practicee\japan.txt";
            FileInfo fileInfo1 = new FileInfo(filePath);
            Console.WriteLine("Exists: " + fileInfo1.Exists);
            if (fileInfo1.Exists)
            {
                Console.WriteLine("FullName: " + fileInfo1.FullName);
                //string s = fileInfo.FullName;
                Console.WriteLine("Name: " + fileInfo1.Name);
                Console.WriteLine("DirectoryName: " + fileInfo1.DirectoryName);
                Console.WriteLine("Extension: " + fileInfo1.Extension);
                Console.WriteLine("Length: " + fileInfo1.Length + " bytes");
                Console.WriteLine("LastWriteTime: " + fileInfo1.LastWriteTime);
                Console.WriteLine("LastAccessTime: " + fileInfo1.LastAccessTime);
                Console.WriteLine("CreationTime: " + fileInfo1.CreationTime);
            }
            else
            {
                Console.WriteLine("File not found");
            }

            Console.ReadKey();

        }
    }
}
