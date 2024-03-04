using System;
using ClassLibrary1;


namespace EventExamples
{
    public class Subscriber
    { 

        // target method or Event handler
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
