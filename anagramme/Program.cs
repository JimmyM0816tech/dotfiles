//Aufgabe 5c - Anagrammm
using System.Text.RegularExpressions;

Console.Write("1 wort/satz: ");
string a = Regex.Replace(Console.ReadLine().ToLower(), "[^a-zäöü]", "");
Console.Write("2 wort/satz: ");
string b = Regex.Replace(Console.ReadLine().ToLower(), "[^a-zäöü]", "");

char[] buchstaben_a = a.ToArray();
char[] buchstaben_b = b.ToArray();

int[] buchstaben(char[] buchstaben)
{
    int[] buchstaben_zahl = new int[29];

    foreach (char buchstabe in buchstaben)
    {
        if (buchstabe == 'ä')
        {
            buchstaben_zahl[26] += 1;
        }
        else if (buchstabe == 'ö')
        {
            buchstaben_zahl[27] += 1;
        }
        else if (buchstabe == 'ü')
        {
            buchstaben_zahl[28] += 1;
        }
        else
        {
            buchstaben_zahl[buchstabe - 'a'] += 1;
        }
    }
    return buchstaben_zahl;
}


int[] buchstaben_zahl = buchstaben(buchstaben_a);
int[] buchstaben_zahl2 = buchstaben(buchstaben_b);

if (buchstaben_zahl.SequenceEqual(buchstaben_zahl2))
{
    Console.WriteLine("es ist ein Anagramm !");
}
else
{
    Console.WriteLine("es ist kein Anagramm !");
}
