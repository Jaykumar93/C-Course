using System;

class greatestOfThree
{
    static void Main()
    {
        int num1 = 60;
        int num2 = 455;
        int num3 = 123;
        /*
        if (num1 > num2 && num1 > num3)
        {
            System.Console.WriteLine(num1);
        }
        if (num2 > num1 && num2 > num3)
        {
            System.Console.WriteLine(num2);
        }
        else
        {
            System.Console.WriteLine(num3);
        }
        System.Console.ReadKey();
        */
        int biggest;
        if (num1 > num2)
        {
            if(num1 > num3)
            {
                biggest = num1;
            }
            else
            {
                biggest = num3;
            }
        }
        else 
        {
            if ( num2 > num3)
            {
                biggest = num2;
            }
            else
            {
                biggest = num3;
            }
            
        }
        System.Console.WriteLine(biggest);
        System.Console.ReadKey();
    }

}