using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_29
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introdu lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = CitesteVector(n);

            MergeSort(v, 0, v.Length - 1);

            Console.WriteLine("Vectorul sortat:");
            AfiseazaVector(v);
        }

        static int[] CitesteVector(int n)
        {
            int[] v = new int[n];

            Console.WriteLine($"Introdu elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elem {i}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            return v;
        }

        static void MergeSort(int[] v, int st, int dr)
        {
            if (st < dr)
            {
                int mijloc = (st + dr) / 2;

                MergeSort(v, st, mijloc);
                MergeSort(v, mijloc + 1, dr);

                Combina(v, st, mijloc, dr);
            }
        }

        static void Combina(int[] v, int st, int mijloc, int dr)
        {
            int n1 = mijloc - st + 1;
            int n2 = dr - mijloc;

            int[] stV = new int[n1];
            int[] drV = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                stV[i] = v[st + i];
            }

            for (int j = 0; j < n2; j++)
            {
                drV[j] = v[mijloc + 1 + j];
            }

            int k = st;
            int iSt = 0, iDr = 0;

            while (iSt < n1 && iDr < n2)
            {
                if (stV[iSt] <= drV[iDr])
                {
                    v[k] = stV[iSt];
                    iSt++;
                }
                else
                {
                    v[k] = drV[iDr];
                    iDr++;
                }
                k++;
            }

            while (iSt < n1)
            {
                v[k] = stV[iSt];
                iSt++;
                k++;
            }

            while (iDr < n2)
            {
                v[k] = drV[iDr];
                iDr++;
                k++;
            }
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
