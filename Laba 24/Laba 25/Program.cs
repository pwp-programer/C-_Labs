using System.Threading;

class Program
{
    static void Main()
    {
        Thread Potok = Thread.CurrentThread;
        Console.WriteLine($"Имя потока: {Potok.Name}");
        Potok.Name = "Pawa loh";
        Console.WriteLine($"Имя потока: {Potok.Name}");
        Console.WriteLine($"Приоритет потока: {Potok.Priority}");
        Console.WriteLine($"Статус потока: {Potok.ThreadState}");
    }
}