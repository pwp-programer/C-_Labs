class Student:IComparable<Student>
{
    private string Name { get; set; }
    private string Surname { get; set; }
    private int Age { get; set; }

    public Student(string n, string s, int a)
    {
        Name = n;
        Surname = s;
        Age = a;
    }

    public int CompareTo(Student a)
    {
        return Age.CompareTo(a.Age);
    }

    public void Show()
    {
        Console.WriteLine($"{Name} {Surname} {Age}");
    }
}

class Program
{
    static void Main()
    {
        List<Student> l = new List<Student>();
        l.Add(new Student("Богдан", "Задора", 100));
        l.Add(new Student("Влад", "Исаков", 120));
        
        l.Sort();
        foreach (Student i in l)
        {
            i.Show();
        }
    }
}