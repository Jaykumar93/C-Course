class FeetToCentimeter
{
    static void Main()
    {
        double feet = 5;

        double inch = 7;

        double centimeter = ((feet * 12) * 2.54) + (inch * 2.54);

        System.Console.WriteLine(feet + " feet and" + inch + "inch in centimeter is " + centimeter);
        System.Console.ReadKey();
    }
}