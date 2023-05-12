using assignment1.Entity;
using assignment1.Enum;
using assignment1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Repository
{
    internal class UserRepository
    {
        public static Dictionary<string, User> People = new Dictionary<string, User>();

        public void  CreateUserRepository()
        {
            // Add admin
            People.Add("johndoe@example.com", new User("johndoe@example.com","John", "Doe", Role.ADMIN));
            
            // Add issuers
            People.Add("janedoe@example.com", new User("janedoe@example.com", "Jane", "Doe", Role.ISSUER));
            
            People.Add("alicesmith@example.com", new User ("alicesmith@example.com" ,"Alice","Smith",Role.ISSUER ));
            People.Add("bobjohnson@example.com", new User ("bobjohnson@example.com", "Bob", "Johnson" ,  Role.ISSUER ));

            // Add students
            People.Add("maryjohnson@example.com", new User ("maryjohnson@example.com", "Mary", "Johnson", Role.STUDENT));
            People.Add("davidlee@example.com", new User ("davidlee@example.com", "David", "Lee", Role.STUDENT ));
            People.Add("sarahkhan@example.com", new User ( "sarahkhan@example.com", "Sarah","Khan" , Role.STUDENT ));

            // Add teachers
            People.Add("jameswilson@example.com", new User ("jameswilson@example.com", "James", "Wilson",Role.TEACHER ));
            People.Add("emilychen@example.com", new User("emilychen@example.com", "Emily","Chen",  Role.TEACHER ));
            People.Add("michaelkim@example.com", new User("michaelkim@example.com","Michael",  "Kim",Role.TEACHER ));

        }

        public void SaveUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            else
            {
                People.Add(user.Email, user);
                Console.WriteLine("User added succesfully");
            }
        }

        public List<User> GetUsersByRole(Role role)
        {
            return People.Values.Where(user => user.PersonRole == role).ToList();
        }

        public bool UserExistsByEmail(string email)
        {
            return People.ContainsKey(email);
        }

        public User GetUserByEmail(string email)
        {
            if (!People.ContainsKey(email))
            {
                throw new Exception($"User with email '{email}' not found.");
            }

            return People[email];
        }

        public List<User> GetAllUsers()
        {
            return People.Values.ToList();
        }
    }
}
