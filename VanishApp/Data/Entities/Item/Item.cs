using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VanishApp.Data.Entities;

public class Item
{
    public static decimal FeePerPallet { get; } = 50;
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

    public List<ItemStorage> Storages { get; set; }
    public Client Client { get; set; }
    [ForeignKey(nameof(Client))]
    public string ClientId { get; set; }
    
    
    [Range(0.0,double.MaxValue)]
    public decimal Weight { get; set; }
    [Range(0.0,double.MaxValue)]
    public int Size { get; set; }

    public virtual decimal CalculateItemFee()
    {
        return FeePerPallet * Size;
    }
}