namespace ex1
{

        class Document
        {
            protected string name;
            protected int size;
            protected string type;
            
            
            public void ShowBase()
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

            public void ShowNew()
            {
                Console.WriteLine($"Название документа: {name}\nРазмер документа: {size}\nТип документа: {type}\nАвтор: {author}");
            }
	    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());
            d.ShowBase();

            Cheque c = new Cheque(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            c.ShowNew();

            Console.ReadLine();

        }
    }
}