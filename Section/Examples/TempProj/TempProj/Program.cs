using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a SortedList
        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");

        // Convert the SortedList to a Dictionary
        Dictionary<int, string> dictionary = ConvertSortedListToDictionary(sortedList);

        // Display the Dictionary
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        Console.ReadKey();
    }

    static Dictionary<TKey, TValue> ConvertSortedListToDictionary<TKey, TValue>(SortedList<TKey, TValue> sortedList)
    {
        Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
        foreach (var kvp in sortedList)
        {
            dictionary.Add(kvp.Key, kvp.Value);
        }
        return dictionary;
    }
}
