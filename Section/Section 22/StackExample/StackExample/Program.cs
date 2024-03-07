using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    internal class Program
    {
        class Student
        {
            public int Marks { get; set; }
            public int Rank {  get; set; }
            static void Main()
            {
                Stack<Student> students = new Stack<Student>();

                //Add
                Console.WriteLine("Push");

                students.Push(new Student() { Marks = 45 });
                students.Push(new Student() { Marks = 65 });
                students.Push(new Student() { Marks = 23 });
                students.Push(new Student() { Marks = 86 });

                //foreach loop
                int r = 1;
                foreach (Student score in students)
                {
                    score.Rank = r;
                    Console.WriteLine(score.Marks+" -- "+score.Rank);
                    r++;
                }

                Console.WriteLine("_______________________________________________");

                Console.WriteLine("Pop");

                //Remove
                Student drop = students.Pop();
                foreach (Student score in students)
                {
                    Console.WriteLine(score.Marks + " -- " + score.Rank);
             
                }
                Console.WriteLine("_______________________________________________");


                Console.WriteLine(drop.Marks + " -- " + drop.Rank);

             

                Console.ReadKey();
            }

        }
    }
}
