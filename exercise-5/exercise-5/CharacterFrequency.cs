using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5
{
    internal class CharacterFrequency
    {
        public char Character { get; set; }
        public int Frequency { get; set; }
        public void FindCharacterFrequency()
        {
            Console.WriteLine("Question 2\nEnter the string:");
            string input = Console.ReadLine();

            IEnumerable<CharacterFrequency> charFrequencies = from character in input
                                                              group character by character into groupedCharacters
                                                              select new CharacterFrequency{Character = groupedCharacters.Key, Frequency = groupedCharacters.Count()};

            Console.WriteLine("The frequency of characters are:");
            foreach (CharacterFrequency characterFrequency in charFrequencies)
            {
                Console.WriteLine("{0} : {1} ",characterFrequency.Character,characterFrequency.Frequency);
            }

        }

    }
}
