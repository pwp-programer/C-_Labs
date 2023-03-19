using System;
using System.IO.IsolatedStorage;
using System.Xml.Linq;

class Cinema
{
    public string time { get; set; }
    public string name { get; set; }
    public int place { get; set; }

    public Cinema(string t, string n, int p)
    {
        time = t;
        name = n;
        place = p;
    }

    public void Show()
    {
        Console.WriteLine($"Время: {time}\nНазвание: {name}\nМесто в зале: {place}\n\n");
    }
}


class Program
{
    public static void Task1()
    {
        List<Cinema> l = new List<Cinema>();
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Введите время сеанса: ");
            string time = Console.ReadLine();

            Console.WriteLine("Введите название фильма: ");
            string name = Console.ReadLine();


            Console.WriteLine("Введите номер места: ");
            int place = int.Parse(Console.ReadLine());

            l.Add(new Cinema(time, name, place));
        }

        XDocument xdoc = new XDocument();
        XElement films = new XElement("films");

        foreach (Cinema i in l)
        {
            XElement film = new XElement("film");

            XElement time = new XElement("time", i.time);
            XElement name = new XElement("name", i.name);
            XElement place = new XElement("place", i.place);

            film.Add(time);
            film.Add(name);
            film.Add(place);

            films.Add(film);
        }
        xdoc.Add(films);
        xdoc.Save(@"C:\github\Csharp_Labs\Laba_24\bin\Debug\net6.0\1.xml");
    }

    public static void Task2()
    {
        XDocument xdoc = XDocument.Load(@"C:\github\Csharp_Labs\Laba_24\bin\Debug\net6.0\1.xml");
        XElement films = xdoc.Element("films");

        foreach(XElement f in films.Elements("films"))  
        {
            XElement time = f.Element("time");
            XElement name = f.Element("name");
            XElement place = f.Element("place");

            Console.WriteLine($"Время сеанса: {time.Value}");
            Console.WriteLine($"Название: : {name.Value}");
            Console.WriteLine($"Место: {place.Value}" + "\n\n");
        }

        Console.WriteLine("Введите время сеанса: ");
        string Time = Console.ReadLine();

        Console.WriteLine("Введите название фильма: ");
        string Name = Console.ReadLine();

        Console.WriteLine("Введите место в зале: ");
        int Place = int.Parse(Console.ReadLine());

        XElement NewFilm = new XElement("film");

        XElement NewTypeTime = new XElement("time", Time);
        XElement NewTypeName = new XElement("name", Name);
        XElement NewTypePlace = new XElement("place", Place);

        NewFilm.Add(NewTypeTime);
        NewFilm.Add(NewTypeName);
        NewFilm.Add(NewTypePlace);

        films.Add(NewFilm);
        xdoc.Save(@"C:\github\Csharp_Labs\Laba_24\bin\Debug\net6.0\2.xml");

        foreach (XElement i in films.Elements("films"))
        {
            XElement time = i.Element("time");
            XElement name = i.Element("name");
            XElement place = i.Element("place");

            Console.WriteLine($"Время: {time.Value}");
            Console.WriteLine($"Название: {name.Value}");
            Console.WriteLine($"Место: {place.Value}");

            Console.WriteLine();
        }
    }
    static void Main()
    {
        Task1();
        Task2();
    }
}