using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main()
        {

            List<string> list = new List<string>()
            { "Scott","Allen","James","John" };

            list.ForEach(x => Console.WriteLine("This is "+x));




            Console.WriteLine("_________________________________________________________________________");

            List<int> num = new List<int>() { 10, 20, 30, 40, 50, 60 };


            Console.WriteLine(num.Exists(n => n > 50));

            Console.WriteLine(num.Find(n => n%20 ==0));

            Console.WriteLine(num.FindIndex(n => n % 20 == 0));

            Console.WriteLine(num.FindLast(n => n % 20 == 0));

            Console.WriteLine(num.FindLastIndex(n => n % 20 == 0));

            List<int> twentyMode =  num.FindAll(n => n % 20 == 0);

            foreach(int i in twentyMode) 
            { 
                Console.WriteLine("findALl"+i);
            }

            list.ConvertAll(n => Convert.ToDecimal(n));

            //create reference variable for List class & create object of List class
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            // ===> Add New element at the end of the existing collection

            myList.Add(40); // ADD can only add 1 data 

            // Adding new list to the previous list
            List<int> myList2 = new List<int>() { 50,60, 70 };

            myList.AddRange(myList2);


            // insert value at specific index 

            myList.Insert(1, 100);

            myList.InsertRange(1, myList2);
            

            // remove 

            myList.Remove(30); // provide value and it search 
            myList.RemoveAt(2); // provide index



            myList.RemoveRange(1, 2); // start point and no of element to be removed

            // to remove elements with condition
            myList.RemoveAll(n=> n > 30);
            myList.Clear();

            // IndexOf

            
            Console.WriteLine(myList2.IndexOf(40));

            Console.WriteLine(myList2.BinarySearch(50));


            myList2.Sort();

            //read elements using foreach loop  
            Console.WriteLine("Using foreach loop:");
            foreach (int item in myList)
            {
                Console.WriteLine(item); //Output: 10 20 30
            }

            Console.ReadKey();
        }
    }
}
