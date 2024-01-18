using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu lungimea primului vector: ");
        int n1 = int.Parse(Console.ReadLine());

        string[] v1 = new string[n1];

        Console.WriteLine("Introdu cuvintele primului vector:");
        for (int i = 0; i < n1; i++)
        {
            Console.Write($"Cuvantul {i + 1}: ");
            v1[i] = Console.ReadLine();
        }

        Console.Write("Introdu lungimea celui de-al doilea vector: ");
        int n2 = int.Parse(Console.ReadLine());

        string[] v2 = new string[n2];

        Console.WriteLine("Introdu cuvintele celui de-al doilea vector:");
        for (int i = 0; i < n2; i++)
        {
            Console.Write($"Cuvantul {i + 1}: ");
            v2[i] = Console.ReadLine();
        }

        int rezultat = ComparaLexicografic(v1, v2);

        if (rezultat < 0)
        {
            Console.WriteLine("Primul vector apare primul lexicografic.");
        }
        else if (rezultat > 0)
        {
            Console.WriteLine("Cel de-al doilea vector apare primul lexicografic.");
        }
        else
        {
            Console.WriteLine("Vectorii sunt identici lexicografic.");
        }
    }

    static int ComparaLexicografic(string[] v1, string[] v2)
    {
        int n = Math.Min(v1.Length, v2.Length);

        for (int i = 0; i < n; i++)
        {
            int comparatie = string.Compare(v1[i], v2[i], StringComparison.OrdinalIgnoreCase);

            if (comparatie != 0) return comparatie;
        }

        return v1.Length.CompareTo(v2.Length);
    }
}
