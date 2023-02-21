using System.Xml;
using Laba_23;


class Program
{
    static void ShowInfo(string path)
    {
        List<Laba_23.Cinema> l = new List<Laba_23.Cinema>();
        
        XmlDocument d = new XmlDocument();
        d.Load(path);
        XmlElement root = d.DocumentElement;
        foreach (XmlElement el in root)
        {
            List<string> s = new List<string>();
            foreach (XmlAttribute x in el.Attributes)
            {
                s.Add(x.Value);
                Console.WriteLine(x.Name);
            }
            l.Add(new Laba_23.Cinema(s[0], s[1], s[2]));
        }

        // foreach (var c in l)
        // {
        //     c.Show();
        // }
    }
    
    static void Main()
    {
        ShowInfo("1.xml");
    }
}


