namespace ex1
{
    internal class Program
    {
        class Document
        {
            protected string name;
            protected int size;
            protected string type;


            public virtual void Show()
            {
                Console.WriteLine($"Название документа: {name}\nРазмер документа: {size}\nТип документа: {type}");
            }

            public Document(string name, int size, string type)
            {
                this.name = name;
                this.size = size;
                this.type = type;
            }
        }

        class Cheque : Document
        {
            protected string author;

            public Cheque(string name, int size, string type, string author) : base(name, size, type)
            {
                this.author = author;
            }

            public override void Show()
            {
                Console.WriteLine($"Название документа: {name}\nРазмер документа: {size}\nТип документа: {type}\nАвтор: {author}");
            }
        }


        class NameNewMegaSuperDuperKlassniyKlass : Cheque
        {
            public NameNewMegaSuperDuperKlassniyKlass(string name, int size, string type, string author) : base(name, size, type, author)
            {
            }


        }


        static void Main(string[] args)
        {
            Document d = new Document(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());
            d.Show();

            Cheque c = new Cheque(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            c.Show();

            NameNewMegaSuperDuperKlassniyKlass dnew = new NameNewMegaSuperDuperKlassniyKlass(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            dnew.Show();

            Console.ReadLine();

        }
    }
}