namespace assignment2.DTOs
{
    public class UserDetailsResponseDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PhoneNumber { get; set; }

        public UserDetailsResponseDTO(string userName, string email, string name, string addressLine1, string addressLine2, string phoneNumber)
        {
            UserName = userName;
            Email = email;
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            PhoneNumber = phoneNumber;
        }
    }
}
