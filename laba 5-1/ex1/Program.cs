Console.WriteLine("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

Random r = new Random();

for (int i = 0; i < n; i++)
{
    arr[i] = r.Next(-10, 10);
}

for (int i = 0; i < n; i++)
{
    Console.Write($"{arr[i]} ");
}


Console.WriteLine("\nКопирование массива");
int[] newArray = new int[n];
arr.CopyTo( newArray, 0);


Console.WriteLine("Вывод копии");
for (int i = 0; i < n; i++)
{
    Console.Write($"{newArray[i]} ");
}


Console.WriteLine("\nСортировка массива");
Array.Sort(arr);

for (int i = 0; i < n; i++)
{
    Console.Write($"{arr[i]} ");
}


Console.WriteLine("\nСмена порядка элемента");
Array.Reverse(arr);
for (int i = 0; i < n; i++)
{
    Console.Write($"{arr[i]} ");
}


Console.ReadKey();