using System;

namespace BinaryExample
{
    class Program
    {
        static void Main()
        {
            int dec1 = 21;
            string binary1 = Convert.ToString(dec1, 2); //decimal into binary
            Console.WriteLine(binary1);

            int dec2 = Convert.ToInt32(binary1, 2); //binary to decimal
            Console.WriteLine(dec2);

            //binary literals
            int n = 0b11010; //100
            Console.WriteLine(n);

            ////
            //OCTAL NUMBER
            ////
            ///
            Console.WriteLine("\n_______________________________________________________________________\n");
            int num = 123;
            string OctalNum =  Convert.ToString(num, 8);
            Console.WriteLine(OctalNum);

            int NumOriginal = Convert.ToInt32(OctalNum, 8); //octal to decimal
            Console.WriteLine(NumOriginal);


            ////
            //HEXADECIMAL NUMBER
            ////
            ///
            Console.WriteLine("\n_______________________________________________________________________\n");
            
            string HexadecimalNum = Convert.ToString(num, 16);
            Console.WriteLine(HexadecimalNum);

            int Original = Convert.ToInt32(HexadecimalNum, 16); //octal to decimal
            Console.WriteLine(Original);


            Console.ReadKey();

        }
    }
}
