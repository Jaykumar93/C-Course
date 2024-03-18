using ClassLibrary1.Classes;

namespace LibraryUsingInterfaces
{
    internal class Program
    {
        static void Main()
        {

            Library library = new Library();

            Book book1 = new Book
            {
                Author = "Rabindranath Tagore",
                Title = "Gitanjali",
                ISBN = "9780195634067",
            };


            Book book2 = new Book
            {
                Author = "Arundhati Roy",
                Title = "The God of Small Things",
                ISBN = "9780679457312"
            };

            Book book3 = new Book
            {
                Author = "Salman Rushdie",
                Title = "Midnight's Children",
                ISBN = " 9780676974855",
            };

            library.AddItem(book1);
            library.AddItem(book2);
            library.AddItem(book3);


            library.PrintLibrary();

            library.BorrowItem(book1, "Jay");

            library.BorrowItem(book1, "Jay");

            DVD dvd = new DVD
            {
                Title = "3 Idiots",
                Director = "Rajkumar Hirani",
                Borrower = "Priya Patel"
            };

            //dvd.Print();


            CD cd = new CD
            {
                Artist = "A.R. Rahman",
                Album = "Jodhaa Akbar",
                Borrower = "Rajesh Kumar"
            };

            //cd.Print();


            
        }
    }
}
