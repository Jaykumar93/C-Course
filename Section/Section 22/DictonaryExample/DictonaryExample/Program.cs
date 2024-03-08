using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictonaryExample
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<int,string> employee = new Dictionary<int,string>()
            {
                { 101, "Jaykumar"},
                {102,"Kartik" },
                {103,"Avinash" },
                {104,"Keval" }
            };

            foreach(KeyValuePair<int,string> item in employee)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
            string s = employee[101];
            Console.WriteLine(s);

            Dictionary<int,string>.KeyCollection keys = employee.Keys;

            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            bool a = employee.ContainsKey(103);
            Console.WriteLine(a);

            bool b = employee.ContainsValue("Jay");
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
