using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());


            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Vectorul initial:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"vector{i} ");  
            }

            Array.Reverse(vector);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"vector{i} ");
            }
        }
    }
}
