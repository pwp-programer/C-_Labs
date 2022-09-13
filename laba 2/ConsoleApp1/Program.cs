double x = Double.Parse(Console.ReadLine());
double y = Double.Parse(Console.ReadLine());
double c = 0.5 * Math.Pow(Math.E, y) + Math.Sin(y) / 8 * Math.Pow(y, x)
Console.WriteLine(c);