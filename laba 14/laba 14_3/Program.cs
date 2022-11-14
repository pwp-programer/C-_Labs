using System;

class Program
{
    
    static void Main()
    { 

        int[] N = new int[5];
        Random r = new Random();
        
        for(int i = 0; i < N.Length; i++)
        {
            Console.WriteLine($"Элемент массива {i}: {N[i] = r.Next(-10, 10)}");
        }

        try
        {
            Console.Write("Введите число: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int index2 = int.Parse(Console.ReadLine());

          
                Console.WriteLine($"Результат: {N[index-1] + N[index2-1]}");
            
        }
        catch(FormatException)
        {
            Console.WriteLine("Введите число!");
        }
        catch(IndexOutOfRangeException OutOfRange)
        {
            Console.WriteLine($"Ошибка: {OutOfRange.Message}");
        }
        
    }
}