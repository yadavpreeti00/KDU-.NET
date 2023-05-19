using assignment2.Filters;
using System.ComponentModel.DataAnnotations;

namespace assignment2.Model
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PhoneNumber { get; set; }

        public User(string userName, string email, string password, string name, string addressLine1, string addressLine2, string phoneNumber)
        {
            UserName = userName;
            Email = email;
            Password = password;
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            PhoneNumber = phoneNumber;
        }
    }
}
