using System.ComponentModel.DataAnnotations;

namespace VanishApp.Data.Entities;

public abstract class Warehouse
{
    [Key]
    public int Id { get; set; }
    public string Address { get; set; }
    public int TotalCapacity { get; set; }
    
    public List<ItemStorage> ItemStorage { get; set; }

    public abstract Decimal GetWarehouseFee(TimeSpan timeSpan);
}