namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int LenNumber = (int) Math.Log10(num) + 1;

            if(num > 1 && LenNumber == 5 && num % 10 == 0)
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