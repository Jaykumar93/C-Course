using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces
{
    public interface ILoanable
    {
        int LoanPeriod { get; }
        string Borrower { get; set; }
        void Borrow(string Borrower);
        void Return();
    }
}
