using System;
using ClassLibrary1;

namespace Delegates_Example
{
    internal class Program
    {
        static void Main()
        {

            //create an object
            Sample MultipleSample = new Sample();

            MyDelegateTypeMultiple myDelegate;


            myDelegate = new MyDelegateTypeMultiple(MultipleSample.Add);

            myDelegate = MultipleSample.Add;


            myDelegate += MultipleSample.Multiply;

            myDelegate.Invoke(5, 5);
            myDelegate(5, 5);

            Console.ReadKey();
            /*
            Sample s = new Sample();

            // create a delegate object 

            MyDelegateType myDelegate;

            // add method reference to delegate

            myDelegate = new MyDelegateType(s.Add);

            //invoke method using delegates object

            myDelegate(8, 9);
            */


        }
    }
}
