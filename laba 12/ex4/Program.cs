using System;
using System.Drawing;

namespace ex3
{
    class Ploshca_Peramogi
    {
        private double num1;
        private double a;
        private double b;
        private double h;
        private double res;
        
        public Ploshca_Peramogi(double num1)
        {
            this.num1 = num1;
            res = num1 * num1;
        }


        public Ploshca_Peramogi(double a, double b)
        {
            this.a = a;
            this.b = b;
            res = a * b;
        }


        public Ploshca_Peramogi(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
            res = (a + b) / 2 * h;
        }

        public double Square()
        {
            return res;
        }

    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Ploshca_Peramogi p_k = new Ploshca_Peramogi(4);
            Ploshca_Peramogi p_p = new Ploshca_Peramogi(4, 6);
            Ploshca_Peramogi p_t = new Ploshca_Peramogi(4, 4, 8);

            Console.WriteLine(p_k.Square());
            Console.WriteLine(p_p.Square());
            Console.WriteLine(p_t.Square());
            Console.ReadKey();
        }
    }
}