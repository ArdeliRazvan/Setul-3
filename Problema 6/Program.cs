using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti pozitia pentru stergere: ");
            int k = int.Parse(Console.ReadLine());

            // Verifica daca pozitia k este valida
            if (k < 0 || k >= n)
            {
                Console.WriteLine("Pozitia specificata pentru stergere nu este valida.");
                return;
            }

            // Realizeaza stergerea elementului de pe pozitia k
            for (int i = k; i < n - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            Array.Resize(ref vector, n - 1);

            Console.WriteLine("Vectorul rezultat dupa stergere:");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write($"{vector[i]} ");
            }
        }
    }
    
}
