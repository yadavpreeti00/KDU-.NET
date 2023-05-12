using assignment1.Entity;
using assignment1.Enum;
using assignment1.models;
using assignment1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Service
{
    internal class BookIssueService
    {
        BookService bookService =new BookService();
        BookRepository bookRepository =new BookRepository();
        UserRepository userRepository = new UserRepository();
        UserBookRepository userBookRepository = new UserBookRepository();   
        
        public void IssueBookToUser()
        {
            bookService.GetAvailableBooks();
            Console.WriteLine("Select the book item id of the book you want to issue:");
            string bookItemId=Console.ReadLine();
            BookItem bookItem =bookRepository.FindBookByBookId(int.Parse(bookItemId));

            if (bookItem == null)
            {
                Console.WriteLine("Invalid book item id.");
                return;
            }

            //Getting a random issuer from list of issuers
            List<User> issuers = userRepository.GetUsersByRole(Role.ISSUER);
            Random random = new Random();
            int index = random.Next(issuers.Count);
            User issuer = issuers[index];

            Console.WriteLine("Enter your email id");
            string userEmail=Console.ReadLine();
            //creating a new book issued object
            BookIssued bookIssued = new BookIssued(bookItem.ItemId, userEmail, bookItem.Id, issuer.Email);
            userBookRepository.AddIssuedBookToUser(userEmail,bookIssued);
            Console.WriteLine();

            bookItem.Status = BookStatus.ISSUED;
            bookItem.IssueDate = DateOnly.FromDateTime(DateTime.UtcNow);
            Console.WriteLine("Book with book item id {0} has been issued to {1} by issuer {2} on date {3}",bookItem.ItemId,userEmail,issuer.Email,bookItem.IssueDate);
        }
        public void ReturnBookByUser()
        {
            Console.WriteLine("Enter the id of the book you want to return :");
            string bookItemId = Console.ReadLine();
            BookItem bookItem = bookRepository.FindBookByBookId(int.Parse(bookItemId));
            if (bookItem == null)
            {
                Console.WriteLine("Invalid book item id.");
                return;
            }
            bookItem.Status = BookStatus.AVAILABLE;
            bookItem.IssueDate = null;
            Console.WriteLine("Book with book item id {0} returned successfully",bookItemId);

        }
    }
}
