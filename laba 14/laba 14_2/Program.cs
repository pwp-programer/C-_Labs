using System;

internal class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();

            if (password.Length != 5)
            {
                throw new Exception("Пароль должен быть в диапазоне от 0 до 5");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Заполните массив.");
                int[] arr = new int[5];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                try
                {
                    Console.Clear();
                    Console.WriteLine("Введите пароль: ");
                    string check_password = Console.ReadLine();

                    if (check_password != password)
                    {
                        throw new Exception("Пароли не совпадают");
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели верный пароль.\nВывод данных:");
                        foreach (int i in arr) Console.WriteLine(i);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введён неверный тип данных.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
}