using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Anonymouse_Type
{
    internal class Program
    {
        static void Main()
        {
            Person p = new Person();


            // call methods
            p.GetPersonName();
            p.GetPersonAge();

            var person = new
            {
                PersonName = p.GetPersonName(),
                PersonAge = p.GetPersonAge(),
                //nested anynomous object
                Address = new { Street = "abc", City = "xyz" }
            };
            Console.WriteLine(person.PersonName);
            Console.WriteLine(person.PersonAge);
            Console.WriteLine(person.Address.Street);
            Console.WriteLine(person.Address.City);


            //Anonymous Array : implicitly typed array

            var personArray = new[]
            {
                new{personName = "Scott",Email ="scott@gmail.com" },
                new{personName = "John",Email ="John@gmail.com" },
                new{personName = "Smith",Email ="smith@gmail.com" },
                new{personName = "Josh",Email ="josh@gmail.com" },
                //for anonymous array you need same types of values and in the same sequences
            };
            foreach(var input in personArray)
            {
                Console.WriteLine(input.personName);
                Console.WriteLine(input.Email);

                Console.WriteLine();
                

            }
            Console.ReadKey();
        }
    }

}
