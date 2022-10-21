using System.Text.RegularExpressions;

int sum = 0;
string s = Console.ReadLine();
Regex regex = new Regex(@"[0-9]+");
MatchCollection matches = regex.Matches(s);
foreach (Match m in matches)
{
    Console.WriteLine(m.ToString());
    sum += Convert.ToInt32(m.Value);
}

Console.WriteLine(sum);
Console.ReadLine();