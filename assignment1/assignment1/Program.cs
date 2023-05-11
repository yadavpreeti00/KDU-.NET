using assignment1.App_Start;
using assignment1.Contoller;
using assignment1.Service;
using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PopulateData populateData = new PopulateData();
            populateData.PopulateDataOnStart();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please select the type of user from 1 to 4, press 5 to view book information or press 6 to exit :");
                Console.WriteLine("1. ADMIN");
                Console.WriteLine("2. STUDENT");
                Console.WriteLine("3. TEACHER");
                Console.WriteLine("4. ISSUER");
                Console.WriteLine("5. View information of a book by using book item id");
                Console.WriteLine("6. Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        // Code to handle selection of ADMIN role
                        Console.WriteLine("Selected ADMIN role");
                        AdminController adminController = new AdminController();
                        adminController.HandleAdminOptions();
                        break;
                    case "2":
                        // Code to handle selection of STUDENT role
                        Console.WriteLine("Selected STUDENT role");
                        StudentController studentController = new StudentController();
                        studentController.HandleStudentOptions();
                        break;
                    case "3":
                        // Code to handle selection of TEACHER role
                        Console.WriteLine("Selected TEACHER role");
                        TeacherController teacherController = new TeacherController();
                        teacherController.HandleTeacherOptions();
                        break;
                    case "4":
                        // Code to handle selection of ISSUER role
                        Console.WriteLine("Selected ISSUER role");
                        IssuerController issuerController = new IssuerController();
                        issuerController.HandleIssuerOptions();
                        break;
                    case "5":
                        Console.WriteLine("Selected option5. View a book information from inventory");
                        BookService bookService = new BookService();
                        bookService.GetBookInformation();
                        break;
                    case "6":
                        // Exit the loop and the program
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
                        break;
                }

                Console.WriteLine(); // Add a blank line for readability
            }
        }
    }
}

