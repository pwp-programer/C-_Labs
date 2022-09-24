namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            int num1 = num / 100;
            int num2 = num % 100 / 10;
            int num3 = num % 10;

            Console.WriteLine((num1 + num2 + num3) / 3.0);
        }
    }
}