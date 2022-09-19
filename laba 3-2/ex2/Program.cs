int num = 0, sum_num = 0, min_num = 0, half_lips = 0, negative_values = 0, amount = 0;

Console.WriteLine("Введите число: ");
num = int.Parse(Console.ReadLine());


while(num != 0)
{
    sum_num += num;
    amount += 1;

    if(num < min_num)
    {
        min_num = num;
    }

    if(num > 0)
    {
        half_lips += 1;
    }
    else
    {
        negative_values += 1;
    }

    Console.WriteLine("Введите число: ");
    num = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Среднее арифметическое: {sum_num / amount}\n" +
    $"Минимальное значние: {min_num}\n" +
    $"Количество положительных чисел: {half_lips}\n" +
    $"Количество отрицательных чисел: {negative_values}");
Console.ReadKey();