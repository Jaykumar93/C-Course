using ClassLibrary1;

namespace LiftSimulation
{

  
    internal class Program
    {
        static void Main()
        {
            system();
        }
        static void system()
        {
            Lift lift = new Lift();
            Console.WriteLine("Enter the floor to call the Lift: ");
            int floor = Convert.ToInt32(Console.ReadLine());
            do
            {
                lift.LiftCall(floor);
                lift.CurrentFloor = floor;
                Console.WriteLine("Enter The Direction, UP(1), Down(0): ");
                int direction = Convert.ToInt32(Console.ReadLine());
                lift.ElevatorUp = direction == 1 ? true : false;
                lift.ElevatorDown = direction == 0 ? true : false;
                lift.LoadingRiders();
                if (lift.ElevatorUp)
                {
                    lift.GoUp();
                }
                else if (lift.ElevatorDown)
                {
                    lift.GoDown();
                }
                Console.WriteLine("Enter the floor to call the Lift: ");
                floor = Convert.ToInt32(Console.ReadLine());
            } while (true);
        }
    }
}
