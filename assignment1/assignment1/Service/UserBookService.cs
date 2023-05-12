using assignment1.Entity;
using assignment1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Service
{
    internal class UserBookService
    {
        UserRepository userRepository = new UserRepository();
        UserBookRepository userBookRepository = new UserBookRepository();
        public void GetBooksOfUser()
        {
            Console.WriteLine("Please enter your email id:");
            string userEmail = Console.ReadLine();
            //will throw exception if user not present 
            userRepository.GetUserByEmail(userEmail);
            List<BookIssued> booksIssuedByUser = userBookRepository.GetBooksIssuedByUserEmail(userEmail);
            if (booksIssuedByUser.Count < 0)
            {
                Console.WriteLine("No books issued by this user.");
            }
            Console.WriteLine("Books issued by user are :");
            foreach (BookIssued book in booksIssuedByUser)
            {
                Console.WriteLine("Book item id {0}, issued by issuer {1} to {2} ", book.BookItemId, book.IssuerEmail, book.UserEmail);
            }
        }
    }
}
