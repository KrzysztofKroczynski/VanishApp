namespace VanishApp.Data.Entities;

public class UnplannedStorage: ItemStorage
{
    public static decimal UnplannedStorageFee { get; set; } = 200;
    public override decimal CalculateTotalFee()
    {
        var baseFee =  base.CalculateTotalFee();
        bool isClientEnterprise = Item.Client.EnterpriseClient is not null;
        decimal discount =  (isClientEnterprise ? EnterpriseClient.Discount : 0m);

        return (1 - discount) * baseFee;
    }
}