using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    public class Fibonacci
    {
        public void GenerateFibonacci(int n)
        {
            int a = 0, b = 1;
            Console.Write("Fibonacci Series: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();
        }
    }
}
