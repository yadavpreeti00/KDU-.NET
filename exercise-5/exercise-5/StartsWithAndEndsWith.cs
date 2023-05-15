using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5
{
    internal class StartsWithAndEndsWith
    {
        List<string> cities = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        public void PrintCitiesStartsWithAndEndsWith()
        {
            Console.WriteLine("Question 1\nEnter the starting character:");
            string startsWith = Console.ReadLine();
            Console.WriteLine("Enter the ending character");
            string endsWith = Console.ReadLine();

            IEnumerable<string> resultCities = from city in cities
                                               where city.StartsWith(startsWith, StringComparison.OrdinalIgnoreCase) && city.EndsWith(endsWith, StringComparison.OrdinalIgnoreCase)
                                               select city;
            if(resultCities.Count() <= 0 )
            {
                Console.WriteLine("No cities found.");
                return;
            }
            Console.WriteLine("The cities starting with {0} and ending with {1} are: ",startsWith,endsWith);
            foreach (string city in resultCities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
