using System;

class Program
{
    static void Main()
    {

        //Boxing
        int x = 12;
        int y = 10;

        /* here i have created a integer and assigned it to a object obj now if i want to use that integer as object i can directly call it  into differet class and make change and it will be saved in obj
         but x will remain as it is*/
        Console.WriteLine("Boxing");

        object obj = x;
        Console.WriteLine(obj);

        Console.WriteLine(x);

        obj = 13;

        Console.WriteLine(obj);
        Console.WriteLine(x);

        Console.WriteLine("");

        //Unboxing

        Console.WriteLine("Unboxing");

        object unboxing_obj = 43;

        int int_y = (Int32)unboxing_obj;

        Console.WriteLine(unboxing_obj);
        Console.WriteLine(int_y);

        unboxing_obj = 21;

        Console.WriteLine(unboxing_obj);
        Console.WriteLine(int_y);





        /*

        //create an object of Person class
        System.Object obj = new Person() { PersonName = "Scott", Email = "scott@gmail.com" };

        //access methods
        Console.WriteLine(obj.Equals(new Person() { PersonName = "Scott", Email = "scott@gmail.com" }));
        Console.WriteLine(obj.GetHashCode());
        Console.WriteLine(obj.ToString());
        Console.WriteLine(obj.GetType().ToString());

        */
        Console.ReadKey();
    }
}


