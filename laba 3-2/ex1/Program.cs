namespace laba_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                for (int i = a; i < b-1; i++)
			    {
                    Console.WriteLine($"Ваше число: {i+1}");
			    }
            }
            if (b < a)
            {
                for (int q = a; q > b+1; q--)
			    {
                    Console.WriteLine($"Ваше число: {q-1}");
			    }
            }
            Console.ReadKey();
        }
    }
}