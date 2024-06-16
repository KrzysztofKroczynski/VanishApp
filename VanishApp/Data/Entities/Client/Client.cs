using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VanishApp.Data.Entities;

public class Client
{ 
    public static string AccountNumber { get; } = "NL16RABO7600386364";
    
    
    
    [Key]
    [ForeignKey(nameof(ApplicationUser))]
    public string Id{ get; set; }

    public ApplicationUser ApplicationUser { get; set; }
    

    public string Name
    {
        get
        {
            var companyName = EnterpriseClient?.CompanyName??"";
            var personName = PrivateClient?.FirstName??"" + PrivateClient?.LastName??"";
            return $"{companyName} {personName}";
        }
    }

    public string Phone { get; set; }
    public decimal Balance { get; set; } = 0;
    public EnterpriseClient? EnterpriseClient { get; set; }
    public PrivateClient? PrivateClient { get; set; }
    
    private List<Item> Items { get; set; } = new() ;

    public Dictionary<int, Item> ItemsByNumber()
    {
        var ditc = new Dictionary<int, Item>();
        foreach (var item in Items)
        {
            ditc.Add(item.Id,item);
        }

        return ditc;
    }


    public (string,string) getBankDetailsForTransfer()
    {
        return (AccountNumber,$"{Id}, {Name}");
    }
}