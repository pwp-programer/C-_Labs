using System;
using System.Threading;
namespace TaskApp
{    class Program
    {   static void Main(string[] args)
        {
            // WaitAll();
            WaitEnemy();
        }

        static void Display()
        {   Console.WriteLine("Начало работы метода Display");
            Console.WriteLine("Завершение работы метода Display");
        }

        static void Range()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Name()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Богдан");
            }
        }

        static void WaitAll()
        {
            Task task1 = new Task(Display);
            task1.Start();
            
            Task task2 = new Task(Range);
            task2.Start();
            
            Task task3 = new Task(Name);
            task3.Start();

            Task.WaitAll(task1, task2, task3);
            
            Console.WriteLine("Завершение метода Main");
            Console.ReadLine();
        }
        
        
        static void WaitEnemy()
        {
            Task task1 = new Task(Display);
            task1.Start();
            
            Task task2 = new Task(Range);
            task2.Start();
            
            Task task3 = new Task(Name);
            task3.Start();

            Task.WaitAny(task1, task2, task3);
            
            Console.WriteLine("Завершение метода Main");
            Console.ReadLine();
        }
    }
}
