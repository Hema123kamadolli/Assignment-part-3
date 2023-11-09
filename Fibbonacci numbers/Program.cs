using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbonacci_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 3: Fibonacci sequence
            Console.WriteLine("\n\nFibonacci sequence (first 10 numbers):");
            int n = 10;
            int first = 0, second = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{first} ");
                int temp = first;
                first = second;
                second = temp + second;
            }
            Console.ReadKey();
        }
    }
}
