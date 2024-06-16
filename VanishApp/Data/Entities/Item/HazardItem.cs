using System.ComponentModel.DataAnnotations;

namespace VanishApp.Data.Entities;

public class HazardItem:Item
{
    [Range(0,4)]
    public int FireHazard { get; set; }
    [Range(0,4)]
    public int HealthHazard { get; set; }
    [Range(0,4)]
    public int InstabilityHazard { get; set; }

    private int OverallHazardIndex => FireHazard + HealthHazard + InstabilityHazard;
    private decimal HazardFee => OverallHazardIndex * 10m;
    public override decimal CalculateItemFee()
    {
        return base.CalculateItemFee() + HazardFee;
    }
}