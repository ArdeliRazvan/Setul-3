using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Introdu lungimea vectorului: ");
        int lungime = int.Parse(Console.ReadLine());

        int[] vector = new int[lungime];

        for (int i = 0; i < lungime; i++)
        {
            Console.Write($"Introdu elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        EliminaDuplicate(ref vector);

        Console.Write("Vectorul modificat: ");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
    }

    static void EliminaDuplicate(ref int[] vector)
    {
        List<int> EleUnice = new List<int>();
        List<int> PozDeEliminare = new List<int>();

        for (int i = 0; i < vector.Length; i++)
        {
            if (!EleUnice.Contains(vector[i]))
            {
                EleUnice.Add(vector[i]);
            }
            else
            {
                PozDeEliminare.Add(i);
            }
        }

        // Elimină elementele duplicate din vector
        for (int i = PozDeEliminare.Count - 1; i >= 0; i--)
        {
            vector = EliminaElement(vector, PozDeEliminare[i]);
        }
    }

    static int[] EliminaElement(int[] vector, int index)
    {
        int[] nouVector = new int[vector.Length - 1];
        Array.Copy(vector, 0, nouVector, 0, index);
        Array.Copy(vector, index + 1, nouVector, index, vector.Length - index - 1);
        return nouVector;
    }
}
