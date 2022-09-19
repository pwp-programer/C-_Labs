Console.WriteLine("Введите число: ");
double num = double.Parse(Console.ReadLine());
Console.WriteLine(Math.Sqrt(num) * Math.Sqrt(num) == num ? "является" : "не является");
Console.ReadKey();

// TODO: Проверить правильность решения