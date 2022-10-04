Console.WriteLine("Введите m и n");
int m = int.Parse(Console.ReadLine()), n = int.Parse(Console.ReadLine());

Random Random = new Random();

int[,] array = new int[m, n];
int maxValue = 0, maxValuePositionM = 0, maxValuePositionN = 0;
int minValue = 0, minValuePositionM = 0, minValuePositionN = 0;

for (int i = 0; i < m; i++)
{
    for (int q = 0; q < n; q++)
    {
        array[i, q] = Random.Next(-10, 10);
        Console.Write($"{array[i, q]} ");
        if (array[i,q] > maxValue)
        {
            maxValue = array[i,q];
            maxValuePositionM = i;
            maxValuePositionN = q;
        }
        if (array[i, q] < minValue)
        {
            minValue = array[i, q];
            minValuePositionM = i;
            minValuePositionN = q;
        }
    }
    Console.WriteLine(" ");
}

Console.WriteLine($"Минимальное значение {minValue} m = {minValuePositionM} n = {minValuePositionN}");
Console.WriteLine($"Максимальное значение {maxValue} m = {maxValuePositionM} n = {maxValuePositionN}");
Console.ReadKey();