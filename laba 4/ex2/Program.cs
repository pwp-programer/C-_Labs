static void korni (double a, double b, double c, out double x1, out double x2)
{
    double d = Math.Pow(b,2.0) - 4.0 * a * c;
   

    if (d < 0)
    {
        x1=x2=0;
    }

    else if (d > 0)
    {
        x1 = -b + Math.Sqrt(d) / (2 * a);
        x2 = (-b - Math.Sqrt(d)) / (2 * a);
    }

    else
    {
        x1=x2= -b / (2 * a);
    }
   
}

Console.WriteLine("Введите значение a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение c: ");
double c = double.Parse(Console.ReadLine());

double x1, x2;
korni(a, b, c, out x1, out x2);
Console.WriteLine(x1 + " "+x2);
Console.ReadKey();