using assignment1.Entity;
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
    /// <summary>
    /// Provides user-related functionality such as user verification, listing all users, and adding new users.
    /// </summary>
    internal class UserManagementService
    {
        UserRepository userRepository=new UserRepository();

        /// <summary>
        /// Verifies if a user with the given email and role exists in the repository.
        /// </summary>
        /// <param name="email">The email of the user to verify.</param>
        /// <param name="role">The role of the user to verify.</param>
        /// <returns>True if the user exists with the given role, false otherwise.</returns>
        public bool IsUserWithUserRole(string email, Role role)
        {
            if (UserRepository.People.ContainsKey(email) && UserRepository.People[email].PersonRole == role)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get the user list from user repository and print them to console
        /// </summary>
        public void ListAllUsers()
        {
            List<User> users = userRepository.GetAllUsers();
            if(users.Count < 0)
            {
                Console.WriteLine("No user exists.");
                return;
            }
            else
            {
                Console.WriteLine("All the users of the library are : ");
                foreach (User user in users)
                {
                    Console.WriteLine("User email: {0}, first name: {1}, last name: {2}, fine: {3}, role: {4}", user.Email, user.FirstName, user.LastName, user.Fine, user.PersonRole);
                }
            }
        }

        /// <summary>
        /// Get all the user details, and send to user repositpory to save the user
        /// </summary>
        public void AddUser()
        {
            Console.WriteLine("Enter user email");
            string email = Console.ReadLine();

            // Check if the user with this email already exists
            bool userExists = userRepository.UserExistsByEmail(email);
            if (userExists)
            {
                Console.WriteLine("User with email {0} already exists.",email);
                return;
            }

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Select user role from 1 to 4.");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Issuer");
            Console.WriteLine("3. Student");
            Console.WriteLine("4. Teacher");
            string roleInput = Console.ReadLine();
            Role role;
            switch (roleInput)
            {
                case "1":
                    role = Role.ADMIN;
                    break;
                case "2":
                    role = Role.ISSUER;
                    break;
                case "3":
                    role = Role.STUDENT;
                    break;
                case "4":
                    role = Role.TEACHER;
                    break;
                default:
                    Console.WriteLine("Invalid role. User not added.");
                    return;
            }

            User newUser = new User(email, firstName, lastName, role);
            userRepository.SaveUser(newUser);
        }
    }
}
