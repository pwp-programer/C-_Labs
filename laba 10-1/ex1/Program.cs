namespace ex1
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
            Cinema c = new Cinema();

            c.Show();

            c.City = "Витебск";
            c.Num = 123;
            c.Name = "Новое имя";

            c.Show();
            Console.ReadLine();
        }
    }
}