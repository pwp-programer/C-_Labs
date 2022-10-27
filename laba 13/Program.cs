using System;

namespace laba_13
{
    abstract class Figure
    {
        public double size { get; set; }

        public Figure(double size)
        {
            this.size = size;
        }

        public abstract double Area();
    }
    
    
    class Square : Figure
    {
        public Square(double size) : base(size)
        {
            Console.WriteLine($"Размер стороны квадрата: {size}");
        }

        public override double Area()
        {
            return size * size;
        }
    }


    class Krug : Figure
    {
        public Krug(double size) : base(size)
        {
            Console.WriteLine($"Размер окружности: {size}");
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(size, 2); 
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            Figure[] arr = new Figure[size];
            Random r = new Random();
            double s = 0;
            double o = 0;

            for (int i = 0; i < size; i++)
            {
                if(r.Next(0, 2) == 0)
                {
                    arr[i] = new Square(r.Next(1, 10));
                    s += arr[i].Area();
                }
                else
                {
                    arr[i] = new Krug(r.Next(1, 10));
                    o += arr[i].Area();
                }
            }
            Console.WriteLine($"Сумма площади квадратов: {s}\nСумма площадей окружностей: {o}");
            Console.ReadLine();
        }
    }
}