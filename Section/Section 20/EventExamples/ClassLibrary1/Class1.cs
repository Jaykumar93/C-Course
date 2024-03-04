using System;

namespace ClassLibrary1
{

    // PUBLISHER 
    public delegate int MyDelegateType(int a , int b);

    public class Publisher
    {


        // Auto implemented events 
        // it provides shortcut to implement the events 
        public event MyDelegateType MyEvent;

        public int RaiseEvent(int a , int b)
        {
            if(this.MyEvent != null)
            {
                int x = this.MyEvent(a, b);
                //return x;
                // action 
                Console.WriteLine(x);
            }
            else
            { 
                return 0; 
            }
        }


        // Creating delegate using Func

        public event Func<int,int ,int> myEvent;


        public event Action<int, int> myEvent;
        /*
         // Private Delegate

        private MyDelegateType myDelegate;

        //Step 1: CREATE EVENT

        public event MyDelegateType MyEvent
        {
            add
            {
                myDelegate += value;
            }
            remove
            {
                myDelegate -= value;

            }
        }

        public void RaiseEvent(int a, int b)
        {
            // step 2: Raise the event

            if (myDelegate != null)
            {
                this.myDelegate(a, b);
            }
        }
         */
    }
}
