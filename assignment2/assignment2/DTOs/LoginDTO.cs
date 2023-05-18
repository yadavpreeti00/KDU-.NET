using assignment2.Filters;
using System.ComponentModel.DataAnnotations;

namespace assignment2.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Please enter username.")]
        [CustomUserNameValidation(ErrorMessage = "Username's minimum length should be 5.No special characters allowed.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        [CustomPasswordValidation(ErrorMessage = "Password should have : min length 8, atleast 1 capital letter, 1 small letter, 1 special char, should not have number in seq eg. 123.")]
        public string Password { get; set; }
    }
}
