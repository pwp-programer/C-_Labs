string path = "1.txt";
string[] arr = File.ReadAllLines(path);
double sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum += double.Parse(arr[i]);
}
Console.WriteLine($"Среднее арифметическое: {sum / arr.Length}");
