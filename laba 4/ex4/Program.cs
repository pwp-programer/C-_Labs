static void Sn(double a, double d, double n)
{
    double sum = 0;
    for (double i = a; i < n; i++)
    {
        sum += (i + 1) + d;
    }

    Console.WriteLine($"Сумма: {sum}");
    Console.ReadKey();
}


double a, d, n;

Console.WriteLine("Введите a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите d:");
d = double.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
n = double.Parse(Console.ReadLine());

Sn(a, d, n);