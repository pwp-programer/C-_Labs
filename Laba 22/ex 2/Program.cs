using System.Collections;

class Program
{
    static void Main()
    {
        List<int> l1 = new List<int>();
        List<string> l2 = new List<string>();
        
        Console.WriteLine("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = r.Next(1, 10);
        }
        
        l1.AddRange(arr);

        foreach (var i in l1)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine($"\nСамое большое число в 1-ой коллекции: {l1.Max()}");

        
        Console.WriteLine("Введите размер массива строк: ");
        int n1 = int.Parse(Console.ReadLine());
        string[] arr1 = new string[n1];
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = "";
            int sz = r.Next(1, 10);
            for (int j = 0; j < sz; j++)
            {
                
                    arr1[i]+= (char)r.Next(1040, 1104);
                
            }
        }
        l2.AddRange(arr1);

        string buf = "";
        for (int i = 0; i < n1; i++)
        {
            Console.Write(l2[i] + "   ");
            if (l2[i].Length > buf.Length)
            {
                buf = l2[i];
            }
        }

        Console.WriteLine($"\nСамое большое число во 2-ой коллекции: {buf}");
    }
}
