using System.Xml;
namespace Laba_23;


public class Cinema
{
    public string Time { get; set; }
    public string Name { get; set; }
    public string Place { get; set; }

    public Cinema(string time, string name, string place)
    {
        Time = time;
        Name = name;
        Place = place;
    }

    public void Show()
    {
        Console.WriteLine($"Время: {Time}\nНазвание: {Name}\nМесто в зале: {Place}\n\n");
    }
}
