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
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add user");
                Console.WriteLine("2. Remove user");
                Console.WriteLine("3. View all users");
                Console.WriteLine("4. Add a book to inventpory");
                Console.WriteLine("5. Remove a book from inventory");
                Console.WriteLine("6. View all books");
                Console.WriteLine("7. Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        // Code to handle adding a user
                        Console.WriteLine("Selected option 1: Add user");
                        break;
                    case "2":
                        // Code to handle removing a user
                        Console.WriteLine("Selected option 2: Remove user");
                        break;
                    case "3":
                        // Code to handle viewing all users
                        Console.WriteLine("Selected option 3: View all users");
                        break;
                    case "4":
                        // Code to handle viewing all users
                        Console.WriteLine("Selected option 4: Add book to inventory");
                        break;
                    case "5":
                        // Code to handle viewing all users
                        Console.WriteLine("Selected option 5: Remove book from inventory");
                        break;
                    case "6":
                        Console.WriteLine("View all books");
                        break;
                    case "7":
                        // Exit the loop and return to the main menu
                        exit = true;
                        Console.WriteLine("Exiting admin options...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

