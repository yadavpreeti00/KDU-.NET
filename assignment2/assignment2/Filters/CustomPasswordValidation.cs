using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace assignment2.Filters
{
    public class CustomPasswordValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string password = value.ToString();

            if (string.IsNullOrEmpty(password))
            {
                ErrorMessage = "Password cannot be empty.";
                return false;
            }

            if (password.Length < 8)
            {
                ErrorMessage = "Password length can not be less than 8.";
                return false;
            }

            if (!ContainsUpperCaseLetter(password))
            {
                ErrorMessage = "Password should contain atleast one uppercase letter.";
                return false;
            }

            if (!ContainsLowerCaseLetter(password))
            {
                ErrorMessage = "Password should contain atleast one lowercase letter.";
                return false;
            }

            if (!ContainsSpecialCharacter(password))
            {
                ErrorMessage = "Password should contain atleast one special character.";
                return false;
            }

            if (ContainsSequentialNumbers(password))
            {
                ErrorMessage = "Password cannot contain sequential numbers e.g 123.";
                return false;
            }

            return true;
        }

        private bool ContainsUpperCaseLetter(string password)
        {
            return password.Any(char.IsUpper);
        }

        private bool ContainsLowerCaseLetter(string password)
        {
            return password.Any(char.IsLower);
        }

        private bool ContainsSpecialCharacter(string password)
        {
            return password.Any(IsSpecialCharacter);
        }

        private bool IsSpecialCharacter(char c)
        {
            return !char.IsLetterOrDigit(c);
        }

        private bool ContainsSequentialNumbers(string password)
        {
            for (int i = 0; i < password.Length - 1; i++)
            {
                if (char.IsDigit(password[i]) && char.IsDigit(password[i + 1]))
                {
                    int firstDigit = int.Parse(password[i].ToString());
                    int secondDigit = int.Parse(password[i + 1].ToString());

                    if (secondDigit == firstDigit + 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
