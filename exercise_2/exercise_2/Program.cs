// See https://aka.ms/new-console-template for more information
using exercise_2;
using System;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1 : Fibonacci Series
            Fibonacci fibonacci = new Fibonacci();
            Console.WriteLine("Enter the number of Fibonacci numbers to generate:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer value:");
            }
            fibonacci.GenerateFibonacci(n);

            //Question 2 : String Parsing
            StringParsing stringParsing = new StringParsing();
            stringParsing.StringParser();

            //Question 3 : Methods to do lower and upper case and calculate length
            LowerUpperCount lowerUpperCount = new LowerUpperCount();
            string inputStr= "HeY ThErE !";
            string concatString=lowerUpperCount.LowerUpperConcat(inputStr);
            lowerUpperCount.Count(concatString);

            //Question 4 : Highscore Application
            TrackHighScore trackHighScore = new TrackHighScore();
            trackHighScore.UpdateHighScore(10, "John");

        }
    }
}


