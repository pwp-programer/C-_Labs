namespace laba_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                for (int i = a; i < b; i++) 
                {
                    Console.WriteLine($"Ваше число: {i+1}"); 
                }
            }
            else if (b < a)
            {
                for (int q = a; q > b; q--) 
                {
                    Console.WriteLine($"Ваше число: {q-1}"); 
                }
            }
            Console.ReadKey();
        }
    }
}