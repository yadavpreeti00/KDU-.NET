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
                return false;
            }

            if (password.Length < 8)
            {
                return false;
            }

            if (!ContainsUpperCaseLetter(password))
            {
                return false;
            }

            if (!ContainsLowerCaseLetter(password))
            {
                return false;
            }

            if (!ContainsSpecialCharacter(password))
            {
                return false;
            }

            if (ContainsSequentialNumbers(password))
            {
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
            for (int i = 0; i < password.Length - 2; i++)
            {
                if (char.IsDigit(password[i]) && char.IsDigit(password[i + 1]) && char.IsDigit(password[i + 2]))
                {
                    int firstDigit = int.Parse(password[i].ToString());
                    int secondDigit = int.Parse(password[i + 1].ToString());
                    int thirdDigit = int.Parse(password[i + 2].ToString());

                    if (secondDigit == firstDigit + 1 && thirdDigit == secondDigit + 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
