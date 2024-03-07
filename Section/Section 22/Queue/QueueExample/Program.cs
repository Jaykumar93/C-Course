using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main()
        {
            //create an object of Queue class
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("\n\nInserting using Enqueue\n");

            //Enqueue (Add)
            queue.Enqueue("Task 3");
            queue.Enqueue("Task 5");
            queue.Enqueue("Task 1");
            queue.Enqueue("Task 4");
            queue.Enqueue("Task 2");

            //foreach
            foreach (string item in queue)
            {
                Console.WriteLine(item); //Task 3, Task 5, ...
            }

            //Dequque

            queue.Enqueue("\n\nDeleting using Dequeue\n");

            string dq = queue.Dequeue();
            Console.WriteLine("Dequeue and stored: " + dq); //Task 3

            string dq2 = queue.Dequeue();
            Console.WriteLine("Dequeue and stored: " + dq2); //Task 5

            //Peek
            queue.Enqueue("\n\n Peeking The values \n");

            string pk = queue.Peek();
            Console.WriteLine("Peek: " + pk); //Task 1

            //foreach
            foreach (string item in queue)
            {
                Console.WriteLine(item); //Task 1, Task 4, Task 2
            }

            Console.ReadKey();
        }
    }
}
