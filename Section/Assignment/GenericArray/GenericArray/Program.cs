using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace GenericArray
{

    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main()
        {
            Database<int, string> databaseOfUser = new ClassLibrary1.Database<int, string>();

            databaseOfUser.Add(1,"Jay");
            databaseOfUser.Add(1, "kartik");
            databaseOfUser.Add(1, "avinash");

        }
    }
}
