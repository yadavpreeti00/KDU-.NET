using assignment1.Entity;
using assignment1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Repository
{
    internal class BookRepository
    {
        public static Dictionary<int, BookItem> Books= new Dictionary<int, BookItem>();

        public void CreateBookRepository()
        {
            Console.WriteLine("Preeti");
            // Adding 2 books of type A
            Books.Add(1, new BookItem() { Id = 1, Title = "Book A1", Author = "Author A1", PublishDate = new DateOnly(2022, 1, 1), ItemId = 1, IssueDate = null, Status = BookStatus.AVAILABLE });
            Books.Add(2, new BookItem() { Id = 1, Title = "Book A1", Author = "Author A1", PublishDate = new DateOnly(2022, 1, 1), ItemId = 2, IssueDate = new DateOnly(2022,2,4), Status = BookStatus.ISSUED });

            // Adding 2 books of type B
            Books.Add(3, new BookItem() { Id = 2, Title = "Book B1", Author = "Author B1", PublishDate = new DateOnly(2022, 3, 1), ItemId = 3, IssueDate = null, Status = BookStatus.AVAILABLE });
            Books.Add(4, new BookItem() { Id = 2, Title = "Book B1", Author = "Author B1", PublishDate = new DateOnly(2022, 3, 1), ItemId = 4, IssueDate = null, Status = BookStatus.AVAILABLE });

            // Adding 2 books of type C
            Books.Add(5, new BookItem() { Id = 3, Title = "Book C1", Author = "Author C1", PublishDate = new DateOnly(2022, 5, 1), ItemId = 5, IssueDate = null, Status = BookStatus.AVAILABLE });
            Books.Add(6, new BookItem() { Id = 3, Title = "Book C1", Author = "Author C1", PublishDate = new DateOnly(2022, 5, 1), ItemId = 6, IssueDate = null, Status = BookStatus.AVAILABLE });
        }

        public List<BookItem> GetAllAvailableBooks()
        {
            return Books.Values.Where(book => book.Status == BookStatus.AVAILABLE).ToList();
        }

        public BookItem FindBookByBookId(int bookItemId)
        {
            return Books.GetValueOrDefault(bookItemId);
        }
    }
}
