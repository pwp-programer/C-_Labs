Console.WriteLine("Введите размер массива:");
int num = int.Parse(Console.ReadLine());

int sum = 0;
int[] array = new int[num];
Random Random = new Random();

for (int i = 0; i < num; i++)
{
    array[i] = Random.Next(-10, 10);
    Console.Write($"{array[i]} ");
}

for (int i = 0; i < num; i++)
{
    if (array[i] % 3 == 0)
    {
        sum += 1;
    }
}

Console.WriteLine($"\nКоличество чисел в массиве кратных трёх: {sum}");
Console.ReadKey();