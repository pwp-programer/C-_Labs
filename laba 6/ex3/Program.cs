Console.WriteLine("Введите строку: ");
string inputData = Console.ReadLine();
string newString = "";

for (int i = 0; i < inputData.Length; i++)
{
    if(Char.IsUpper(inputData[i]))
    {
        newString += Char.ToLower(inputData[i]);
    }
    else
    {
        newString += Char.ToUpper(inputData[i]);
    }
}

Console.WriteLine($"Итоговая строка: {newString}");
Console.ReadKey();