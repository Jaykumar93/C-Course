class Program
{
    static void Main()
    {
        // arthmetical Operators 

        decimal a = 10M;
        decimal b = 12M;

        decimal c = a + b;
        decimal d = a - b;
        decimal e = a * b;
        decimal f = a / b;
        decimal g = a % b;

        System.Console.WriteLine("arthmetical Operators :");
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);    
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);

        //Assignment Operators;
        System.Console.WriteLine();

        System.Console.WriteLine("Assignment Operators :");
        a += 20M;
        System.Console.WriteLine(a);
        a -= 30M;
        System.Console.WriteLine(a);
        a *= 4M;
        System.Console.WriteLine(a);
        a /= 3M;
        System.Console.WriteLine(a);
        a %= 12M;
        System.Console.WriteLine(a);

        //Increment  Operators;
        System.Console.WriteLine();
        System.Console.WriteLine("Increment Operators :");

        a = 10M;
        System.Console.WriteLine(a++);
        System.Console.WriteLine(++a);
        System.Console.WriteLine(a--);
        System.Console.WriteLine(--a);



        //Comparision Operators
        System.Console.WriteLine();
        System.Console.WriteLine("Comparisions Operators :");

        bool b1 = a == 10;
        System.Console.WriteLine(b1);
        bool b2 = a!= 10;
        System.Console.WriteLine(b2);
        bool b3 = a < 20;
        System.Console.WriteLine(b3);
        bool b4 = a > 340;
        System.Console.WriteLine(b4);


        //Logical Operators
        System.Console.WriteLine();
        System.Console.WriteLine("Logical Operators :");

        bool b5 = a==10 & b == 10;
        System.Console.WriteLine(b5); // false
        bool b6= a == 10 && b == 10;
        System.Console.WriteLine(b6); // false

        bool b7 = a == 10 | b == 10;
        System.Console.WriteLine(b7); // true
        bool b8 = a == 10 || b == 10;
        System.Console.WriteLine(b8); // true

        bool b9 = !(a == 10);
        System.Console.WriteLine(b9);


        //Concatenation Operators
        System.Console.WriteLine();
        System.Console.WriteLine("Concatenation Operators :");


        string userName = "Jaykumar";
        int age = 21;
        System.Console.WriteLine("Hey ther, "+userName+".My age is "+age);

        //ternary operators
        System.Console.WriteLine();

        System.Console.WriteLine("Ternary Operators :");
        string title = (age < 13) ? "Child" : (age > 13 && age <= 19) ? "Teenager" : "Adult";

        System.Console.WriteLine(title);

        System.Console.ReadKey();
    }
}