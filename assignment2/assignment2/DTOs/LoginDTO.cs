using assignment2.Filters;
using System.ComponentModel.DataAnnotations;

namespace assignment2.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Please enter username.")]
        [CustomUserNameValidation]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        [CustomPasswordValidation]
        public string Password { get; set; }
    }
}
