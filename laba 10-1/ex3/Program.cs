namespace ex3
{
    class MyClass
    {
        static double Factorial(double num, int it)
        {
            double s = 1;
            while(it <= num)
            {
                s *= it;
                it++;
            }
            return s;
        }

        static double Fibonachi(double end)
        {
            int i = 0;
            double fib_sum = 0;
            double fib1 = 1, fib2 = 1;

            while (i < end-2)
            {
                fib_sum = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib_sum;
                i++;
            }
            return fib_sum;
        }

        public void Print()
        {
            MyClass c = new MyClass();
            double n = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double res = Factorial(n, 1);
            double res2 = Fibonachi(n2);
            Console.WriteLine("Факториал: " + res);
            Console.WriteLine($"Фибоначчи: {res2}");
            Console.ReadLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            c.Print();
        }
    }
}