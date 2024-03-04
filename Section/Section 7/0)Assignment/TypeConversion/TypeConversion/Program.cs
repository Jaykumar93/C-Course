    class TypeConversion
    {
        static void Main()
        {
            byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
        
            int b = 10; //Convert this value into "short" type (assign into another short type of variable)
        
            string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into                         "decimal" type  using TryParse
        
            decimal d = 20.3M; //Convert this value into "string" type (assign into another string type of variable)

            short a1 = a;
            System.Console.WriteLine(a1);

            short b1 = (short)b;
            System.Console.WriteLine(b1);


            double c1 = double.Parse(c); 
            System.Console.WriteLine(c1);

            bool isConverted = decimal.TryParse(c, out decimal h); //string to decimal
            if (isConverted)
                System.Console.WriteLine(h);
            else
                System.Console.WriteLine("Not converted");

            string d1 = System.Convert.ToString(d);
            System.Console.WriteLine(d1);

            System.Console.ReadKey();
        }
    }