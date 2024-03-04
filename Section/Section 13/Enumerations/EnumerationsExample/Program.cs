using System;

class Program
{
    static void Main()
    {
        //create object of Person class
        Person person = new Person("jaykumarpokar@gmail.com");

        Console.WriteLine(person.PersonName);
        Console.WriteLine(person.Email);
      //  person.AgeGroup = AgeGroupEnumeration.Adult;
        
       // Console.WriteLine(person.AgeGroup);
        Console.ReadKey();
    }
}

