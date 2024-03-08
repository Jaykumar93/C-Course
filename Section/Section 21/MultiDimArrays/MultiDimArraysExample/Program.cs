using System;

namespace MultiDimArraysExample
{
    class Program
    {
        static void Main()
        {
            //Jagged Array
            int[][] array = new int [5][];
            array[0]= new int[3] {10,20,30};
            array[1] = new int[4] { 10, 20, 30,40 };
            array[2] = new int[5] { 10, 20, 30,40,50 };
            array[3] = new int[1] { 10 };
            array[4] = new int[2] { 10, 20};

            //Reading Jagged array

            for (int outer = 0; outer < 5; outer++)
            {
                for (int inner = 0; inner <array[outer].Length; inner++)
                {
                    Console.Write(array[outer][inner]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            /*
            // Multi Dimension Array
            int[,] a = new int[4, 3] 
            {
                { 10, 20, 30 },
                { 40, 60, 70 },
                { 80, 90, 100 },
               { 110, 120, 130 }
            };

            for (int row = 0;  row < 4; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(a[row, column]);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            */
        }
    }
}
