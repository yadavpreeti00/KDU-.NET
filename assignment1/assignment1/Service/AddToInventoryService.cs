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
    internal class AddToInventoryService
    {

        public void AddUser(string email,string firstName,string lastName,Role role)
        {
            User user=new User(email,firstName,lastName,role);
            UserRepository userRepository=new UserRepository();
            userRepository.SaveUser(user);
        }
        
    }
}
