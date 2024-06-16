using System.ComponentModel.DataAnnotations;

namespace VanishApp.Data.Entities;

public class InsurancePolicy
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal MaxPayout { get; set; }
    public decimal Fee { get; set; }
    public bool IncludesHazardItems { get; set; }

    public List<ItemStorage> ItemStorages { get; set; }
}