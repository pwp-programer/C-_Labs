using System;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            global::System.Console.WriteLine("Введите m и n");
            int n = 0;
            int m = 0;
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            Random Random = new Random();

            int[,] array = new int[m, n];
            int[] sumStringMatric = new int[n];

            for (int i = 0; i < m; i++)
            {
                for (int q = 0; q < n; q++)
                {
                    array[i, q] = Random.Next(-10, 10);
                    Console.Write($"{array[i, q]} ");
                    sumStringMatric[i] += array[i, q];
                }
                Console.WriteLine(" ");
            }

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Сумма элементов {i + 1} строки матрицы {sumStringMatric[i]}");
            }

            Console.ReadKey();
        }
    }
}