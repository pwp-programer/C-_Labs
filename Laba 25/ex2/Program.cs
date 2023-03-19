using System;

class Program
{
    static void IsSimple(int number)
    {
        if (number > 1)
        {
            for (var i = 2u; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"Число {number} не является простым");
                    return;
                }
            }
        }

        Console.WriteLine($"Число {number} является простым");
        return;
    }
    
    
    static void Main()
    {
        Random random = new Random();
        List<int> arr = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            arr.Add(random.Next(1, 10));
        }
        
        
        ParallelLoopResult result = Parallel.ForEach<int>(arr,
            IsSimple);
        Console.ReadLine();
    }
}