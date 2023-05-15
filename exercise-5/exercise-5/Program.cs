using System;
namespace exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartsWithAndEndsWith startsWithAndEndsWith = new StartsWithAndEndsWith();
            startsWithAndEndsWith.PrintCitiesStartsWithAndEndsWith();
            CharacterFrequency characterFrequency = new CharacterFrequency();
            characterFrequency.FindCharacterFrequency();
            NumberFrequency numberFrequency = new NumberFrequency();
            numberFrequency.FindNumberFrequency();
        }
    }
}