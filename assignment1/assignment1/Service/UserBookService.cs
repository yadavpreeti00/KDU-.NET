using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Service
{
    internal class UserBookService
    {
        public void GetBooksOfUser()
        {
            Console.WriteLine("Please enter your email id:");
            string userEmail=Console.ReadLine();
            try
            {

            }
            catch 
            {
                Console.WriteLine("User not Found");
            }
        }
    }
}
