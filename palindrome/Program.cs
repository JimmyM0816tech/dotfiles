//Aufgabe 5b - Palindorme
using System.Text.RegularExpressions;
Console.Write("Gib ein Wort oder Satz ein: ");
string word = Regex.Replace(Console.ReadLine().ToLower(), "[^a-zäöü]", "");
char[] charArray = word.ToCharArray();
Array.Reverse(charArray);
string reversedWord = new string(charArray);

if (word == reversedWord)
{
    Console.WriteLine("Es ist ein Palidrom! ");
}
else
{
    Console.WriteLine("Es ist kein Palidrom! ");
}
