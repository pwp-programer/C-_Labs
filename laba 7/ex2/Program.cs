
using System.Xml.Linq;
using System;


static string[] n1(string[] array)
{
    Array.Sort(array);
    return array;
}


static string[] n2(string[] array)
{
    return array.OrderBy(x => x.Length).ToArray();
}


static string[] n22(string[] array)
{
    string buf;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j].Length > array[j + 1].Length)
            {
                buf = array[j];
                array[j] = array[j + 1];
                array[j+1]= buf;
            }
        }
    }

    return array;
}


static void Print(string[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}

string[] inputData = Console.ReadLine().Split();

Console.WriteLine("Задание номер 1");
Print(n1(inputData)); // Задание 1
Console.WriteLine("Задание номер 2");
Print(n22(inputData)); // Задание 2


Console.ReadKey();