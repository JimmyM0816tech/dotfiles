using System.Linq;

StreamReader leser = new StreamReader("/home/uwu/Dokumente/projekte/c#/praktikum/hangman/Liste.txt");

string? zeile = leser.ReadLine() ;

List<string> list = new List<string>();
while (zeile != null) { 
    list.Add(zeile);
    zeile = leser.ReadLine();
}

Random rnd = new Random();
int randomNumber = rnd.Next() % list.Count;

string random = list[randomNumber].ToUpper();

int x = random.Count();
void bindestriche(string wort, HashSet<char> buchstaben)
{
    foreach (char buchstabe in wort)
    {
        if (buchstaben.Contains(buchstabe))
        {
            Console.Write(buchstabe);
        }
        else
        {
            Console.Write("-");
        }
    }
    Console.WriteLine();
}

bool geloest(string wort, HashSet<char> buchstaben) {
    bool ergebnis = true;


    foreach (char buchstabe in wort)
    {
        if (buchstaben.Contains(buchstabe) == false)
        {
            ergebnis = false;
        }
        
    }

    return ergebnis;
}
int Fehler = 0;

HashSet<char> chars = new HashSet<char>();

while (!geloest(random, chars) && Fehler <= 10) { 
    bindestriche(random,chars);

    Console.Write(Fehler + " Fehler >");
    string? buchstabe = Console.ReadLine();
    int y = buchstabe.Count();
    while (y != 1) {
        Console.WriteLine("Bitte gib genau einen Buchstaben ein");
        Console.Write(Fehler + " Fehler >");
        buchstabe = Console.ReadLine();
        y = buchstabe.Count();
    }

    char c = buchstabe.ToUpper().ElementAt(0);

    if (!random.Contains(c))
    {
        Console.WriteLine("Das ist Falsch");
        Fehler += 1;
    }
    else { 
        chars.Add(c);
    }
}
Console.WriteLine("Das Wort ist " + random);

if (geloest(random, chars))
{
    Console.WriteLine("Herzlichen Glückwunch! ");
}
