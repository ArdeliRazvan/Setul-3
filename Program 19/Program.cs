using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu lungimea vectorului s: ");
        int lungimeS = int.Parse(Console.ReadLine());

        int[] s = new int[lungimeS];

        Console.WriteLine("Introdu elementele vectorului s:");
        for (int i = 0; i < lungimeS; i++)
        {
            Console.Write($"Elementul {i}: ");
            s[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Introdu lungimea vectorului p: ");
        int lungimeP = int.Parse(Console.ReadLine());

        int[] p = new int[lungimeP];

        Console.WriteLine("Introdu elementele vectorului p:");
        for (int i = 0; i < lungimeP; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            p[i] = int.Parse(Console.ReadLine());
        }

        int numarAparitii = NumarAparitii(s, p);

        Console.WriteLine($"Vectorul p apare in vectorul s de {numarAparitii} ori.");
    }

    static int NumarAparitii(int[] s, int[] p)
    {
        int[] prefixFunctie = Prefix(p);
        int numarAparitii = 0;

        int i = 0; 
        int j = 0; 

        while (i < s.Length)
        {
            if (s[i] == p[j])
            {
                i++;
                j++;

                if (j == p.Length)
                {
                    numarAparitii++;
                    j = prefixFunctie[j - 1];
                }
            }
            else
            {
                if (j != 0)
                {
                    j = prefixFunctie[j - 1];
                }
                else
                {
                    i++;
                }
            }
        }

        return numarAparitii;
    }

    static int[] Prefix(int[] pattern)
    {
        int lungime = pattern.Length;
        int[] prefixFunctie = new int[lungime];
        int LPrefixTemp = 0;
        int i = 1;

        while (i < lungime)
        {
            if (pattern[i] == pattern[LPrefixTemp])
            {
                LPrefixTemp++;
                prefixFunctie[i] = LPrefixTemp;
                i++;
            }
            else
            {
                if (LPrefixTemp != 0)
                {
                    LPrefixTemp = prefixFunctie[LPrefixTemp - 1];
                }
                else
                {
                    prefixFunctie[i] = 0;
                    i++;
                }
            }
        }

        return prefixFunctie;
    }
}
