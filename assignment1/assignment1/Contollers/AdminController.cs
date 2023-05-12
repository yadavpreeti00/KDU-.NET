using assignment1.Enum;
using assignment1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Contoller
{
    internal class AdminController
    {

        public void HandleAdminOptions()
        {

            Console.WriteLine("Please enter your email id:");
            string email = Console.ReadLine();
            UserService userService = new UserService();


            // Verify that the email belongs to a valid user
            bool isCorrectUser = userService.IsUserWithUserRole(email,Role.ADMIN);
            if (!isCorrectUser)
            {
                Console.WriteLine("Invalid email id or not an admin user.");
                return;
            }

            BookService bookService = new BookService();
            UserService userService1 = new UserService();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add a user");
                Console.WriteLine("2. View all users");
                Console.WriteLine("3. Add a book to inventpory");
                Console.WriteLine("4. View all books");
                Console.WriteLine("5. Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        // Code to handle adding a user
                        Console.WriteLine("Selected option 1: Add user");
                        userService.AddUser();
                        break;
                    case "2":
                        // Code to handle viewing all users
                        Console.WriteLine("Selected option 2: View all users");
                        userService.ListAllUsers();
                        break;
                    case "3":
                        // Code to handle viewing all users
                        Console.WriteLine("Selected option 3: Add book to inventory");
                        bookService.AddNewBook();
                        break;
                    case "4":
                        Console.WriteLine("View all books");
                        bookService.ListAllBooks();
                        break;
                    case "5":
                        // Exit the loop and return to the main menu
                        exit = true;
                        Console.WriteLine("Exiting admin options...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

