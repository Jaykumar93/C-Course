using System;

class AreaOfCircle
{
    static void Main()
    {
        double Radius = 10D;
        double PI = 3.149;

        double Area = PI * (Radius * Radius);

        Console.WriteLine("The Area of the circle with radius " + Radius + " is " + Area);

        Console.ReadKey();
    }
}