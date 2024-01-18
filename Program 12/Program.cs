using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
          
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul de pe poz {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                int k = i;
                for (int j = i + 1; j < n; j++)
                    if (a[k] > a[j])
                        k = j;
                        int aux = a[i];
                        a[i] = a[k];    
                        a[k] = aux;
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{a[i]} ");
        }
    }
}
