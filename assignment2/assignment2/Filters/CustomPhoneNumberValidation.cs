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
                return false;
            }

            if (phoneNumber.Length != 10)
            {
                return false;
            }

            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
