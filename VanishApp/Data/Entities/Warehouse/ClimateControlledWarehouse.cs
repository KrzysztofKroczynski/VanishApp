using System.ComponentModel.DataAnnotations;

namespace VanishApp.Data.Entities;

public class ClimateControlledWarehouse : Warehouse
{
    [Range(0.0,Double.MaxValue)]
    public decimal DailyFee { get; set; }
    [Range(0.0,Double.MaxValue)]
    public decimal ClimateFee { get; set; }
    public override decimal GetWarehouseFee(TimeSpan timeSpan)
    {
        return DailyFee * timeSpan.Days + ClimateFee;
    }
}