using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_4
{
    internal class RotateArray
    {
        public void RotateGivenArray()
        {
            //take valid user input
            int size;
            Console.WriteLine("Enter the size of array.");
            while(!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
            int[] array=new int[size];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++)
            {
                int element;
                while (!int.TryParse(Console.ReadLine(), out element))
                {
                   Console.WriteLine("Invalid input. Please enter a valid integer:");
                }
                array[i] = element;
            }
            int k;
            Console.WriteLine("Enter the value of k (steps).");
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
            k = k % size;

      
            //reverse the whole array
            Array.Reverse(array);
            //reverse the first k elements 
            Array.Reverse(array, 0, k);
            //reverse the remaining n-k elements
            Array.Reverse(array, k, size- k);
            Console.WriteLine("The rotated array is:");
            foreach (int element in array)
            {
                Console.WriteLine(element+" ");
            }
        }
        

    }
}
