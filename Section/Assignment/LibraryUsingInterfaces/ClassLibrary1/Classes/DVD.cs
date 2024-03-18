using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes
{
    public class DVD : ILoanable,IPrintable
    {
        public string Director {  get; set; }
        public string Title { get; set; }

        public int LengthInMinutes { get; set; }
        public int LoanPeriod { get { return 7; } }
        public string Borrower { get; set; }


        public void Borrow(string borrower)
        {
            if (Borrower == null)
            {
                Borrower = borrower;
                Console.WriteLine($" {Borrower} has borrowed {Title} DVD by {Director}");
            }
            else
            {
                Console.WriteLine($" {Borrower} has already borrowed {Title} DVD by {Director}");
            }
        }

        public void Print()
        {
            Console.WriteLine($"DVD: {Title} directed by {Director} ({LengthInMinutes} min)");
     
            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
        }

        public void Return()
        {
            if (Borrower != null)
            {
                Console.WriteLine($"{Title} DVD by {Director} has been returned by {Borrower}");
                Borrower = null;
            }
            else
            {
                Console.WriteLine($"{Title} DVD by {Director} is not borrowed by {Borrower}");
            }
        }
    }
}
