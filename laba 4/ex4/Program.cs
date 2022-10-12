static void Sn(double a, double d, double n, out double s)
{
    s = 0;
    for (double i = a; i < n; i++)
    {
        s += (i + 1) + d;
    }
}


double a, d, n, s = 1;

Console.WriteLine("Введите a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите d:");
d = double.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
n = double.Parse(Console.ReadLine());

Sn(a, d, n, out s);
Console.WriteLine($"Сумма: {s}");
Console.ReadKey();