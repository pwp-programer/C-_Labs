namespace ex2
{
    internal class Program
    {
        class Cinema
        {
            private string city;
            private double num;
            private string name;

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            public double Num
            {
                get { return num; }
                set { num = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }


            public Cinema()
            {
                city = "noname";
                num = 0.0;
                name = "noname";
            }

            public Cinema(string city, int num, string name)
            {
                this.city = city;
                this.num = num;
                this.name = name;
            }

            public void Show()
            {
                Console.WriteLine($"Город: {city}\nНомер: {num}\nИмя: {name}");
            }
        }



        static void Main(string[] args)
        {
            Cinema[] c = new Cinema[2];
            for (int i = 0; i < 2; i++)
            {
                c[i] = new Cinema(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());
            }

            global::System.Console.WriteLine("Введите имя фильма для поиска: ");
            string name = Console.ReadLine();
            global::System.Console.WriteLine("Результаты поиска: ");
            for (int i = 0; i < 2; i++)
            {
                if (c[i].Name == name)
                {
                    global::System.Console.WriteLine(c[i].City + c[i].Name + c[i].Num);
                }
            }
            Console.ReadLine();
        }
    }
}