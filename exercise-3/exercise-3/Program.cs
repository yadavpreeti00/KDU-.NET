
// See https://aka.ms/new-console-template for more information

using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
           CountOccurences countOccurences = new CountOccurences();
           countOccurences.GetOccurencesCount();

           GetEvenNumber getEvenNumber=new GetEvenNumber();
            List<int> evenNumbers = getEvenNumber.GetEvenNumbersInRange(100, 170);
           foreach (int num in evenNumbers)
           {
               Console.WriteLine(num);
           }

        }
    }
}

