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
        
        public void IssueBookToUser()
        {
            bookService.GetAvailableBooks();
            Console.WriteLine("Select the book item id of the book you want to issue:");
            string bookItemId=Console.ReadLine();


        }
        public void ReturnBookByUser()
        {
            Console.WriteLine("Enter the id of the book you want to return :");
            string bookItemId = Console.ReadLine();
        }
    }
}
