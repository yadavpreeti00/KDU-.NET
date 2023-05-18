using assignment2.Filters;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace assignment2.DTOs
{

    public class RegisterDTO
    {
        [Required(ErrorMessage = "Please enter username")]
        [CustomUserNameValidation(ErrorMessage = "Username's minimum length should be 5.No special characters allowed.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter email.")]
        [CustomEmailValidation(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        [CustomPasswordValidation(ErrorMessage = "Password should have : min length 8, atleast 1 capital letter, 1 small letter, 1 special char, should not have number in seq eg. 123.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter phone number.")]
        [CustomPhoneNumberValidation(ErrorMessage = "Please enter a valid 10 digit phone number")]
        public string PhoneNumber { get; set; }

    }
}
