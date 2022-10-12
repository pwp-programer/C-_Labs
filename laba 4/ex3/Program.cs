static void Exchange(ref double a, ref double b)
{
    double c = a;
    a = b;
    b = c;
}

Console.WriteLine("Введите значение a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b: ");
double b = double.Parse(Console.ReadLine());


Exchange(ref a, ref b);
Console.WriteLine($"a: {a}\nb: {b}");
Console.ReadKey();