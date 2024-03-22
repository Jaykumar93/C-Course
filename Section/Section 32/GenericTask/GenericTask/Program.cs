using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskRun
{
    class UpCounter
    {
        public long CountUp(int count)
        {
            long sum = 0;
            Console.WriteLine("\n Count-Up starts");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"i = {i}, ");
                sum += i;
            }
            Console.WriteLine("\nCount-Down ends");
            return sum;
        }
    }
    class DownCounter
    {
        public long CountDown(int count)
        {
            long sum = 0;
            Console.WriteLine("\n Count-Down starts");
            for (int j = count; j >= 1; j--)
            {

                Console.Write($"j = {j}, ");
                sum += j;
            }
            Console.WriteLine("\nCount-Down ends");
            return sum;
        }
    }

    class Program
    {
        static void Main()
        {

            UpCounter upCounter = new UpCounter();
            DownCounter downCounter = new DownCounter();
            

            Task<long> task1 = Task.Factory.StartNew(() => {
                return upCounter.CountUp(20);
            });
            Task<long> task2 = Task.Factory.StartNew(() => {
                return downCounter.CountDown(20);
            });

           

            Task.WaitAll(task1, task2);
            Console.WriteLine($"Result of the Count_Up method ={task1.Result} ");
            Console.WriteLine($"Result of the Count_Down method ={task2.Result} ");
            Console.ReadKey();

        }
       

    }
}
