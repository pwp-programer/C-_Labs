Console.WriteLine("Введите строку: ");
string inputData = Console.ReadLine();
string newString = "";


while (inputData.Contains("  "))
{ 
    inputData = inputData.Replace("  "," ");
}
Console.WriteLine($"Исходная строка без пробелов: {inputData}");
Console.ReadKey();