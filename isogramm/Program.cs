//Aufgabe 5d - Isogramm
using System.Text.RegularExpressions;
Console.Write("Wort / satz eingeben: ");
string wort = Regex.Replace(Console.ReadLine().ToLower(), "[^a-zäüöß]", "");

char[] buchstaben = wort.ToCharArray();
//bustaben zaelen
int[] zaehlen(char[] buchstaben)
{
    int[] buchstaben_zahl = new int[30];

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
        else if (buchstabe == 'ß')
        {
            buchstaben_zahl[29] += 1;
        }
        else
        {
            buchstaben_zahl[buchstabe - 'a'] += 1;
        }
    }
    return buchstaben_zahl;
}

//überpüfen ob es ein Isogramm ist
int[] buchstaben_zahl1 = zaehlen(buchstaben);

bool isIsogramm = true;
foreach (int anzahl in buchstaben_zahl1)
{
    if (anzahl > 1)
    {
        isIsogramm = false;
        break;
    }
}

if (isIsogramm)
{
    Console.WriteLine("Das Wort / Satz ist ein Isogramm.");
}
else
{
    Console.WriteLine("Das Wort / Satz ist kein Isogramm.");
}
