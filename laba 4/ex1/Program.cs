static double korni (double a, double b, double c)
{
    double D = Math.Pow(b,2.0) - 4.0 * a * c;
    
    if(D == 0)
    {
        return 1.0;
    }
    else if (D > 0)
    {
        return 2.0;
    }
    else
    {
        return 0.0;
    }
}


double a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), c = double.Parse(Console.ReadLine());
Console.WriteLine(korni(a, b, c));
Console.ReadKey();