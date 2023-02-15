using System.Collections;
using System.Collections.Generic;

class Prgoram
{
    static void Main()
    {
        ArrayList l = new ArrayList();
        l.Add("Задора");
        l.Add("Богдан");
        l.Add("Алексеевич");
        l.Add("ПЗ-56");

        foreach (var i in l)
        {
            Console.WriteLine(i);
        }

        int buf = l.IndexOf("Богдан");
        l.Remove("Богдан");
        l.Insert(buf, "ВОЛВО");
        
        l.Remove("Алексеевич");
        Console.WriteLine("\nУдаляем отчество + меняем имя\n");
        foreach (var i in l)
        {
            Console.WriteLine(i);
        }
    }
}