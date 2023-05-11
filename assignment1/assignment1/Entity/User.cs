using assignment1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.models
{
    internal class User
    {
        private double v;
        private Role role;

        //treating email address as primary key
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public double Fine { get; set; } = 0.0;
        public Role PersonRole { get; set; }

       

        public User(string email, string firstName, string lastName, Role role)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            PersonRole = role;
        }
    }
}
