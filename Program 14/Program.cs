using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Introduceti cate elemente are vectorul: ");
            int n = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul de pe poz {i}: ");
                vec[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (vec[i] != 0)
                        swap(ref vec[i], ref vec[j]);
            

            for (int i = 0; i < n; i++)
                Console.Write($"{vec[i]} ");
        }
        static void swap(ref int a, ref int b)
        {
            int aux = a;
            a = b; b = aux;
        }
    }
    }
