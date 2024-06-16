using System.ComponentModel.DataAnnotations;

namespace VanishApp.Data.Entities;

public class PlannedStorage: ItemStorage
{
    public static decimal PlanAheadDiscount { get; } = .1m;
    public DateTime PlannedDate { get; set; }

    public override decimal CalculateTotalFee()
    {
        var baseFee =  base.CalculateTotalFee();
        bool isClientEnterprise = Item.Client.EnterpriseClient is not null;
        bool planAheadDiscountApplicable = (PlannedDate - StartDate).Days >= 10; 
        
        decimal discount = (planAheadDiscountApplicable ? PlanAheadDiscount :0m) 
                           + (isClientEnterprise ? EnterpriseClient.Discount : 0m);

        return (1 - discount) * baseFee;
    }
}