using System.Data;

class LoginPage
{
    static void Main()
    {
        System.Console.WriteLine("******************** Kumar's Bank ********************\n");
        System.Console.WriteLine("::Login Page::\n");

        string userName = null,password = null;


        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        if(userName != null)
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }
        
        if(userName == "system" && password == "manager") 
        {
            int mainMenuChoice = -1;
            do
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("<=:: Main menu here ::=>");
                System.Console.WriteLine("");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Fund Transfer");
                System.Console.WriteLine("4. Fund Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.WriteLine("\nEnter Your Choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());


                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;

                    case 2:
                        AccountMenu();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 0:
                        break;

                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }

        System.Console.WriteLine("\n<----------Thank You---------->");

        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        int customerMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n::: Customers Menu :::");
            System.Console.WriteLine("1. Add Customers");
            System.Console.WriteLine("2. Delete Customers");
            System.Console.WriteLine("3. Update Customers");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0 Back to Main Menu");

            System.Console.WriteLine("\nEnter Your Choice: ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (customerMenuChoice !=0);
    }

    static void AccountMenu()
    {
        int AccountMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n::: Account Menu :::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Account");
            System.Console.WriteLine("0 Back to Main Menu");

            System.Console.WriteLine("\nEnter Your Choice: ");
            AccountMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (AccountMenuChoice != 0);
    }
    
}