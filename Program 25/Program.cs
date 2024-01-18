using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_25
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introdu lungimea primului vector (v1): ");
            int n1 = int.Parse(Console.ReadLine());

            int[] v1 = CitesteVector(n1);

            Console.Write("Introdu lungimea celui de-al doilea vector (v2): ");
            int n2 = int.Parse(Console.ReadLine());

            int[] v2 = CitesteVector(n2);

            int[] rezultat = Interclaseaza(v1, v2);

            Console.WriteLine("Al treilea vector ordonat crescator este:");
            AfiseazaVector(rezultat);
        }

        static int[] CitesteVector(int lungime)
        {
            int[] vector = new int[lungime];

            Console.WriteLine($"Introdu elementele vectorului in ordine crescatoare:");
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Elem {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            return vector;
        }

        static int[] Interclaseaza(int[] v1, int[] v2)
        {
            int n1 = v1.Length, n2 = v2.Length;
            int[] rezultat = new int[n1 + n2];

            int i = 0, j = 0, k = 0;

            while (i < n1 && j < n2)
            {
                rezultat[k++] = (v1[i] < v2[j]) ? v1[i++] : v2[j++];
            }

            while (i < n1)
            {
                rezultat[k++] = v1[i++];
            }

            while (j < n2)
            {
                rezultat[k++] = v2[j++];
            }

            return rezultat;
        }

        static void AfiseazaVector(int[] vector)
        {
            foreach (int element in vector)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
