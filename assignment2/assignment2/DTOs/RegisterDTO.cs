using assignment2.Filters;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace assignment2.DTOs
{

    public class RegisterDTO
    {
      

        [Required(ErrorMessage = "Please enter username")]
        [CustomUserNameValidation]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter email.")]
        [CustomEmailValidation]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        [CustomPasswordValidation]
        public string Password { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter phone number.")]
        [CustomPhoneNumberValidation]
        public string PhoneNumber { get; set; }

    }
}
