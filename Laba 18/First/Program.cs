class Files
{
    public string path = "1.txt";

    public Files()
    {
        
    }

    public void Write()
    {
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            double[] array = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Введите число номер {i+1}");
                array[i] = double.Parse(Console.ReadLine());
                writer.WriteLineAsync(Convert.ToString(array[i]));
            }
        }       
    }

    public void Read()
    {
        string[] arr = File.ReadAllLines(path);
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
            sum += double.Parse(arr[i]);
        }

        Console.WriteLine($"Среднее арифметическое: {sum / arr.Length}");
        File.AppendAllText(path, Convert.ToString(sum / arr.Length) + "\n");
    }
}

class Program
{
    static void Main()
    {
        Files f = new Files();
        f.Write();
        f.Read();
    }
}