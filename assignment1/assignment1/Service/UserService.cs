using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Service
{
    internal class UserService
    {
        public bool IsUserWithUserRole(string email,Role role)
        {
            if (UserRepository.People.ContainsKey(email) && UserRepository.People[email].Role == role)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
