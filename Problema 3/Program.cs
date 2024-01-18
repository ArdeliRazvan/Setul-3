using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Program
    {
        private static void Main()
        {
            int min1 = int.MaxValue, max1 = int.MinValue, pozMax = 0, pozMin = 0;
            Console.Write("Dimensiunea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul de pe poz {i}: ");
                vec[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (vec[i] >= max1)
                {
                    max1 = vec[i];
                    pozMax = i;
                }
                if (vec[i] <= min1)
                {
                    min1 = vec[i];
                    pozMin = i;
                }
            }
            Console.WriteLine($"Nr cel mai mic se afla pe pozitia: {pozMin}");
            Console.WriteLine($"Nr cel mai mare se afla pe pozitia: {pozMax}");
        }
    }
}