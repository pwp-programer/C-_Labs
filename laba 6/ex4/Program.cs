Console.WriteLine("Введите строку: ");
string inputData = Console.ReadLine();
string newString = "";

for (int i = 0; i < inputData.Length; i++)
{
    if (!(inputData[i] == ' '))
    {
        newString += inputData[i];
    }
}

Console.WriteLine($"Исходная строка без пробелов: {newString}");
Console.ReadKey();