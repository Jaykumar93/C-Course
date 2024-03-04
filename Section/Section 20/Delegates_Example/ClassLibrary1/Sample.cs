using System;


namespace ClassLibrary1
{
    public class Sample
    {
        // target method
        public int Add(int a,int b) 
        {
            int c = a + b;
            return c;

        }

        // Target method 1
        public void Add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("Addition is "+c);
        }
        // Target method 2

        public void Multiply(double a, double b)
        {
            double c = a * b;
            Console.WriteLine("Multiplication is " + c);
        }
    }
}
