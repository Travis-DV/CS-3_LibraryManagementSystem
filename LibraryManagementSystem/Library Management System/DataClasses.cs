using Validator;

namespace LibraryManagementSystem
{
    public record Book
    {
        public int BookId 
        {
            get => bookId;
            set
            {
                if (value < 10000 && value > -1)
                {
                    bookId = value;
                }
                else
                {
                    Console.WriteLine("Invalid Book Id");
                }
            }

        }
        private int bookId;
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public bool IsBorrowed { get; set; }

        public override string ToString()
        {
            string s = IsBorrowed ? "is borrowed." : "is NOT borrowed.";
           
            return $"{BookId.ToString().PadLeft(4, '0')}, {Title} by {Author} on {PublicationDate.ToString()} {s}";
        }
    }

    public record Borrower
    {
        public int BorrowerId
        {
            get => borrowerId;
            set
            {
                if (value < 10000 && value > -1)
                {
                    borrowerId = value;
                }
                else
                {
                    Console.WriteLine("Invalid Borrower Id");
                }
            }

        }
        private int borrowerId;
        public int TotalBorrows { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfMembership { get; set; }

        public override string ToString()
        {
            return $"{BorrowerId.ToString().PadLeft(4, '0')}, {Name} has {TotalBorrows} books borrowed and Joined: {DateOfMembership.ToString()}: {Email}.";
        }
    }

    public record Borrow
    {
        public int BorrowId
        {
            get => borrowId;
            set
            {
                if (value < 10000 && value > -1)
                {
                    borrowId = value;
                }
                else
                {
                    Console.WriteLine("Invalid Borrow Id");
                }
            }

        }
        private int borrowId;

        public int BookId
        {
            get => bookId;
            set
            {
                if (value < 10000 && value > -1)
                {
                    bookId = value;
                }
                else
                {
                    Console.WriteLine("Invalid Book Id");
                }
            }

        }
        private int bookId;

        public int BorrowerId
        {
            get => borrowerId;
            set
            {
                if (value < 10000 && value > -1)
                {
                    borrowerId = value;
                }
                else
                {
                    Console.WriteLine("Invalid Borrower Id");
                }
            }
        }
        private int borrowerId;
        public DateTime BorrowDate { get; set; }

        public override string ToString()
        {
            return $"{BorrowId.ToString().PadLeft(4, '0')}, Book {BookId.ToString().PadLeft(4, '0')}, Borrower {BorrowerId.ToString().PadLeft(4, '0')} on {BorrowDate.ToString()}";
        }
    }
}
