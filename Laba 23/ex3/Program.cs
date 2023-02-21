using System.Xml;

class Program
{
    static void Main()
    {
        string time, name, place;
        Console.WriteLine("Введите время сеанса: ");
        time = Console.ReadLine();

        Console.WriteLine("Введите название фильма: ");
        name = Console.ReadLine();

        Console.WriteLine("Введите место в зале: ");
        place = Console.ReadLine();
        
        XmlDocument d = new XmlDocument();
        d.Load(@"C:\github\Csharp_Labs\Laba 23\ex2\bin\Debug\net6.0\1.xml");

        XmlElement root = d.DocumentElement;
        XmlElement u = d.CreateElement("film");
        u.SetAttribute("time", time);
        u.SetAttribute("name", name);
        u.SetAttribute("place", place);

        root.AppendChild(u);
        
        d.Save(@"C:\Users\Bogda\OneDrive\Рабочий стол\1.xml");
        
        
    }
}