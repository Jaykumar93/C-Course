using System;
using ClassLibrary1;

namespace EventExamples
{
    class Program
    {
        static void Main()
        {

            // for anonymous class we dont need to create a subscriber class the the event handler is defined in the program class itself
            //thats why the program class becomes the subscriber class itself
         

            Publisher publisher = new Publisher();

            
            publisher.MyEvent += delegate (int a, int b)
            {
                int c = a + b;
                return c;
            };

            Console.WriteLine(publisher.RaiseEvent(10, 5));


            // LAMBDA EXPRESSION 

            // data types of variable is not necessary here since we have already declared them in Publisher while created delega
            publisher.MyEvent += (a, b)=>
            {
                int c = a * b;
                return c;
            };

            // INLINE LAMBDA EXPRESSION
            publisher.MyEvent += (a, b) =>  a + b;
          


            Console.WriteLine(publisher.RaiseEvent(10, 5));


            /*
             //Object of Subscriber class
            Subscriber subscriber = new Subscriber();

            //Object of Publisher class
            Publisher publisher = new Publisher();

            //handle to the event or subscribe to the event

            publisher.MyEvent += subscriber.Add;

             */
            Console.ReadKey();

        }
    }
}
