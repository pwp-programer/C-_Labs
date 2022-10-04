static void Exchange(double a, double b)
{
    double buffer_a = a, buffer_b = b;
    b = buffer_a;
    a = buffer_b;
    Console.WriteLine($"Переменная а: {a}\nПеременная b: {b}");
    Console.ReadKey();
}

Console.WriteLine("Введите значение a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b: ");
double b = double.Parse(Console.ReadLine());

Exchange(a, b);