using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Program
    {
        static int Main(string[] args)
        {   
            Console.Write("Introdu lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] vec = new int[n]; 
            Console.Write("Introdu k = ");
            int k = int.Parse(Console.ReadLine());
            bool ok = false;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Introdu numarul de pe poz {i}: ");
                vec[i] = int.Parse(Console.ReadLine());
            }
            int poz = 0;
            for (int i = 0; i < n; i++)
            {
                if (vec[i] == k)
                {
                    ok = true;
                    poz = i;
                }
            }
            if (ok)
               Console.WriteLine(poz);
            else Console.WriteLine(-1);

            return 0;
        }
    }
}
