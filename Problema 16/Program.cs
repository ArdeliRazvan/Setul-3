using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu lungimea vectorului: ");
        int lungime = int.Parse(Console.ReadLine());

        int[] vector = new int[lungime];

        for (int i = 0; i < lungime; i++)
        {
            Console.Write($"Introdu elementul {i}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        int cmmd = CMMDC(vector, vector.Length);

        Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {cmmd}");
    }

    static int CMMDC(int[] vector, int n)
    {
        if (n == 1)
        {
            return vector[0];
        }

        return CMMDC(CMMDC(vector, n - 1), vector[n - 1]);
    }

    static int CMMDC(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }

        return CMMDC(b, a % b);
    }
}
