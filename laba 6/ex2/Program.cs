Console.WriteLine("Введите строку: ");
string inputData = Console.ReadLine();
int sumLatinNumber = 0;

for (int i = 0; i < inputData.Length; i++)
{
    if (inputData[i] >= 'a' && inputData[i] <= 'z')
    {
        sumLatinNumber++;
    }
}

Console.WriteLine($"Количество латинских символов: {sumLatinNumber}");
Console.ReadKey();