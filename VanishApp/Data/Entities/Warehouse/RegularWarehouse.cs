namespace VanishApp.Data.Entities;

public class RegularWarehouse: Warehouse
{
    public static decimal DailyFee { get; set; } = 20;
    public override decimal GetWarehouseFee(TimeSpan timeSpan)
    {
        return timeSpan.Days * DailyFee;
    }
}