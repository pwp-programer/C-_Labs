using System.Text.RegularExpressions;

string data = Console.ReadLine();
Regex regex = new Regex(@"\d+");
MatchCollection matches = regex.Matches(data);

foreach (Match m in matches)
{
    Console.Write($" {m} ");

}
Console.ReadLine();