using System.Text.RegularExpressions;


string s = Console.ReadLine();
Regex regex = new Regex(@"\w@gmail.com$");
if (regex.IsMatch(s))
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}

Console.ReadLine();