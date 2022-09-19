namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите c: ");
            double c = double.Parse(Console.ReadLine());

            double answer = (a > b ? a : b) / (b > c ? b : c);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}