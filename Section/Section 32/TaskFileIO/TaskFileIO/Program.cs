namespace TaskFileIO
{

    class FileWriter
    {
        public Task WriteFile(string fileName, string content)
        {
            StreamWriter writer = new StreamWriter(fileName);
            Task writerTask = writer.WriteAsync(content);

            writer.Close();
            return writerTask;

        }
    }
    class FileReader
    {
        public Task<string> ReadFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            Task<string> writerTask = reader.ReadToEndAsync();

            reader.Close();
            return writerTask;

        }
    }
  
    internal class Program
    {
        static void Main()
        {
            string fileName = @"C:\Users\Coditas-Admin\Documents\C #\Section\Section 32\India.txt       ";
            FileWriter fileWriter = new FileWriter();
            FileReader fileReader = new FileReader();

            Task writerTask = fileWriter.WriteFile(fileName, "India is my country");

            writerTask.Wait();

            Console.WriteLine("File written...........");

            Task<string> readerTask = fileReader.ReadFile(fileName);

            readerTask.Wait();

            Console.WriteLine("File read..............");

            Console.WriteLine($"\nFile content : " +
                $"{readerTask.Result}");

        }
    }
}
