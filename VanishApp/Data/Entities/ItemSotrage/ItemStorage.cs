using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VanishApp.Data.Entities;

public abstract class ItemStorage
{
    [Key]
    public int Id { get; set; }
    
    public static decimal PickupFee { get; set; } = 100;
    public static decimal DropOffFee { get; set; } = 120;
    
    public string? PickupAddress { get; set; }
    public string? DropOffAddress { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public ItemStorageState StorageState { get; set; } = ItemStorageState.Planned;


    public virtual Item Item { get; set; }
    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }

    public virtual Warehouse Warehouse { get; set; }
    [ForeignKey(nameof(Warehouse))]
    public int WarehouseId { get; set; }

    public virtual InsurancePolicy? InsurancePolicy { get; set; }
    [ForeignKey(nameof(InsurancePolicy))]
    public int? InsurancePolicyId { get; set; }


    public virtual decimal CalculateTotalFee()
    {
        decimal total = 0;
        var vanishDuration = (EndDate - StartDate);

        var itemFee = Item.CalculateItemFee();

        var warehouseFee = Warehouse.GetWarehouseFee(vanishDuration);

        decimal transportFee = 0;
        if (PickupAddress is not null)
        {
            transportFee += PickupFee;
        }

        if (DropOffAddress is not null)
        {
            transportFee += DropOffFee;
        }
        

        return itemFee + warehouseFee + (InsurancePolicy?.Fee ?? 0) + transportFee;
    }
}

public enum ItemStorageState
{
    Planned, 
    Vanished, 
    Returned, 
    Cancelled,
}