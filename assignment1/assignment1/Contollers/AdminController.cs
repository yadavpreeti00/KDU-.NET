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
        /// <summary>
        /// Verifies admin email id and role, if verified shows admin options 
        /// Handles all the admin options and calls the necessary service classes to perform admin functions.
        /// </summary>
        public void HandleAdminOptions()
        {
            UserManagementService userManagementService = new UserManagementService();
            InventoryManagementService inventoryManagementService = new InventoryManagementService();

            Console.WriteLine("Please enter your email id:");
            string email = Console.ReadLine();

            // Verify that the email belongs to a valid user
            bool isCorrectUser = userManagementService.IsUserWithUserRole(email,Role.ADMIN);
            if (!isCorrectUser)
            {
                Console.WriteLine("Invalid email id or not an admin user.");
                return;
            }
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
                        userManagementService.AddUser();
                        break;
                    case "2":
                        // Code to handle viewing all users
                        Console.WriteLine("Selected option 2: View all users");
                        userManagementService.ListAllUsers();
                        break;
                    case "3":
                        // Code to handle viewing all users
                        Console.WriteLine("Selected option 3: Add book to inventory");
                        inventoryManagementService.AddNewBook();
                        break;
                    case "4":
                        Console.WriteLine("View all books");
                        inventoryManagementService.ListAllBooks();
                        break;
                    case "5":
                        // Exit the loop and return to the main menu
                        exit = true;
                        Console.WriteLine("Exiting admin options...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

