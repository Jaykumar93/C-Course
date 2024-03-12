using System.Collections.Generic;

public class list
{
    static void Main()
    {
        List<List<int>> NestedList = new List<List<int>>()
    {
        new List<int>( ) { 67, 100, 23 },
        new List<int>( ) { 80, 99, 750, 99 },
        new List<int>( ) { 888, 333, 9898 },
        new List<int>( ) { 21, 231213, 98198 }
    };
        List<int> ListOfMax = new List<int>();

        foreach (var innerlist in NestedList)
        {
            int MaxNumber = -1;
            foreach (var element in innerlist)
            {
                if(element > MaxNumber )
                {
                    MaxNumber = element;
                }

            }
            ListOfMax.Add( MaxNumber ); 
        }

        foreach(var element in ListOfMax)
        {
            Console.WriteLine(element);
        }
    }




}