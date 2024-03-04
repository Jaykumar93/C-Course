class PatternAssignment
{
    static void Main()
    {
        for(int row = 1; row <= 8; row++)
        {
            if(row ==4 || row == 5 || row == 6 || row == 7)
            {
                for (int col = 10; col >= 1; col--)
                {
                    if(row == 6 && col ==2)
                    {
                        break;
                    }
                    System.Console.Write(col);
                    System.Console.Write(" ");

                }
            }
            else
            {
                for (int col = 1; col <= 10; col++)
                {
                    if (col == 5 || col == 6)
                    {
                        continue;
                    }
                    System.Console.Write(col);
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine(" ");
        }
        System.Console.ReadKey();
    }
}