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

Console.WriteLine("\nПреобразование массива:");

for (int i = 0; i < num; i++)
{
    string buffer = Convert.ToString(array[i]);
    int len = buffer.Length;
    if (buffer[len-1] == '4')
    {
        array[i] *= 2;
    }
    Console.Write($"{array[i]} ");
}

Console.ReadKey();