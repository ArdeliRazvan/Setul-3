using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu numarul in baza 10: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Introdu baza (1 < b < 17): ");
        int b = int.Parse(Console.ReadLine());

        if (b > 1 && b < 17)
        {
            string rezultat = Conversie(n, b);
            Console.WriteLine($"Numarul {n} in baza {b} este: {rezultat}");
        }
        else
        {
            Console.WriteLine("Baza trebuie sa fie intre 2 si 16.");
        }
    }

    static string Conversie(int n, int b)
    {
        if (n == 0)
        {
            return "0";
        }

        string rezultat = "";

        while (n > 0)
        {
            int rest = n % b;
            char cifra;

            if (rest < 10)
            {
                cifra = (char)(rest + '0');
            }
            else
            {
                cifra = (char)(rest - 10 + 'A');
            }

            rezultat = cifra + rezultat;
            n /= b;
        }

        return rezultat;
    }
}
