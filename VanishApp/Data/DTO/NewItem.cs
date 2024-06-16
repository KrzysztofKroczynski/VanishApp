using System.ComponentModel.DataAnnotations;

namespace VanishApp.Data.DTO;

public class NewItem
{
    private int _instabilityHazard;
    private int _healthHazard;
    private int _fireHazard;
    public decimal Weight { get; set; }
    public int Size { get; set; }
    public string Name { get; set; }
    public bool IsHazard { get; set; }

    public int FireHazard
    {
        get => _fireHazard;
        set
        {
            value = FixHazard(value);
            
            _fireHazard = value;
        }
    }

    public int HealthHazard
    {
        get => _healthHazard;
        set
        {
            value = FixHazard(value);
            
            _healthHazard = value;
        }
    }

    public int InstabilityHazard
    {
        get => _instabilityHazard;
        set
        {
            value = FixHazard(value);
            
            _instabilityHazard = value;
        }
    }

    private int FixHazard(int value)
    {
        if (value>4)
        {
            return 4;
        }

        if (value<0)
        {
            return 0;
        }

        return value;
    }
}