using System;
using System.Collections.Immutable;

namespace ex1
{
    class Worker
    {
        private string fio;
        private string post;
        private double salary;

        public string Fio
        {
            get { return fio; }
        }

        public string Post
        {
            get { return post; }
            set { post = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = Math.Abs(value); }
        }

        public void Show()
        {
            Console.WriteLine($"ФИО: {fio}\nДолжность: {post}\nЗарплата: {Bonus() + salary}");
        }

        public double Bonus()
        {
            if (post.ToLower().Contains("менеджер") == true)
            {
                return salary * 0.3;
            }
            else
            {
                return salary * 0.2;
            }
        }

        public Worker(string f, string p, double s)
        {
            fio = f;
            post = p;
            salary = s;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер: ");
            Worker[] w = new Worker[int.Parse(Console.ReadLine())];

            for (int i = 0; i < w.Length; i++)
            {
                w[i] = new Worker(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()));
            }


            for (int i = 0; i < w.Length; i++)
            {
                for (int j = 0; j < w.Length - 1; j++)
                {
                    if (w[j].Fio.CompareTo(w[j + 1].Fio) > 0)
                    {
                        Worker buf = w[j];
                        w[j] = w[j + 1];
                        w[j + 1] = buf;
                    }
                }
            }

            Console.WriteLine("Вывод данных: ");
            for (int i = 0; i < w.Length; i++)
            {
                w[i].Show();
            }

            Console.WriteLine("Введите минимальную зп: ");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Вывод данных: ");
            for (int i = 0; i < w.Length; i++)
            {
                if (sal <= w[i].Salary)
                { 
                    w[i].Show();
                }
            }
            Console.ReadLine();
        }
    }
}