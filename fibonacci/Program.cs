//Aufgabe_6 - Fibannacci-folge
using System.Diagnostics;

long Fibonacci_rekursiv_positiv (long n)
{
    if (n <= 1) return n; 
    return Fibonacci_rekursiv_positiv(n - 1) + Fibonacci_rekursiv_positiv(n - 2);
    
}

long Fibonacci_iterativ (long n)
{
    if (n <= 1) return n;
    long a = 0, b = 1, c = 0; 
    for (long i = 2; i <= n; i++) 
    { 
        c = a + b; a = b; b = c; 
    }
    return c;
}
long Fibonacci_rekusiv_negativ_positiv(long n)
{
    if (n == 0) return 0;
    if (n == 1 || n == -1) return 1;
    if (n > 1)
    {
        return Fibonacci_rekusiv_negativ_positiv(n - 1) + Fibonacci_rekusiv_negativ_positiv(n - 2);
    }
    else
    {
        return (long)Math.Pow(-1, n + 1) * Fibonacci_rekusiv_negativ_positiv(-n);
    }
}

long Fibonacci_iterativ_negativ_positiv (long n)
{
    if (n == 0) return 0;
    if (n == 1 || n == -1) return 1;
    long a = 0, b = 1;
    if (n > 0)
    {
        for (long i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
    else
    {
        n = -n;
        for (long i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
        }
        return (n % 2 == 0) ? -b : b;
    }
}
void Fibonacci_timer_random_rekursiv ()
{
    Random r = new Random();
    long random_zahl1 = r.Next(10);
    long random_zahl2 = r.Next(60);
    Stopwatch stoppuhr1= new Stopwatch();
    stoppuhr1.Start ();
    Console.WriteLine("Zahl: " + random_zahl1);
    Console.WriteLine("Fibonacci zahl: " + Fibonacci_rekursiv_positiv(random_zahl1));
    stoppuhr1.Stop ();
    Console.WriteLine(stoppuhr1.Elapsed);
    Stopwatch stoppuhr2 = new Stopwatch();
    stoppuhr2.Start ();
    Console.WriteLine("Zahl: " + random_zahl2);
    Console.WriteLine("Fibonacci zahl: " + Fibonacci_rekursiv_positiv(random_zahl2));
    stoppuhr2.Stop ();
    Console.WriteLine(stoppuhr2.Elapsed);
}

void Fibonacci_timer_vergleich()
{
    Console.Write("Bitte gib eie zahl ein: ");
    long zahl = long.Parse(Console.ReadLine());
    Stopwatch stoppuhr1 = new Stopwatch();
    stoppuhr1.Start ();
    Console.WriteLine("Fibonacci zahl iterativ: " + Fibonacci_iterativ(zahl));
    stoppuhr1.Stop ();
    Console.WriteLine("Zeit iterativ: " + stoppuhr1.Elapsed);
    Stopwatch stoppuhr2= new Stopwatch();
    stoppuhr2.Start ();
    Console.WriteLine("Fibonacci zahl rekursiv: " + Fibonacci_rekursiv_positiv (zahl));
    stoppuhr2.Stop ();
    Console.WriteLine("Zeit rekursiv: " + stoppuhr2 .Elapsed);
}

Fibonacci_timer_vergleich();
