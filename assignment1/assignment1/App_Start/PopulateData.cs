using assignment1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.App_Start
{
    internal class PopulateData
    {
        /// <summary>
        /// Function to call the repositories to populate data of each type 
        /// </summary>
        public void PopulateDataOnStart()
        {
            BookRepository bookRepository = new BookRepository();
            bookRepository.CreateBookRepository();
            UserRepository userRepository = new UserRepository();
            userRepository.CreateUserRepository();
            IssueRepository userBookRepository = new IssueRepository();
            userBookRepository.CreateUserBookRepository();
        }
    }
}
