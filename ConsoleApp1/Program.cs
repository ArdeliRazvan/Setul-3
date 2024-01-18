using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Introdu lungimea vectorului: ");
            int lungime = int.Parse(Console.ReadLine());

            int[] vec = new int[lungime];

            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Introdu numarul de pe poz {i}: ");
                vec[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;
            for (int i = 0; i < lungime; i++)
                suma += vec[i]; 
            Console.WriteLine(suma);
        }
    }
}
