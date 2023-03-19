using System.Threading;


class Program
{
    public static void PawaSpit()
    {
        for (int i = 1; i <= 50; i++)
        {
            Thread.Sleep(1000);
            Random r = new Random();
            Console.WriteLine(r.Next(1, 20));

        }
    }
    static void Main()
    {
        Thread a = new Thread(PawaSpit);
        a.Start();
        for (int i = 1; i <= 20; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Статус Pawbl: {a.ThreadState}");
        }
    }
}