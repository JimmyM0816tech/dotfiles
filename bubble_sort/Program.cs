//Aufgabe: Bubble sort
using System.Diagnostics;

void Bubble_sort ()
{
    Console.Write("Bitte gib ein wie viele zahlen du möchtest: ");
    long n = long.Parse(Console.ReadLine());
    long[] arr = new long[n];

    Console.Write("Wie groß sollen deine Zahlen maximal sein?: ");
    long max = long.Parse(Console.ReadLine());
    Random rnd = new Random();
    for (long i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, (int)max);
    }

    Console.WriteLine("vor dem Sortieren: ");
    AusgabeArray(arr);
    BubbleSort(arr);
    Console.WriteLine("nach dem Sortieren: ");
    AusgabeArray(arr);

    void BubbleSort(long[] arr)
    {
        long n = arr.Length;
        for (long i = 0; i < n - 1; i++)
        {
            for (long j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    long temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    void AusgabeArray(long[] arr)
    {
        foreach (long num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

void Bubble_Sort_Zeit()
{
    Stopwatch tmr = new Stopwatch();
    Console.Write("Bitte gib ein wie viele zahlen du möchtest: ");
    long n = long.Parse(Console.ReadLine());
    long[] arr = new long[n];

    Console.Write("Wie groß sollen deine Zahlen maximal sein?: ");
    long max = long.Parse(Console.ReadLine());
    Random rnd = new Random();
    for (long i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, (int)max);
    }

    Console.WriteLine("vor dem Sortieren: ");
    AusgabeArray(arr);
    tmr.Start();
    BubbleSort(arr);
    tmr.Stop();
    Console.WriteLine("nach dem Sortieren: ");
    AusgabeArray(arr);

    void BubbleSort(long[] arr)
    {
        long n = arr.Length;
        for (long i = 0; i < n - 1; i++)
        {
            for (long j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    long temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    void AusgabeArray(long[] arr)
    {
        foreach (long num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Zeit: " + tmr.Elapsed);
}
Bubble_Sort_Zeit();
