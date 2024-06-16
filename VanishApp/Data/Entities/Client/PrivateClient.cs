using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VanishApp.Data.Entities;

public class PrivateClient
{
    [Key]
    [ForeignKey(nameof(Entities.Client))]
    public string ClientId { get; set; }
    public Client Client { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Pesel { get; set; }

    public PrivateClient(string clientId, string firstName, string lastName, string pesel)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        Pesel = pesel ?? throw new ArgumentNullException(nameof(pesel));
        ClientId = clientId;
    }
}