using System;

namespace laba_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, sum_num = 0, min_num = int.MaxValue, half_lips = 0, negative_values = 0, amount = 0;

            Console.WriteLine("Введите число: ");
            num = int.Parse(Console.ReadLine());


            while(true)
            {
                if (num == 0)
                {
                    Console.WriteLine($"Среднее арифметическое: {sum_num / amount}\n" +
                    $"Минимальное значение: {min_num}\n" +
                    $"Количество положительных чисел: {half_lips}\n" +
                    $"Количество отрицательных чисел: {negative_values}");
                    Console.ReadKey();
                    break;
                }

                if(min_num > num && num != 0)
                {
                    min_num = num;
                }

                sum_num += num;
                amount += 1;

                if(num > 0)
                {
                    half_lips += 1;
                }
                else
                {
                    negative_values += 1;
                }

                Console.WriteLine("Введите число: ");
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
