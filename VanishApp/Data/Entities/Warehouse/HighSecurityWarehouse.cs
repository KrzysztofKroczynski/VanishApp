using System.ComponentModel.DataAnnotations;

namespace VanishApp.Data.Entities;

public class HighSecurityWarehouse: Warehouse
{
    private int _securityLevel;

    public int SecurityLevel
    {
        get => _securityLevel;
        set
        {
            if (value>5 || value<0)
            {
                throw new ValidationException(message:"Security level must be between 0 and 5");
            }
            _securityLevel = value;
        }
    }

    public decimal DailyFee => (SecurityLevel*50 + 50);

    public override decimal GetWarehouseFee(TimeSpan timeSpan)
    {
        return DailyFee * timeSpan.Days;
    }
}