using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    internal class GetEvenNumber
    {
        public List<int> GetEvenNumbersInRange(int start,int end)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
            }
            return evenNumbers;
        }
    }
}
