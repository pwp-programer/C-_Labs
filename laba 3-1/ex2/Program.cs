namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());
        

            if(num >= 10000 && num<=99999 && num % 10 == 0)
            {
                Console.WriteLine("Число проходит все проверки");
            }
            else
            {
                Console.WriteLine("Число не прошло все проверки");
            }
            Console.ReadKey();
        }
    }
}