using System;

namespace MainThreadExample
{

    class NumberCounter
    {
        public void CountUp(int count)
        {

            try
            {
                for (int i = 0; i <= count; i++)
                {
                    System.Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.Write($"i = {i}, ");
                    Thread.Sleep(100);
                }
            }
            catch (ThreadInterruptedException ex)
            {
                Console.WriteLine("Count-Up Thread Interrupted");
            }
            
        }

        public void CountDown(int count)
        {
            for (int j = count; j >=0 ; j--) 
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.Write($"j = {j}, ");
                Thread.Sleep(150);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);


            NumberCounter numberCounter = new NumberCounter();

            // single thread working
           // numberCounter.CountUp();
           // numberCounter.CountDown();

            // multithread working
            //Thread1 CountUP
            ThreadStart threadstart1 = new ThreadStart(() => { numberCounter.CountUp(125); });
            Thread thread1 = new Thread(threadstart1);
            thread1.Name = "Count Up Thread";
            Console.WriteLine($"Thread 1 is {thread1.ThreadState.ToString()}");

            thread1.Start();
            Console.WriteLine($"{thread1.Name} ({thread1.ManagedThreadId}) is {thread1.ThreadState.ToString()}");

            // Thread2 CountDown

            ThreadStart threadstart2 = new ThreadStart(()=> { numberCounter.CountDown(125); });
            Thread thread2 = new Thread(threadstart2);
            thread2.Name = "Count Down Thread";

            Console.WriteLine($"Thread 1 is {thread2.ThreadState.ToString()}");

            thread2.Start();
            Console.WriteLine($"{thread2.Name} ({thread2.ManagedThreadId}) is {thread2.ThreadState.ToString()}");

            thread1.Join();
            thread2.Join();

            //Thread.Sleep(2000);
            //thread1.interrupt();
            Console.WriteLine(mainThread.Name + "Completed");
            Console.ReadKey();

        }
    }
}
