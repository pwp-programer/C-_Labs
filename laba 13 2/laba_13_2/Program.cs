public interface IGetSalary
{
    string name { get; }
    double salary { get; }
    double Get();
}

public class Worker : IGetSalary
{
    public Worker(string firstName, double salary)
    {
        name = firstName;
        this.salary = salary;
    }

    public string name { get; }
    public double salary { get; }

    public double Get()
    {
        return salary + salary * 0.1;
    }
}

public class Enjiner : IGetSalary
{
    public Enjiner(string firstName, double salary)
    {
        name = firstName;
        this.salary = salary;
    }

    public string name { get; }
    public double salary { get; }

    public double Get()
    {
        return salary + salary * 0.3;
    }
}

internal static class Program
{
    private static void Show(IGetSalary x)
    {
        Console.Write($"\n{x.name}, оклад {x.salary} к выдаче {x.Get()} руб.");
    }

    public static void Main(string[] args)
    {
        IGetSalary w = new Enjiner("Задора Богдан", 500);
        Show(w);
        
        w = new Enjiner("Павел Авсюкевич", 600);
        Show(w);
        
        w = new Enjiner("Влад Топор", 1200);
        Show(w);
    }
}