string inputData = Console.ReadLine();

while (inputData.Contains("  "))
{
    inputData = inputData.Replace("  ", " ");
}

Console.WriteLine(inputData);
Console.ReadLine();