using System;

namespace ArraysExample
{
    class Program
    {
        static void Main()
        {
            //Array Resize
            int[] num1 = new int[3] { 10, 20, 30 };
            Array.Resize(ref num1, 2);
            Console.WriteLine(num1[1]);



            // binary search
            int[] num = new int[5] { 10, 20, 30, 40,50 };
            int n = Array.BinarySearch(num, 30);
            Console.WriteLine(n);

            Console.WriteLine();



            // declaration of the array
            int[] a = new int[5] { 10, 20, 30, 40, 30 };
            string[] b = new string[5] { "one", "two", "three", "four", "five" };

            // IndexOf
            n = Array.IndexOf(a, 30);
            Console.WriteLine(n);

            n = Array.IndexOf(a, 30,3);
            Console.WriteLine(n);

            n = Array.IndexOf(a, 34);
            Console.WriteLine(n);

            Console.WriteLine();

            // to find the second 30 int
            // we need to start searching for 3 index for that we use 
            foreach (int element in a)
            {
                Console.WriteLine(element);
            }


            Console.WriteLine();


            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }


            Console.WriteLine();


            for (int i = b.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(b[i]);
            }

            Array.Clear(a, 0, a.Length);

            Console.ReadKey();

            foreach (int element in a)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
