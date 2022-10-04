namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine()), eps = double.Parse(Console.ReadLine()), s = double.MaxValue, r = double.MaxValue;

            for (int i = 1; i < n; i++)
            {
                s += i / Math.Pow((i + 1), 2);
            }
            Console.WriteLine($"Сумма конечного ряда чисел: {s}\n");

            for (int i = 1; i / Math.Pow((i + 1), 2) > eps; i++)
            {
                r += i / Math.Pow((i + 1), 2);
            }

            Console.WriteLine($"Сумма бесконечного ряда чисел с точностью {eps}: {r}");
            Console.ReadKey();
        }
    }
}