using System.ComponentModel.DataAnnotations;

namespace assignment2.Filters
{
    public class CustomPhoneNumberValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string phoneNumber = value.ToString();

            if (string.IsNullOrEmpty(phoneNumber))
            {
                ErrorMessage = "Phone number cannot be empty.";
                return false;
            }

            if (phoneNumber.Length != 10)
            {
                ErrorMessage = "Phone number should be of lenght 10.";
                return false;
            }

            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    ErrorMessage = "Phone number can only contain digits.";
                    return false;
                }
            }

            return true;
        }
    }
}
