using assignment1.Enum;
using assignment1.models;
using assignment1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Service
{
    internal class AdminService
    {
        UserRepository userRepository=new UserRepository();

        //public void AddUser()
        //{
        //    Console.WriteLine("Enter user email");
        //    string email = Console.ReadLine();

        //    // Check if the user with this email already exists
        //    bool userExists = userRepository.UserExistsByEmail(email);
        //    if (userExists)
        //    {
        //        Console.WriteLine($"User with email {email} already exists.");
        //        return;
        //    }

        //    Console.WriteLine("Enter first name");
        //    string firstName = Console.ReadLine();

        //    Console.WriteLine("Enter last name");
        //    string lastName = Console.ReadLine();

        //    Console.WriteLine("Enter user role:");
        //    Console.WriteLine("1. Admin");
        //    Console.WriteLine("2. Issuer");
        //    Console.WriteLine("3. Student");
        //    string roleInput = Console.ReadLine();
        //    Role role;
        //    switch (roleInput)
        //    {
        //        case "1":
        //            role = Role.ADMIN;
        //            break;
        //        case "2":
        //            role = Role.ISSUER;
        //            break;
        //        case "3":
        //            role = Role.STUDENT;
        //            break;
        //        default:
        //            Console.WriteLine("Invalid role. User not added.");
        //            return;
        //    }

        //    User newUser = new User(email, firstName, lastName, role);
        //    userRepository.SaveUser(newUser);
        //}
    }
}

