using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
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
                    Console.Write($"Introduceti elementul {i}: ");
                    vector[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Introduceti valoarea pentru inserare: ");
                int e = int.Parse(Console.ReadLine());

                Console.Write("Introduceti pozitia pentru inserare: ");
                int k = int.Parse(Console.ReadLine());

                // Verifica daca pozitia k este valida
                if (k < 0 || k > n)
                {
                    Console.WriteLine("Pozitia specificata pentru inserare nu este valida.");
                    return;
                }

                // Realizeaza inserarea valorii la pozitia k
                int[] vectorNou = new int[n + 1];

                for (int i = 0; i < k; i++)
                {
                    vectorNou[i] = vector[i];
                }

                vectorNou[k] = e;

                for (int i = k + 1; i < n + 1; i++)
                {
                    vectorNou[i] = vector[i - 1];
                }

                Console.WriteLine("Vectorul rezultat dupa inserare:");

            for (int i = 0; i < n + 1; i++)
            {
                Console.Write($"{vectorNou[i]} ");
            }
        }
    }
}
