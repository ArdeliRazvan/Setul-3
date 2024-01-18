using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());


            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            RotireStanga(vector);

            Console.WriteLine("Vectorul rotit spre stanga:");
            AfisareVector(vector);
        }

        static void RotireStanga(int[] vector)
        {
            int temp = vector[0];
            for (int i = 0; i < vector.Length - 1; i++)
            {
                vector[i] = vector[i + 1];
            }
            vector[vector.Length - 1] = temp;
        }

        static void AfisareVector(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
