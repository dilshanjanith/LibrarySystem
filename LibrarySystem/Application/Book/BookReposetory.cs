using LibrarySystem.Model;

namespace LibrarySystem.Application.Book
{
    public static class BookReposetory
    {
        private static List<BookDto> book = new List<BookDto>()
        {
            new BookDto { BookId = 1, BookName = "The Great Gatsby", Author = "F. Scott Fitzgerald", Catagory = "Fiction", RowNumber = 3, IssuedDate = new DateOnly(2025, 1, 20), ReturnDate = new DateOnly(2025, 2, 20) },
            new BookDto { BookId = 2, BookName = "1984", Author = "George Orwell", Catagory = "Dystopian", RowNumber = 5, IssuedDate = new DateOnly(2025, 1, 15), ReturnDate = new DateOnly(2025, 2, 15) },
            new BookDto { BookId = 3, BookName = "To Kill a Mockingbird", Author = "Harper Lee", Catagory = "Classic", RowNumber = 7, IssuedDate = new DateOnly(2025, 1, 10), ReturnDate = new DateOnly(2025, 2, 10) },
            new BookDto { BookId = 4, BookName = "Sapiens: A Brief History of Humankind", Author = "Yuval Noah Harari", Catagory = "Non-Fiction", RowNumber = 2, IssuedDate = new DateOnly(2025, 1, 22), ReturnDate = new DateOnly(2025, 2, 22) },
            new BookDto { BookId = 5, BookName = "The Alchemist", Author = "Paulo Coelho", Catagory = "Philosophy", RowNumber = 8, IssuedDate = new DateOnly(2025, 1, 25), ReturnDate = new DateOnly(2025, 2, 25) },
            new BookDto { BookId = 6, BookName = "Pride and Prejudice", Author = "Jane Austen", Catagory = "Romance", RowNumber = 4, IssuedDate = new DateOnly(2025, 1, 18), ReturnDate = new DateOnly(2025, 2, 18) },
            new BookDto { BookId = 7, BookName = "The Catcher in the Rye", Author = "J.D. Salinger", Catagory = "Fiction", RowNumber = 6, IssuedDate = new DateOnly(2025, 1, 12), ReturnDate = new DateOnly(2025, 2, 12) },
            new BookDto { BookId = 8, BookName = "The Road", Author = "Cormac McCarthy", Catagory = "Post-Apocalyptic", RowNumber = 1, IssuedDate = new DateOnly(2025, 1, 23), ReturnDate = new DateOnly(2025, 2, 23) },
            new BookDto { BookId = 9, BookName = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Catagory = "Fantasy", RowNumber = 10, IssuedDate = new DateOnly(2025, 1, 14), ReturnDate = new DateOnly(2025, 2, 14) },
            new BookDto { BookId = 10, BookName = "The Hobbit", Author = "J.R.R. Tolkien", Catagory = "Fantasy", RowNumber = 12, IssuedDate = new DateOnly(2025, 1, 26), ReturnDate = new DateOnly(2025, 2, 26) }
        };
    }
}
