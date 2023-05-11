using assignment1.Entity;
using assignment1.Enum;
using assignment1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Service
{
    internal class BookService
    {
        BookRepository bookRepository = new BookRepository();

        public void GetBookInformation()
        {
            Console.WriteLine("Please enter the book item id of the book you want to view");
            string bookItemIdString=Console.ReadLine();
            int bookItemId=int.Parse(bookItemIdString);
            BookItem book = bookRepository.FindBookByBookId(bookItemId);
            Console.WriteLine("Book item id : {0}, title: {1}, author: {2}, publish date: {3}, status: {4}", book.ItemId, book.Title, book.Author, book.PublishDate,book.Status);


        }
        public void GetAvailableBooks()
        {
            List<BookItem> availableBooks = bookRepository.GetAllAvailableBooks();
            Console.WriteLine("The books available in the library are : ");
            foreach (BookItem book in availableBooks)
            {
                Console.WriteLine("Book item id : {0}, title: {1}, author: {2}, publish date: {3}",book.ItemId,book.Title,book.Author,book.PublishDate);
            }
        }
    }
}
