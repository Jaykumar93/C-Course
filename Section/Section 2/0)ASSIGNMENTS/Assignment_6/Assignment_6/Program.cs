class HeightCategory
{
    static void Main()
    {
        double height_inch = 75;

        double height_cm = height_inch * 2.54;
        if(height_cm >0)
        {
            if (height_cm < 150)
            {
                System.Console.WriteLine("Dwarf: "+height_cm+"cm");
            }
            else if (height_cm >= 150 && height_cm < 165)
            {
                System.Console.WriteLine("Average height: " + height_cm + "cm");

            }
            else if (height_cm >= 165 && height_cm < 195)
            {
                System.Console.WriteLine("Tall: " + height_cm + "cm");

            }
            else
            {
                System.Console.WriteLine("Abnormal height: " + height_cm + "cm");
            }
        }
        System.Console.ReadKey(); 
    }
}