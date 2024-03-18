using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes
{
    public class CD : ILoanable, IPrintable
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public int LoanPeriod { get { return 14; } }
        public string Borrower { get; set; }

        public void Borrow(string borrower)
        {
            if (Borrower == null)
            {
                Borrower = borrower;
                Console.WriteLine($" {Borrower} has borrowed {Album} CD by {Artist}");
            }
            else
            {
                Console.WriteLine($" {Borrower} has already borrowed {Album} CD by {Artist}");
            }
        }

        public void Print()
        {
            Console.WriteLine($"CD: {Album} by {Artist} ({(Borrower == null ? "available" : "borrowed by " + Borrower)})");
    

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
        }

        public void Return()
        {
            if (Borrower != null)
            {
                Console.WriteLine($"{Album} CD by {Artist} has been returned by {Borrower}");
                Borrower = null;
            }
            else
            {
                Console.WriteLine($"{Album} CD by {Artist} is not borrowed by {Borrower}");
            }
        }
    }
}
