using System;
using System.IO;

namespace FileStreamExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 27\TempFileCreated\dog.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            //FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.Create(filePath);
            //FileStream fileStream = File.Open(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.OpenWrite(filePath);
            //FileStream fileStream = fileInfo.Create();
            //FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.Write);
            FileStream fileStream = fileInfo.OpenWrite();

            string content = "Dog is one of the domestic animals.";

            byte[] convertedContent = System.Text.Encoding.ASCII.GetBytes(content);

            fileStream.Write(convertedContent, 0, convertedContent.Length);

            FileStream filestream2 = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read); 
            byte[] byteRead = new byte[filestream2.Length];

            filestream2.Read(byteRead, 0, (int)filestream2.Length);

            Console.ReadKey();

        }
    }
}
