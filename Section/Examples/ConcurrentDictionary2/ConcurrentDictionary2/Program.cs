using System;
using System.Collections.Generic;
using System.Threading;

class CustomDictionary<TKey, TValue>
{
    private Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

    public void Write(object obj)
    {
        var parameters = (Tuple<TKey, TValue>)obj;
        dictionary[parameters.Item1] = parameters.Item2;
        Console.WriteLine($"Added: Key = {parameters.Item1}, Value = {parameters.Item2}");
        
    }

    public void Read(object obj)
    {
        var key = (TKey)obj;
        TValue value = dictionary[key];
        Console.WriteLine($"Read: Key = {key}, Value = {value}");
        
    }

    public void Remove(object obj)
    {
        var key = (TKey)obj;
        dictionary[key] =default(TValue);
        Console.WriteLine($"Removed: Key = {key}"); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomDictionary<int, string> customDictionary = new CustomDictionary<int, string>();

        // Create three threads using ParameterizedThreadStart delegates
        Thread thread1 = new Thread(new ParameterizedThreadStart(customDictionary.Write));
        Thread thread2 = new Thread(new ParameterizedThreadStart(customDictionary.Read));
        Thread thread3 = new Thread(new ParameterizedThreadStart(customDictionary.Remove));

        // Start the threads
        thread1.Start(Tuple.Create(1, "One"));
        thread2.Start(1);
        thread1.Start(Tuple.Create(2, "Two"));
        thread2.Start(2);
        thread3.Start(3);

       

        // Wait for all threads to complete
        thread1.Join();
        thread2.Join();
        thread3.Join();
    }
}
