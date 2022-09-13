namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v = Double.Parse(Console.ReadLine());
            double v2 = Double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(v2, 2) * Math.PI - Math.Pow(v, 2) * Math.PI);
        }
    }
}
