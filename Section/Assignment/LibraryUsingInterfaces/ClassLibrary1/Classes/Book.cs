using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Classes
{
    public class Book : ILoanable, IPrintable
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int LoanPeriod { get { return 21; } }

        public string Borrower { get; set; }

        public void Borrow(string borrower)
        {
            if (Borrower == null)
            {
                Borrower = borrower;
                Console.WriteLine($" {Borrower} has borrowed {Title} book by {Author}");
            }
            else
            {
                Console.WriteLine($" {Borrower} has already borrowed {Title} book by {Author}");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Book: {Title} by {Author} (ISBN: {ISBN})");


        Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
        }

        public void Return()
        {
            if (Borrower != null)
            {
                Console.WriteLine($"{Title} book by {Author} has been returned by {Borrower}");
                Borrower = null;
            }
            else
            {
                Console.WriteLine($"{Title} book by {Author} is not borrowed by {Borrower}");
            }
        }
    }
}
