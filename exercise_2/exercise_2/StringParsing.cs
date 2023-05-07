using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    public class StringParsing
    {
        public void StringParser() 
        {
            string stringForFloat = "0.85";
            float floatNumber;

            try
            {
                floatNumber = float.Parse(stringForFloat);
                Console.WriteLine($"The converted float value is: {floatNumber}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("The input string is not a valid float number.");
            }

            string stringForInt = "12345";
            int intNumber;

            try
            {
                intNumber = int.Parse(stringForInt);
                Console.WriteLine($"The converted int value is: {intNumber}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("The input string is not a valid integer number.");
            }
        }
    }
}
