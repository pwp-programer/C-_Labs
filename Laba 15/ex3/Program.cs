namespace ConsoleApp
{
    delegate void MathNums();

    class Array
    {
        public int[] arr { get; set; }

        public Array(int n)
        {
            this.arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                this.arr[i] = rnd.Next(-10, 10);
        }

        public void MaxValue()
        {
            Console.WriteLine("Максимальное значение массива: " + arr.Max());
        }

        public void MinValue()
        {
            Console.WriteLine("Минимальное значение массива: " + arr.Min());
        }

        public void Sum()
        {
            double sum = 0;
            foreach (int num in arr)
                sum += num;
            Console.WriteLine("Сумма значений массива: " + sum);
        }

        public void MidlleValue()
        {
            double sum = 0;
            foreach (int num in arr)
                sum += num;
            Console.WriteLine("Среднее значение массива: " + sum / arr.Length);
        }

        public void Show()
        {
            Console.Write("Значения массива: ");
            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }

    class Programm
    {
        static MathNums Do;

        static void Main()
        {
            string buf;
            Array array = new Array(5);
            while (true)
            {
                Console.WriteLine(
                    "Выберите действие: \n" +
                    "1 - вывести массив \n" +
                    "2 - минимальный элемент \n" +
                    "3 - максимальный элемент \n" +
                    "4 - сумма элементов \n" +
                    "5 - среднее значение элементов \n" +
                    "6 - вывести");

                buf = Console.ReadLine();

                switch (buf)
                {
                    case "1":
                        array.Show();
                        break;
                    case "2":
                        Do += array.MaxValue;
                        break;
                    case "3":
                        Do += array.MinValue;
                        break;
                    case "4":
                        Do += array.Sum;
                        break;
                    case "5":
                        Do += array.MidlleValue;
                        break;
                    case "6":
                        Do();
                        Do = null;
                        break;
                    default:
                        Console.WriteLine("Вввели неверную команду: " + '\"' + buf + '\"' + '\n');
                        break;
                }
            }
        }
    }
}