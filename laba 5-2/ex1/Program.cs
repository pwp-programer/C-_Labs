Console.WriteLine("Введите m и n");
int m = int.Parse(Console.ReadLine()), n = int.Parse(Console.ReadLine());

Random Random = new Random();

int[,] array = new int[m,n];
int negativeNumbers = 0;

for (int i = 0; i < m; i++)
{
    for (int q = 0; q < n; q++)
    {
        array[i,q] = Random.Next(-10, 10);
        Console.Write($"{array[i,q]} ");
        if (array[i,q] < 0)
        {
            negativeNumbers += 1;
        }
    }
    Console.WriteLine(" ");
}

Console.WriteLine($"\nКоличество негативных чисел: {negativeNumbers}");
Console.ReadKey();