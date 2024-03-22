using System.Diagnostics;

namespace TaskRun
{
    class UpCounter
    {
        public void CountUp(int count)
        {
            Console.WriteLine("\n Count-Up starts");
            for(int i = 0; i < count; i++)
            {
                Console.Write($"i = {i}, ");
            }
            Console.WriteLine("\nCount-Down ends");
        }
    }
    class DownCounter
    {
        public void CountDown(int count)
        {
            Console.WriteLine("\n Count-Down starts");
            for (int j = count; j >= 1; j--)
            {
                
                Console.Write($"j = {j}, ");
            }
            Console.WriteLine("\nCount-Down ends");
        }
    }

    class Program
    {
        static void Main()
        {
            Stopwatch sw = new Stopwatch();

            //Tasks
            sw.Start();
            WithTask();
            sw.Stop();
            long timeTakenForTasks = sw.ElapsedMilliseconds;
            Console.WriteLine($"Time take by tasks is {timeTakenForTasks}");


            //
            sw.Restart();
            WithThread();
            sw.Stop();
            long timeTakenForThreads = sw.ElapsedMilliseconds;
            Console.WriteLine($"Time take by Threads is {timeTakenForThreads}");

            Console.ReadKey();

        }
        static void WithTask()
        {
            UpCounter upCounter = new UpCounter();
            DownCounter downCounter = new DownCounter();
           // CountdownEvent countdownEvent = new CountdownEvent(2);

            Task task1 = Task.Run(() => {
                upCounter.CountUp(20);
               // countdownEvent.Signal();
            });
            Task task2 = Task.Run(() => {
                downCounter.CountDown(20);
               // countdownEvent.Signal();
            });

            // countdownEvent.Wait();
            //wait can be used just like join and it can be replace countdowneven in tasks
            
           // task1.Wait();
           // task2.Wait();
            
            // can also use waitAll to make all the tasks wait together

            Task.WaitAll(task1,task2);

            Console.ReadLine();
        }

        static void WithThread()
        {
            UpCounter upCounter = new UpCounter();
            DownCounter downCounter = new DownCounter();
            CountdownEvent countdownEvent = new CountdownEvent(2);

            Thread thread1 = new Thread(() => {
                upCounter.CountUp(20);
                countdownEvent.Signal();
            });
            Thread thread2 = new Thread(() => {
                downCounter.CountDown(20);
                countdownEvent.Signal();
            });

            thread1.Start();
            thread2.Start();

            countdownEvent.Wait();

            Console.ReadLine();
        }
    }
}
