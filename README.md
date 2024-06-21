
# Assignment 4 : Library Management System

## Requirements

> ### Define Data Classes
>
> - [x] Book: Represents a book in the library.
>   - [x] int BookId
>   - [x] string Title
>   - [x] string Author
>   - [x] DateTime PublicationDate
>   - [x] bool IsBorrowed
> - [x] Borrower: Represents a library member who borrows books.
>   - [x] int BorrowerId
>   - [x] string Name
>   - [x] string Email
>   - [x] DateTime DateOfMembership
> - [x] Borrow: Represents a record of a book borrowed by a borrower.
>   - [x] int BorrowId
>   - [x] int BookId
>   - [x] int BorrowerId
>   - [x] DateTime BorrowDate
>
> ### Implement Data Storage
>
> - [x] Use `List<Book>`, `List<Borrower>`, and `List<Borrow>` to store data in memory.
> - [x] Populate these collections with sample data for testing.
>
> ### Develop LINQ Queries
>
> - [x] `ListBooks()`: Use query syntax to list all books.
> - [x] `FindBorrowsByBorrower(int borrowerId)`: Use fluent syntax to find all borrowers for a given borrower ID.
> - [x] `CalculateTotalBorrows()`: Implement a subquery to calculate each borrower's total number of borrows.
>
> ### Console Interface
>
> - [x] Implement a simple menu system that allows users to select which query to run.
> - [x] Provide options to view books, view borrows for a borrower and calculate total borrows.
