//Aufgabe 5a Tick , Trick & Track
for (int a = 1; a <= 100; a++)
{

    if (a % 5 == 0 && a % 3 == 0)
    {
        Console.WriteLine(a + " Track");
    }
    else if (a % 5 == 0)
    {
        Console.WriteLine(a + " Trick");
    }
    else if (a % 3 == 0)
    {
        Console.WriteLine(a + " Tick");
    }
    else
    {
        Console.WriteLine(a);
    }
}
