using System.Threading;

public class Kabina
{
    public int x { get; set; }
    private object locker = new();

    public Kabina(object X)
    {
        x = (int)X;
    }

    public void Show()
    {
        Console.WriteLine(x);
    }

    public void Dobavka()
    {
        for (int i = 0; i < 10; i++)
        {
            lock (locker)
            {
                x++;
                Show();
            }
        }
    }

    public void Kvadratka()
    {
        lock (locker)
        {
            x *= x;
            Show();
        }
    }
}

class Program
{
    static void Main()
    {
        Kabina obj = new Kabina(int.Parse(Console.ReadLine()));
        Thread a = new Thread(obj.Dobavka);
        Thread b = new Thread(obj.Kvadratka);

        a.Start();
        b.Start();
    }
}