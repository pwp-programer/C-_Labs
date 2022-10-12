using System;
using System.Text;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Привет мир");
            Console.WriteLine("Длина строки: {0}", sb.Length);  //длина – сколько в строке символов

            Console.WriteLine("Емкость строки: {0}", sb.Capacity); //ёмкость – под сколько символов выделена память. Ёмкость>=длина.
            
            sb.Append("Hello hello");
            Console.WriteLine("Длина строки: {0}", sb.Length);  //длина – сколько в строке символов
            Console.WriteLine("Емкость строки: {0}", sb.Capacity); //ёмкость – под сколько символов выделена память. Ёмкость>=длина.

            Console.ReadLine();
        }
    }
}