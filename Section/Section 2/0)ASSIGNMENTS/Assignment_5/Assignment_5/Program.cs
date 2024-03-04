class secondConversion
{
    static void Main()
    {
        int seconds = 288970;

        int days = seconds / 86400;
        int updated_seconds =seconds % 86400;

        int hours = updated_seconds / 3600;
        updated_seconds %= 3600;

        int minutes = updated_seconds / 60;
        updated_seconds %= 60;

        System.Console.WriteLine(seconds +" seconds is "+days+" days "+hours+" hours "+minutes+" minutes and "+updated_seconds+ " seconds");

        System.Console.ReadKey();
    }
}