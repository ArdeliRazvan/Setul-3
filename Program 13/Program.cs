using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Introdu lungimea vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Program ob = new Program();
        ob.sort(arr);
        printArray(arr);
    }
    void sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write($"{arr[i]}");
    }
}