class program
{
    static void Main()
    {

        MarksPrinter<GraduateStudent> mp = new MarksPrinter<GraduateStudent>();
        mp.stu = new GraduateStudent() {Marks=23};

        mp.PrintMarks();
        System.Console.ReadKey();

        /*

                User<int, int > user1 = new User<int,int>();
                User<bool,string> user2 = new User<bool,string>();

                user1.RegistrationStatus = 2133;
                user2.RegistrationStatus = true;

                user1.age = 21;
                user2.age = "35-40";

                System.Console.WriteLine(user1.RegistrationStatus);
                System.Console.WriteLine(user1.age);
                System.Console.WriteLine(user2.RegistrationStatus);
                System.Console.WriteLine(user2.age);
                 System.Console.ReadKey();*/




    }
}