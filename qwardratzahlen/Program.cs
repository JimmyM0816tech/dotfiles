void quadratzahlen (int n)
{
    for (long a = 0; a <= Math.Sqrt(n); a++)
    {
        for (long b = a; b <= Math.Sqrt(n); b++)
        {
            for (long c = b; c <= Math.Sqrt(n); c++)
            {
                long x = a * a;
                long y = b * b;
                long z = c * c;

                if (x + y + z == n)
                {
                    Console.WriteLine(a + "²+" + b + "²+" + c+ "²= " + n);
                }
            }
        }
    }
}


bool existiert(int n)
{
    for (long a = 0; a <= Math.Sqrt(n); a++)
    {
        for (long b = a; b <= Math.Sqrt(n); b++)
        {
            for (long c = b; c <= Math.Sqrt(n); c++)
            {
                long x = a * a;
                long y = b * b;
                long z = c * c;

                if (x + y + z == n)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void auflistung()
{
    Console.WriteLine("Diese Jahre von 2000 bis 2100 funktionieren nicht Mit Dieser Rechnungsart: ");
    for (int i = 2000; i <= 2100; ++i)
    {
        if (existiert(i) == false)
        {
            Console.WriteLine(i);
        }
    }
}

void auflistung2()
{
    Console.WriteLine("Diese Jahre von 2000 bis 2100 funktionieren Mit Dieser Rechnungsart: ");
    for (int i = 2000; i <= 2100; ++i)
    {
        if (existiert(i) == true)
        {
            Console.WriteLine(i);
        }
    }
}

quadratzahlen(2024);
auflistung();
