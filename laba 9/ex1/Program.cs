using System.Text.RegularExpressions;

static class Programm
{
    enum Options { yes, no }
    static int findString(string s1, string s2, Options o)
    {
        if (o == Options.yes)
        {
            return new Regex(s2).Matches(s1).Count();
        }
        else if (o == Options.no)
        {
            return new Regex(s2, RegexOptions.IgnoreCase).Matches(s1).Count();
        }
        else
        {
            return 0;
        }
    }

    static void Main()
    {
        Options o = Options.yes;
        Console.WriteLine("Введите строку: ");
        string s1 = Console.ReadLine();
        Console.WriteLine("Введите подстроку для поиска: ");
        string s2 = Console.ReadLine();

        while(true)
        {
            Console.WriteLine("Учитывать регистр? yes/no ");
            string choose = Console.ReadLine().ToLower();

            if (choose == "yes")
            {
                o = Options.yes;
                break;
            }
            else if (choose == "no")
            {
                o = Options.no; break;
            }
            else
            {
                Console.WriteLine("yes or no!");
            }
        }
        Console.WriteLine("Количество вхождений: " + findString(s1, s2, o));
        Console.ReadLine();
    }
}