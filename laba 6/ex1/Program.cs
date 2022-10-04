Console.WriteLine("Введите строку: ");
string inputData = Console.ReadLine();

int len = inputData.Length;

for (int i = 0; i < len; i++)
{
    Console.Write($"{(uint)inputData[i]} ");
}
Console.ReadLine();