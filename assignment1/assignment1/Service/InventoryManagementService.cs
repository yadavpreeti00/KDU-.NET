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
    internal class InventoryManagementService
    {
        BookRepository bookRepository = new BookRepository();

        public void GetBookInformation()
        {
            Console.WriteLine("Please enter the book item id of the book you want to view");
            string bookItemIdString=Console.ReadLine();
            int bookItemId=int.Parse(bookItemIdString);
            BookItem book = bookRepository.FindBookByBookId(bookItemId);
            if(book==null)
            {
                Console.WriteLine("Book with book item id {0} does not exist.",bookItemId);
                return;
            }
            Console.WriteLine("Book item id : {0}, title: {1}, author: {2}, publish date: {3}, status: {4}", book.ItemId, book.Title, book.Author, book.PublishDate,book.Status);
        }
        public void ListAllBooks()
        {
            List<BookItem> bookItems = bookRepository.GetAllBooks();
            Console.WriteLine("All the books of the library are : ");
            foreach(BookItem book in bookItems)
            {
                Console.WriteLine("Book item id : {0}, title: {1}, author: {2}, publish date: {3},status: {4}", book.ItemId, book.Title, book.Author, book.PublishDate,book.Status);
            }

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

        public void AddNewBook()
        {
            BookItem bookItem = new BookItem();
            Console.WriteLine("Enter book title:");
            string title = Console.ReadLine();
            bookItem.Title = title;

            Console.WriteLine("Enter book author:");
            string author = Console.ReadLine();
            bookItem.Author = author;

            Console.WriteLine("Enter publish year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter publish month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter publish day:");
            int day = int.Parse(Console.ReadLine());
            bookItem.PublishDate = new DateOnly(year, month, day);

            int itemId= BookRepository.Books.Count + 1;
            bookItem.ItemId = itemId;
            bookItem.Status = BookStatus.AVAILABLE;
            bookRepository.AddBookToInventory(bookItem);

            Console.WriteLine($"Book {title} by {author} with ID {itemId} added to inventory.");
        }


    }
}
