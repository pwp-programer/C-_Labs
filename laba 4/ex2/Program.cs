static void korni (double a, double b, double c)
{
    double d = Math.Pow(b,2.0) - 4.0 * a * c, x1, x2;
    
    if (d < 0)
    {
        Console.WriteLine("У уравнения нет корней.");
    }

    else if (d > 0)
    {
        Console.WriteLine($"У уравнения 2 корня: x1 = {x1 = (-b + Math.Sqrt(d)) / a} и x2 = {x2 = (-b - Math.Sqrt(d)) / a}");
    }

    else
    {
        Console.WriteLine($"У уравнения 1 корень: x1 = x2 = {-b / 2 * a}");
    }
}

Console.WriteLine("Введите значение a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение c: ");
double c = double.Parse(Console.ReadLine());

korni(a, b, c);
Console.ReadKey();