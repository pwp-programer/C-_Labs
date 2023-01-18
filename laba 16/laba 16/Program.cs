class CreditCard
{
    public delegate void BalanceBlocked();
    public event BalanceBlocked? NotifyBloc;
    
    public delegate void BalanceUnBlocked();
    public event BalanceBlocked? NotifyUnBloc;
    
    
    private string Name { get; set; }
    private double Balance { get; set; }
    private int Limit { get; set; }

    public CreditCard(string name, double balance, int limit)
    {
        Name = name;
        Balance = balance;
        Limit = limit;
    }

    public void Buy(string Item, double Cost)
    {
        Console.Clear();
        if (Balance >= Limit)
        {
            Balance -= Cost;
            Console.WriteLine($"Вы купили товар {Item} за {Cost}.\nВаш баланс: {Balance}");
        }
        if (Cost >= Balance && Balance <= Limit)
        {
            NotifyBloc();
        }
    }

    public void AddMoney()
    {
        Console.Clear();
        if (Balance <= Limit)
        {
            Console.WriteLine($"Карта заблокирована необходимо погасить долг в размере: {Balance}");
        }
        Console.WriteLine("Введите сумму для пополнения: ");
        double Money = double.Parse(Console.ReadLine());
        Balance += Money;
        Console.WriteLine($"Деньги успешно зачислены на ваш баланс. Текущая сумма счёта: {Balance}");
        if (Balance >= Limit)
        {
            NotifyUnBloc();
        }
    }

    public void Show()
    {
        Console.Clear();
        Console.WriteLine($"Баланс карты: {Balance}");
    }
}


class Program
{
    static void block()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Карта заблокирована...");
        
    }

    static void unbloc()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Карта разблокирована...");
    }
    static void Menu(CreditCard card)
    {
        Console.Clear();
        Console.WriteLine($"1 - Просмотр состояний карты\n" +
                          $"2 - Совершить покупку\n" +
                          $"3 - Пополнить счёт\n" +
                          $"0 - Выход");
        int ChoiceMenu = int.Parse(Console.ReadLine());
        if (ChoiceMenu == 1)
        {
            card.Show();
            Console.WriteLine("Нажмите \"enter\" что бы продолжить...");
            string b = Console.ReadLine();
            if (b == " " || b == "")
            {
                Menu(card);
            }
            
        }
        else if (ChoiceMenu == 2)
        {
            Console.Clear();
            Console.WriteLine("Введите товар: ");
            string item = Console.ReadLine();
            Console.WriteLine("Введите стоймость товара: ");
            double cost = double.Parse(Console.ReadLine());
            card.Buy(item, cost);
            Console.WriteLine("Нажмите \"enter\" что бы продолжить...");
            string b = Console.ReadLine();
            if (b == " " || b == "")
            {
                Menu(card);
            }
        }
        else if (ChoiceMenu == 3)
        {
            card.AddMoney();
            Console.WriteLine("Нажмите \"enter\" что бы продолжить...");
            string b = Console.ReadLine();
            if (b == " " || b == "")
            {
                Menu(card);
            }
        }
        else if (ChoiceMenu == 0)
        {
            Console.WriteLine("Выход...");
        }
        else
        {
            Menu(card);
        }
    }
    
    static void Main()
    {
        CreditCard card = new CreditCard("Павел", 500, -100);
        card.NotifyBloc += block;
        card.NotifyUnBloc += unbloc;
        Menu(card);
    }
}