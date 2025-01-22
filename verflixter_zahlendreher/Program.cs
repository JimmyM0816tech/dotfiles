Console.WriteLine("Die zahlen sind :");
for (int i = 100000; i <= 333333; i++)
{
    string y = i + "";
    char x = y[0];
    string z = y.Substring(1);
    int a = int.Parse(z + x);
    int b = i * 3;
    if (a == b)
    {
        Console.WriteLine(i);
    }
}
