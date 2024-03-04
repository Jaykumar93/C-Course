using System.Data.SqlTypes;

class NearestThousands
{
    static void Main()
    {
        int number = 3852;

        decimal decNum = number;
        System.Console.WriteLine(decNum);

        decimal last_three_digits_with_decimal = (decNum/1000);

        System.Console.WriteLine(last_three_digits_with_decimal);

        int last_three_digits_with_integer = (number/ 1000);
        System.Console.WriteLine(last_three_digits_with_integer);

        decimal last_three_digits = (last_three_digits_with_decimal-last_three_digits_with_integer)*1000;
        System.Console.WriteLine(last_three_digits);

        int round_off = (last_three_digits >= 500) ? 1000 : 0;
        System.Console.WriteLine(round_off);

        int previous_thousand = (number / 1000) * 1000;

        System.Console.WriteLine(previous_thousand);

        int solution = previous_thousand + round_off;

        System.Console.WriteLine(solution);
        System.Console.ReadKey();
    }


}