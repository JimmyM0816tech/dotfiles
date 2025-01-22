using System.Diagnostics;

long versuch1(long n) { 
    long a = 1;

    List<long> zahlen = new List<long>();

    while (!(a == n + 1))
    {
        zahlen.Add(a);
    
        a++;
    }

    long summe = zahlen.Sum();
    Console.WriteLine(summe);
    return summe;
}


long versuch2(long n) {
    long a = 1;
    long zwichensumme = 0;
    while (!(a == n + 1))
    {
        zwichensumme += a;
        a++;
    }

    Console.WriteLine(zwichensumme);
    return zwichensumme;
}
long versuch3 (long n)
{
    long zwichensumme = 0;

    for (long a = 0; a <= n; a++)
    {
        zwichensumme += a;
 
    }
    Console.WriteLine(zwichensumme);
    return zwichensumme;
}
long alternative1 (long n)
{
    long ergebnis = n * (n + 1) / 2;
    Console.WriteLine(ergebnis);
    return ergebnis;
  
}
long stopuhr (long n)
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    long ergebnis = versuch2(n);
    stopwatch.Stop();
    Console.WriteLine("zeit für versuch1: " + stopwatch.Elapsed);
    return ergebnis;
}
long stopuhr2(long n)
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    long ergebnis = alternative1(n);
    stopwatch.Stop();
    Console.WriteLine("zeit für alternative1: " + stopwatch.Elapsed);
    return ergebnis;
}

long n = 100;
Console.WriteLine("Zahl: " + n);
stopuhr(n);
stopuhr2(n);
