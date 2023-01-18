public enum Type
{
    Продаётся, Сдаётся
}

public interface IHouse
{
    public Type Type { get; }
    public double GetPrice();
}

public class HouseSale : IHouse
{
    public double PriceZaMetr { get; init; }
    public double Square { get; init; }
    public Type Type { get; set; } = Type.Продаётся;

    public double GetPrice()
    {
        return PriceZaMetr * Square;
    }
}

public class HouseSdacha : IHouse
{
    public double PriceZaMonth { get; init; }
    public int PeriodArendbl { get; init; }
    public Type Type { get; set; } = Type.Сдаётся;

    public double GetPrice()
    {
        return PeriodArendbl * PriceZaMonth;
    }
        
}


internal static class Program
{
    public static void Main()
    {
        var houses = new IHouse[]
        {
            new HouseSdacha()
            {
                PriceZaMonth = 100,
                PeriodArendbl = 5
            },
            new HouseSale()
            {
                PriceZaMetr = 200,
                Square = 5
            },
            new HouseSale()
            {
                PriceZaMetr = 300,
                Square = 3
            }
        };
        PriceSearch(houses);
    }

    private static void GetInfo<T>(T house) where T : IHouse
    {
        Console.WriteLine($"Тип: {house.Type}\nЦена: {house.GetPrice()}");
    }

    private static void PriceSearch<T>(IEnumerable<T> houses) where T : IHouse
    {
        Console.Write("Введите минимальную цену: ");
        var MaxPrice = int.Parse(Console.ReadLine()!); 
        foreach (var gHouse in houses)
        {
            if (MaxPrice < gHouse.GetPrice())
                GetInfo(gHouse);
        }
    }
}