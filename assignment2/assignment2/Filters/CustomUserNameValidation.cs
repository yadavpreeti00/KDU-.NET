using System.ComponentModel.DataAnnotations;

namespace assignment2.Filters
{
    public class CustomUserNameValidation : ValidationAttribute
    {
        public override bool IsValid(object value )
        {
            string username = value.ToString();

            if (string.IsNullOrEmpty(username))
            {
                ErrorMessage = "Username cannot be empty.";
                return false;
            }

            if (username.Length < 5)
            {
                ErrorMessage = "Username length cannot be less than 5.";
                return false;
            }

            if (!IsValidUsername(username))
            {
                ErrorMessage = "Username cannot contain special characters.";
                return false;
            }

            return true;
        }

        private bool IsValidUsername(string username)
        {
            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }


    }
}

