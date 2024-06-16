using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace VanishApp.Data.Entities;

public class EnterpriseClient
{
    [Key]
    [ForeignKey(nameof(Entities.Client))]
    public string ClientId { get; set; }
    public Client Client { get; set; }
    public static decimal Discount { get; } = 0.04m;
    public string Nip { get; set; }
    public string Regon { get; set; }
    public string CompanyName { get; set; }

    public EnterpriseClient(string clientId, string nip, string regon, string companyName)
    {
        Nip = nip ?? throw new ArgumentNullException(nameof(nip));
        Regon = regon ?? throw new ArgumentNullException(nameof(regon));
        CompanyName = companyName ?? throw new ArgumentNullException(nameof(companyName));
        ClientId = clientId;
    }
}