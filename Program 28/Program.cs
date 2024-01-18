using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_28
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introdu lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = CitesteVector(n);

            Quicksort(v, 0, v.Length - 1);

            Console.Write("Vectorul sortat:");
            AfiseazaVector(v);
        }

        static int[] CitesteVector(int n)
        {
            int[] v = new int[n];

            Console.WriteLine($"Introdu elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elem {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            return v;
        }

        static void Quicksort(int[] v, int st, int dr)
        {
            if (st < dr)
            {
                int pivotIndex = Partitie(v, st, dr);

                Quicksort(v, st, pivotIndex - 1);
                Quicksort(v, pivotIndex + 1, dr);
            }
        }

        static int Partitie(int[] v, int st, int dr)
        {
            int pivot = v[dr];
            int i = st - 1;

            for (int j = st; j < dr; j++)
            {
                if (v[j] <= pivot)
                {
                    i++;
                    Schimba(v, i, j);
                }
            }

            Schimba(v, i + 1, dr);
            return i + 1;
        }

        static void Schimba(int[] v, int i, int j)
        {
            int temp = v[i];
            v[i] = v[j];
            v[j] = temp;
        }

        static void AfiseazaVector(int[] v)
        {
            foreach (int elem in v)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
        }
    }
}
