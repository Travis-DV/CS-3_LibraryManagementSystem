using System.ComponentModel;
using Validator;

namespace LibraryManagementSystem
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            LibraryManagementSystem l = new LibraryManagementSystem();
        }
    }

    public class LibraryManagementSystem
    {

        public List<Book> books = new List<Book>();
        public List<Borrower> borrowers = new List<Borrower>();
        public List<Borrow> borrows = new List<Borrow>();

        public LibraryManagementSystem()
        {
            books.Add(new Book()
            {
                BookId = books.Count,
                Title = "Revenge of The Sith",
                Author = "George Lucas",
                PublicationDate = DateTime.Now,
                IsBorrowed = false,
            });
            books.Add(new Book()
            {
                BookId = 9999,
                Title = "Harry Potter and the Goblet of Fire",
                Author = "J. K. Rowling",
                PublicationDate = DateTime.Now,
                IsBorrowed = true,
            });

            borrowers.Add(new Borrower()
            {
                BorrowerId = borrowers.Count,
                Name = "Test1",
                Email = "test1@test.com",
                DateOfMembership = DateTime.Now,
            });
            borrowers.Add(new Borrower()
            {
                BorrowerId = borrowers.Count,
                Name = "Test2",
                Email = "test2@test.com",
                DateOfMembership = DateTime.Now,
            });

            borrows.Add(new Borrow()
            {
                BorrowId = borrows.Count,
                BookId = 1,
                BorrowerId = 1,
                BorrowDate = DateTime.Now,
            });
            borrows.Add(new Borrow()
            {
                BorrowId = borrows.Count,
                BookId = 0,
                BorrowerId = 1,
                BorrowDate = DateTime.Now,
            });

            Menu();
        }

        private void Menu()
        {
            Console.Clear();
            Console.WriteLine(@"--- Library Management System ---
1. View Books
2. View Borrows
3. Calculate Total Borrows
4. Exit");

            string? key = Console.ReadLine();
            int Choice = -1;

            if (key == null || !int.TryParse(key, out Choice))
            {
                Menu();
            }

            switch (Choice)
            {
                case 1:
                    ListAll("Book List: ", books);
                    Menu();
                    break;
                case 2:
                    ListBorrows();
                    Menu();
                    break;
                case 3:
                    CalculateTotalBorrows();
                    Menu();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

        private void ListBorrows()
        {
            int choice = Validator.Validator.OneOrTwo("List All Borrows", "List By Borrower", "Do you want to");
            switch (choice)
            {
                case 1:
                    ListAll($"Borrows List: ", borrows);
                    break;
                case 2:
                    int borrowerId = Validator.Validator.GetInt("Borrower Id", Max: borrowers.Count - 1);
                    FindBorrowsByBorrower(borrowerId);
                    break;
            }
        }

        private void FindBorrowsByBorrower(int borrowerId)
        {
            var borrowsByBorrower = borrows.Where(borrow => borrow.BorrowerId == borrowerId).ToList();
            ListAll($"Borrows for Borrower ({borrowerId}): ", borrowsByBorrower);
        }

        private void CalculateTotalBorrows()
        {
            /*
            var totalBorrowsPerBorrower = borrowers
                .Select(borrower => borrower.TotalBorrows = 
                    borrows.Count(borrow => borrow.BorrowerId == borrower.BorrowerId))
                .ToList();
            */
            Console.Clear();
            foreach (Borrower borrower in borrowers)
            {
                borrower.TotalBorrows = borrows.Count(borrow => borrow.BorrowerId == borrower.BorrowerId);
                Console.WriteLine($"Borrower {borrower.BorrowerId} has borrowed {borrower.TotalBorrows} books");
            }
            Console.ReadLine();
        }

        private void ListAll<T>(String Message, IList<T> list)
        {
            Console.Clear();
            Console.WriteLine(Message);
            /*
             * is this not a waste?
            var query = from item in List
                        select item;
            foreach (var item in query)
            {
                Console.WriteLine(item.ToString());
            }
            */

            foreach (T item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
