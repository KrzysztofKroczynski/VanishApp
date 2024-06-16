namespace VanishApp.Data.DTO;

public class VanishDurationDTO
{
    public DateTime VanishDateTimeStart { get; set; }
    public DateTime VanishDateTimeEnd { get; set; }
    
    public string PickupAddress { get; set; } = string.Empty;
    public string DropoffAddress { get; set; } = string.Empty;
    
}