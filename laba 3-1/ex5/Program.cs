string value = Console.ReadLine();


switch(value)
{
    case "!":
        Console.WriteLine("Восклицательный знак");
        break;
    case "?":
        Console.WriteLine("Вопросительный знак");
        break;
    case ",":
        Console.WriteLine("Запятая");
        break;
    case ".":
        Console.WriteLine("Точка");
        break;
    case "-":
        Console.WriteLine("Тире");
        break;
}

Console.ReadKey();