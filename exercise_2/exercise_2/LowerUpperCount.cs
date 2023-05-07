using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    internal class LowerUpperCount
    {
        public string LowerUpperConcat(string inputStr) 
        {
            string concatStr= inputStr.ToLower() + inputStr.ToUpper();
            Console.WriteLine(concatStr);
            return concatStr;
        }

        public void Count(string inputStr) 
        {
            int length = inputStr.Length;
            Console.WriteLine("The amount of characters is {0}.", length);
            
        }
    }
}
