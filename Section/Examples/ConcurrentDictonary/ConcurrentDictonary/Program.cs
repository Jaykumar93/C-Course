using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static ConcurrentDictionary<int, string> keyValuePairs = new ConcurrentDictionary<int, string>();

    static void Main(string[] args)
    {   

        Thread thread1 = new Thread(AddToDictionary);
        Thread thread2 = new Thread(AddToDictionary);
        thread1.Start();
        thread1.Name = "THREAD NO 1";
        thread2.Start();
        thread2.Name = "THREAD NO 2";

    }

    static void AddToDictionary()
    {
        Random random = new Random();
        for (int i = 0; i < 100; i++) 
        {
            int key = random.Next(100);
            keyValuePairs.TryAdd(key, Thread.CurrentThread.Name); 
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} added to dictionary with key {key}");
            Thread.Sleep(10); 
        }
    }
}
