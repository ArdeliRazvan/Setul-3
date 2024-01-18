using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente ale vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vec = new int[n];


            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i}: ");
                vec[i] = int.Parse(Console.ReadLine());
            }


            int celMaiMic = vec[0];
            int celMaiMare = vec[0];


            int contorCelMaiMic = 0;
            int contorCelMaiMare = 0;


            for (int i = 0; i < n; i++)
            {
                if (vec[i] < celMaiMic)
                {
                    celMaiMic = vec[i];
                    contorCelMaiMic = 1;
                }
                else if (vec[i] == celMaiMic)
                {
                    contorCelMaiMic++;
                }

                if (vec[i] > celMaiMare)
                {
                    celMaiMare = vec[i];
                    contorCelMaiMare = 1;
                }
                else if (vec[i] == celMaiMare)
                {
                    contorCelMaiMare++;
                }
            }
            Console.WriteLine($"Cea mai mica valoare: {celMaiMic}, apare de {contorCelMaiMic} ori.");
            Console.WriteLine($"Cea mai mare valoare: {celMaiMare}, apare de {contorCelMaiMare} ori.");
        }

    }
}
