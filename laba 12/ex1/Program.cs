namespace ex1
{
    internal class Program
    {
        static double rastoyanie(double x, double y)
        {
            return Math.Abs(x - y);
        }


        static double rastoyanie(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(rastoyanie(1, 4));
            Console.WriteLine(rastoyanie(2, 5, 7, 6));
         
            Console.ReadKey();
        }
    }
}