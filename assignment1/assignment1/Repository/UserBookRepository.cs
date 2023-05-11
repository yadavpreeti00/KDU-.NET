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
        public static Dictionary<string, BookIssued> BooksIssuedByUser = new Dictionary<string,BookIssued>();

        public void CreateUserBookRepository()
        {
            BooksIssuedByUser.Add("maryjohnson@example.com", new BookIssued(1, "maryjohnson@example.com",2, "alicesmith@example.com"));
        }

        public void AddIssuedBookToUser(String UserEmail,BookIssued bookIssued)
        {
            BooksIssuedByUser[UserEmail] = bookIssued;
        }

        public List<BookIssued> GetBooksIssuedByUserEmail(string userEmail)
        {
            List<BookIssued> booksIssuedByUser = new List<BookIssued>();
            foreach (BookIssued bookIssued in BooksIssuedByUser.Values)
            {
                if (bookIssued.UserEmail == userEmail)
                {
                    booksIssuedByUser.Add(bookIssued);
                }
            }
            return booksIssuedByUser;
        }

    }
}
