using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExamples
{
    class sample
    {
        public Tuple<string,int> GetPersonDetails()
        {
            Tuple<string,int> tuple = new Tuple<string,int>("Jaykumar",22);

            return tuple;
        }
    }
    internal class Program
    {
      
        static void Main()
        {
            sample s = new sample();

            Tuple<string,int> person = s.GetPersonDetails();


            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);

        }
    }
}
