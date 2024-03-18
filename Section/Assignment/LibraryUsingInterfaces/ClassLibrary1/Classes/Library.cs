using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes
{
    public class Library
    {

        private List<ILoanable> loanableItems;

        public Library()
        {
            loanableItems = new List<ILoanable>();
        }

        public void AddItem(ILoanable item)
        {
            loanableItems.Add(item);
        }
        public void RemoveItem(ILoanable item)
        {
            loanableItems.Remove(item);
        }

        public void PrintLibrary()
        {
            Console.WriteLine("\nLibrary inventory:\n");
            
            foreach (IPrintable item in loanableItems)
            {
                item.Print();
            }
        }

        public void BorrowItem(ILoanable item, string borrower)
        {
            item.Borrow(borrower);
        }

        public void ReturnItem(ILoanable item)
        {
            item.Return();
        }
    }
}
