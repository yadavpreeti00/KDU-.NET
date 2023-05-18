﻿using System.ComponentModel.DataAnnotations;

namespace assignment2.Filters
{
    public class CustomEmailValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string email = value.ToString();

            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');

            //if @ and . are at correct position
            if (atIndex < 1 || dotIndex <= atIndex + 1 || dotIndex == email.Length - 1)
            {
                return false;
            }

            return true;
        }
    }
}
