using assignment1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Contoller
{
    internal class TeacherController
    {
        BookService bookService = new BookService();
        BookIssueService bookIssueService = new BookIssueService();
        UserBookService userBookService = new UserBookService();
        public void HandleTeacherOptions()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. View all available books");
                Console.WriteLine("2. Issue a Book");
                Console.WriteLine("3. View all books issued");
                Console.WriteLine("4. Return a book");
                Console.WriteLine("5. Exit");


                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        // Code to handle adding a user
                        Console.WriteLine("Selected option 1: View all available books");
                        bookService.GetAvailableBooks();
                        break;
                    case "2":
                        // Code to handle removing a user
                        Console.WriteLine("Selected option 2: Issue a Book");
                        bookIssueService.IssueBookToUser();
                        break;
                    case "3":
                        // Code to handle viewing all users
                        Console.WriteLine("Selected option 3: View all books issued.");
                        userBookService.GetBooksOfUser();

                        break;
                    case "4":
                        Console.WriteLine("Selected option 4: Return a book");
                        bookIssueService.ReturnBookByUser();
                        break;
                    case "5":
                        // Exit the loop and return to the main menu
                        exit = true;
                        Console.WriteLine("Exiting student options...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

