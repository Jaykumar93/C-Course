using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceExample
{
    class LivingThing
    {
        public int NumberOfLegs {  get; set; } 
    }

    class Parrot: LivingThing
    {

    }

    class Dog : LivingThing
    {

    }
    
    interface IMover<out T>
    {
        T Move();
    }
    class  Mover<T>:IMover<T>
    {
        public T thing { get; set; }
        public T Move()
        {
            return thing;
        }
    }
    class Program
    {
        static void Main( )
        {
            LivingThing livingthing = new Parrot(); // this is normal behaviour of the class inhiretance
            Parrot parrot = new Parrot() { NumberOfLegs = 2};

            IMover<LivingThing> mover = new Mover<Parrot>();
            Console.WriteLine("Moving with" + mover.Move().NumberOfLegs + "legs");

        }
    }
}
