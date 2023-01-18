string path = "1.txt";
Console.WriteLine("Введите строку для её удаления: ");
int num = int.Parse(Console.ReadLine());

string[] arr = File.ReadAllLines(path);
using (StreamWriter writer = new StreamWriter(path, false))
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num-1 != i)
        {
            writer.WriteLine(arr[i]);
        }
    }
}