using System;
using ClassLibrary1;

namespace IDisposableExample
{
    class Program
    {

        static void DoWork()
        {
            using Sample s = new Sample();
            s.DisplayDataFromDatabase();

            
        }
        static void Main()
        {
            //create object using "using structure"
            // at the end of the using structure the memory get despose

            DoWork();
            Console.WriteLine("Some other work here");

            Console.ReadKey();
        }
    }
}
