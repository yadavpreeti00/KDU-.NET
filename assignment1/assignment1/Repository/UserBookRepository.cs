using assignment1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Repository
{
    internal class UserBookRepository
    {
        //key is the user email which has issued the book
        public static Dictionary<string, List<BookIssued>> BooksIssuedByUser = new Dictionary<string, List<BookIssued>>();

        public void CreateUserBookRepository()
        {
            BooksIssuedByUser.Add("maryjohnson@example.com", new List<BookIssued> { new BookIssued(1, "maryjohnson@example.com", 2, "alicesmith@example.com") });
        }

        public void AddIssuedBookToUser(string UserEmail, BookIssued bookIssued)
        {
            if (BooksIssuedByUser.ContainsKey(UserEmail))
            {
                BooksIssuedByUser[UserEmail].Add(bookIssued);
            }
            else
            {
                BooksIssuedByUser[UserEmail] = new List<BookIssued> { bookIssued };
            }
        }

        public List<BookIssued> GetBooksIssuedByUserEmail(string userEmail)
        {
            if (BooksIssuedByUser.ContainsKey(userEmail))
            {
                return BooksIssuedByUser[userEmail];
            }
            else
            {
                return new List<BookIssued>();
            }
        }
    }
}
