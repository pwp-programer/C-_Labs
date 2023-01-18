using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

[Serializable]
public class Disk
{
    public int Cost { get; set; }

    public Disk()
    {

    }
    public Disk(int cost)
    {
        Cost = cost;
    }
    public void Show()
    {
        Console.WriteLine(Cost);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Disk[] pc = new Disk[5];
        for(int i = 0; i < pc.Length; i++)
        {
            Console.WriteLine("\tВведите цену диска:");
            pc[i]= new Disk(int.Parse(Console.ReadLine()));
        }
        BinaryFormatter bf = new BinaryFormatter();
        using(FileStream f = new FileStream("C:\\Users\\Bogda\\OneDrive\\Рабочий стол\\1.dat", FileMode.Create))
        {
            bf.Serialize(f, pc);
        }
        
        XmlSerializer x = new XmlSerializer(typeof(Disk[]));
        using (FileStream f = new FileStream("C:\\Users\\Bogda\\OneDrive\\Рабочий стол\\1.xml", FileMode.Create))
        {
            x.Serialize(f, pc);
        }

        Disk[] pc2;

        using(FileStream f = new FileStream("C:\\Users\\Bogda\\OneDrive\\Рабочий стол\\1.dat", FileMode.Open))
        {
            pc2 = bf.Deserialize(f) as Disk[];
        }

        Console.WriteLine("\tВывод информации:");
        foreach (Disk p in pc2)
            p.Show();

        Disk[] pc3;  
        using(FileStream f = new FileStream("C:\\Users\\Bogda\\OneDrive\\Рабочий стол\\1.xml", FileMode.Open))
        {
            pc3 = x.Deserialize(f) as Disk[];
        }

        Console.WriteLine("\tВведите цену для поиска: ");
        int cost = int.Parse(Console.ReadLine());
        Console.WriteLine("\tДиски с ценой меньше заданной:");
        foreach (Disk pcm in pc3)
        {
            if (pcm.Cost <= cost)
                pcm.Show();
        }
    }
}