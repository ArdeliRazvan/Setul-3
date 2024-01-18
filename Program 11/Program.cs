using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
                Console.WriteLine("Dati n: ");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                a[0] = 1;
                a[1] = 1;
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    for (int j = 2; i * j < n; j++)
                        a[i * j] = 1;
                }
                for (int i = 0; i < n; i++)
                {
                    if (a[i] == 0)
                        Console.Write($"{i} ");
                }
        }
    }
}
