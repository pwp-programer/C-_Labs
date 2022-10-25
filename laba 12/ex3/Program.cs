using System;
using System.Drawing;

namespace ex3
{
    class Matrix
    {
        private int size1;
        private int size2;
        double[,] arr;

        // Квадратная матрица 
        public Matrix(int size)
        {
            this.size1 = size;
            this.size2 = size;
            arr = new double[size, size];
        }

        // Прямоугольная матрица
        public Matrix(int size1, int size2)
        {
            this.size1 = size1;
            this.size2 = size2;
            arr = new double[size1, size2];
        }


        public void Input()
        {
            for (int i = 0; i < size1; i++)
            {
                for (int q = 0; q < size2; q++)
                {
                    Console.WriteLine($"{i + 1}-{q + 1}: ");
                    arr[i, q] = double.Parse(Console.ReadLine());
                }
            }
        }


        public void Input(int s1, int s2)
        {
            Random r = new Random();

            for (int i = 0; i < this.size1; i++)
            {
                for (int q = 0; q < this.size2; q++)
                {
                    arr[i, q] = r.Next(s1, s2);
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Ваша матрица: ");
            for (int i = 0; i < size1; i++)
            {
                for (int q = 0; q < size2; q++)
                {
                    Console.Write(arr[i, q] + " ");
                }
                Console.WriteLine();
            }
        }


        public static Matrix operator + (Matrix a, int x)
        {
            for (int i = 0; i < a.size1; i++)
            {
                for (int q = 0; q < a.size2; q++)
                {
                    a.arr[i, q] += x;
                }
            }
            return a;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(2, 3);
            m.Input(-10, 10);
            m.Show();
            m += 10;
            m.Show();
        }
    }
}