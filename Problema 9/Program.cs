using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());


            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti numarul de pozitii pentru rotirea spre stanga (k): ");
            int k = int.Parse(Console.ReadLine());

            RotireS(vector, k);


            Console.WriteLine($"Vectorul rotit spre stanga cu {k} pozitii:");
            AfisareVector(vector);
        }

        static void RotireS(int[] vector, int k)
        {
            int n = vector.Length;
            if (k < vector.Length)
            {
                // creez un vector unde pun primele k elemente
                int[] temp = new int[k];
                Array.Copy(vector, temp, k);

                // deplasarea elementelor ramase 
                Array.Copy(vector, k, vector, 0, n - k);

                // elementele din vectorul temporat se plaseaza inapoi 
                Array.Copy(temp, 0, vector, n - k, k);
            }
        }

        static void AfisareVector(int[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.WriteLine();
        }

    }
}