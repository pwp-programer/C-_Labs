namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            double num = double.Parse(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("Число положительное");
            }
            else if(num < 0)
            {
                Console.WriteLine("Число отрицательное");
            }
            else
            {
                Console.WriteLine("Число равно нулю");
            }
            Console.ReadKey();
        }
    }
}