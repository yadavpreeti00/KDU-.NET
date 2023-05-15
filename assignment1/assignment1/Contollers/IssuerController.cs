﻿using assignment1.Enum;
using assignment1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Contoller
{
    internal class IssuerController
    {
        public void HandleIssuerOptions()
        {
            UserManagementService userManagementService = new UserManagementService();
            InventoryManagementService inventoryManagementService = new InventoryManagementService();
            IssueManagementService issueManagementService = new IssueManagementService();

            Console.WriteLine("Please enter your email id:");
            string issuerEmail = Console.ReadLine();
          
            // Verify that the email belongs to a valid user
            bool isCorrectUser =userManagementService.IsUserWithUserRole(issuerEmail, Role.ISSUER);
            if (!isCorrectUser)
            {
                Console.WriteLine("Invalid email id or not an issuer user.");
                return;
            }
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. View all books in the inventory");
                Console.WriteLine("2. View books issued from current issuer.");
                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Selected option 1.View all books in the inventory.");
                        inventoryManagementService.ListAllBooks();
                        break;
                    case "2":
                        Console.WriteLine("Selected option 2.View all books issued from current issuer.");
                        issueManagementService.GetBooksIssuedFromIssuer(issuerEmail);
                        break;
                    case "3":
                        // Exit the loop and return to the main menu
                        exit = true;
                        Console.WriteLine("Exiting issuer options...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 3.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
