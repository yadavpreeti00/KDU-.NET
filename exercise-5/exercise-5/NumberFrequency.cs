using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5
{
    internal class NumberFrequency
    {
        public int Number { get; set; }
        public  int Frequency { get; set; }
        public void FindNumberFrequency()
        {
            Console.WriteLine("Enter the size of the list:");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer value for the size of the list:");
            }

            List<int> numbers = new List<int>();

            Console.WriteLine("Enter the numbers:");

            for (int i = 0; i < size; i++)
            {
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer value for the number:");
                }
                numbers.Add(number);
            }

            IEnumerable<NumberFrequency> numbersFrequency = from number in numbers
                                                            group number by number into groupedNumbers
                                                            select new NumberFrequency{Number = groupedNumbers.Key, Frequency = groupedNumbers.Count()};
            
            Console.WriteLine("Question 3\nThe count of numbers is:");
            foreach (NumberFrequency numberFrequency in numbersFrequency)
            {
                Console.WriteLine("{0} : {1}",numberFrequency.Number,numberFrequency.Frequency);
            }

        }
    }
}
