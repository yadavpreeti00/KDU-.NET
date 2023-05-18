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
                return false;
            }

            if (username.Length < 5)
            {
                return false;
            }

            if (!IsValidUsername(username))
            {
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

