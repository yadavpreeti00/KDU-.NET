using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_4
{
    internal class ConvertToDictionary
    {
        public void MakeDictionaryFromArrays()
        {
            int size;
            Console.WriteLine("Enter the size of array.");
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
            string[] keys = new string[size];
            string[] values = new string[size];
            Console.WriteLine("Enter the array elements of 1st array:");
            for (int i = 0; i < size; i++)
            {
                keys[i]=Console.ReadLine();
            }
            Console.WriteLine("Enter the array elements of 2nd array:");
            for (int i = 0; i < size; i++)
            {
                values[i] = Console.ReadLine();
            }
            Dictionary<string,string> keyValuePairs = new Dictionary<string,string>();
            for(int i=0;i<size;i++)
            {
                keyValuePairs.Add(keys[i], values[i]);  
            }
            Console.WriteLine("The dictionary from 2 arrays is");
            foreach (KeyValuePair<string, string> pair in keyValuePairs)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }


        }
    }
}
