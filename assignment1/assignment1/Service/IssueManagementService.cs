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
    internal class IssueManagementService
    {
        InventoryManagementService inventoryManagementService = new InventoryManagementService();
        BookRepository bookRepository = new BookRepository();
        UserRepository userRepository = new UserRepository();
        IssueRepository issueRepository = new IssueRepository();

        public void IssueBookToUser(string userEmail,Role role)
        {
            inventoryManagementService.GetAvailableBooks();
            Console.WriteLine("Select the book item id of the book you want to issue:");
            string bookItemId = Console.ReadLine();
            BookItem bookItem = bookRepository.FindBookByBookId(int.Parse(bookItemId));


            if (bookItem == null)
            {
                Console.WriteLine("Invalid book item id.");
                return;
            }

            List<BookIssued> booksIssuedByUser = issueRepository.GetBooksIssuedByUserEmail(userEmail);
            int issuedBookCount = booksIssuedByUser.Where(b => b.BookItemId == bookItem.Id && b.Status == BookStatus.ISSUED).ToList().Count;
            if ( role==Role.STUDENT && issuedBookCount >= IssueRepository.MAX_LIMIT_FOR_STUDENT)
            {
                Console.WriteLine("Sorry, you cannot issue more than {0} books at a time.",IssueRepository.MAX_LIMIT_FOR_STUDENT);
                return;
            }
            if(role==Role.TEACHER && issuedBookCount>=IssueRepository.MAX_LIMIT_FOR_TEACHER)
            {
                Console.WriteLine("Sorry, you cannot issue more than {0} books at a time.", IssueRepository.MAX_LIMIT_FOR_TEACHER);
                return;
            }

            if(bookItem.Status != BookStatus.AVAILABLE) {
                Console.WriteLine("Sorry, the book is not available.");
                return;
            }


            //Getting a random issuer from list of issuers
            List<User> issuers = userRepository.GetUsersByRole(Role.ISSUER);
            Random random = new Random();
            int index = random.Next(issuers.Count);
            User issuer = issuers[index];
            //creating a new book issued object
            BookIssued bookIssued = new BookIssued(bookItem.ItemId, userEmail, bookItem.Id, issuer.Email,BookStatus.ISSUED);
            issueRepository.AddIssuedBookToUser(userEmail, bookIssued);
            Console.WriteLine();

            bookItem.Status = BookStatus.ISSUED;
            bookItem.IssueDate = DateOnly.FromDateTime(DateTime.UtcNow);
            Console.WriteLine("Book with book item id {0} has been issued to {1} by issuer {2} on date {3}", bookItem.ItemId, userEmail, issuer.Email, bookItem.IssueDate);
        }
        public void ReturnBookByUser(string userEmail)
        {
            Console.WriteLine("Enter the id of the book you want to return :");
            string bookItemId = Console.ReadLine();
            BookItem bookItem = bookRepository.FindBookByBookId(int.Parse(bookItemId));
            if (bookItem == null)
            {
                Console.WriteLine("Invalid book item id.");
                return;
            }
            User user = userRepository.GetUserByEmail(userEmail);
            DateOnly issueDateOnly = bookItem.IssueDate;
            // Calculate fine 
            if (issueDateOnly != DateOnly.MinValue)
            {
                DateTime today = DateTime.Now;
                DateTime issueDate = issueDateOnly.ToDateTime(TimeOnly.MinValue, DateTimeKind.Local);
                TimeSpan difference = today.Subtract(issueDate);
                double days = difference.TotalDays;
                double fine = (days > IssueRepository.DAY_LIMIT_FOR_FINE) ? (days - IssueRepository.DAY_LIMIT_FOR_FINE) * IssueRepository.FINE_PER_DAY : 0;
                user.Fine += fine;
                user.Fine = Math.Round(user.Fine, 2);
            }
            Console.WriteLine("Your total fine is: {0}", user.Fine);

            bookItem.Status = BookStatus.AVAILABLE;
            bookItem.IssueDate = DateOnly.MinValue;
           
            Console.WriteLine("Book with book item id {0} returned successfully", bookItemId);

        }

        public void GetBooksOfUser(string userEmail)
        {
  
            //will throw exception if user not present 
            userRepository.GetUserByEmail(userEmail);
            List<BookIssued> booksIssuedByUser = issueRepository.GetBooksIssuedByUserEmail(userEmail);
            if (booksIssuedByUser.Count < 0)
            {
                Console.WriteLine("No books issued by this user.");
            }
            Console.WriteLine("Books issued by user are :");
            foreach (BookIssued book in booksIssuedByUser)
            {
                BookItem bookItem = new BookItem();
                bookItem = bookRepository.FindBookByBookId(book.BookItemId);
                Console.WriteLine("Book item id: {0}, book status: {1}, issued by issuer: {2} to issuee {3}.", book.BookItemId,bookItem.Status, book.IssuerEmail, book.UserEmail);
            }
        }

        public void GetBooksIssuedFromIssuer(string issuerEmail)
        {
            List<BookIssued> booksIssued = IssueRepository.BooksIssuedByUser.Values
                .SelectMany(list => list) 
                .Where(bookIssued => bookIssued.IssuerEmail == issuerEmail)
                .ToList();
            List<int> bookItemIds = booksIssued.Select(bookIssued => bookIssued.BookItemId).ToList();
            Console.WriteLine("Book item IDs issued by issuer {0} are :", issuerEmail);
            foreach (int bookItemId in bookItemIds)
            {
                Console.WriteLine(bookItemId);
            }
        }
    }
}
