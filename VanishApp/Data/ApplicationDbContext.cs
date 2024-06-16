using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VanishApp.Data.Entities;

namespace VanishApp.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemStorage> ItemStorages { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<InsurancePolicy> InsurancePolicies { get; set; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<ItemStorage>().HasDiscriminator<string>("Discriminator")
            .HasValue<UnplannedStorage>("Unplanned")
            .HasValue<PlannedStorage>("Planned");

        builder.Entity<Warehouse>().HasDiscriminator<string>("Discriminator")
            .HasValue<RegularWarehouse>("Regular")
            .HasValue<ClimateControlledWarehouse>("Climate")
            .HasValue<HighSecurityWarehouse>("HighSecurity");

        builder.Entity<Item>().HasDiscriminator<string>("Discriminator")
            .HasValue<Item>("Regular").HasValue<HazardItem>("Hazard");

        builder.Entity<RegularWarehouse>().HasData(new List<Warehouse>
        {
            new RegularWarehouse
            {
                Id = 1,
                Address = "123 Main St, Regular Town",
                TotalCapacity = 100
            },
            new RegularWarehouse
            {
                Id = 4,
                Address = "101 Capacity Dr, Tiny Town",
                TotalCapacity = 1
            },
        });

        builder.Entity<ClimateControlledWarehouse>().HasData(new List<ClimateControlledWarehouse>()
        {
            new ClimateControlledWarehouse
            {
                Id = 3,
                Address = "789 Climate Rd, Climate Town",
                TotalCapacity = 75,
                DailyFee = 30,
                ClimateFee = 10
            },
        });
        builder.Entity<HighSecurityWarehouse>().HasData(new List<HighSecurityWarehouse>()
        {
            new HighSecurityWarehouse
            {
                Id = 2,
                Address = "456 Secure Blvd, Secure City",
                TotalCapacity = 50,
                SecurityLevel = 4
            },
            new HighSecurityWarehouse
            {
                Id = 5,
                Address = "202 Empty Ave, Null City",
                TotalCapacity = 0,
                SecurityLevel = 2
            }
        });
        builder.Entity<InsurancePolicy>().HasData(
         new List<InsurancePolicy>
        {
            new InsurancePolicy
            {
                Id = 1,
                Name = "Basic Coverage",
                MaxPayout = 10000m,
                Fee = 100m,
                IncludesHazardItems = false
            },
            new InsurancePolicy
            {
                Id = 2,
                Name = "Standard Coverage",
                MaxPayout = 50000m,
                Fee = 250m,
                IncludesHazardItems = false
            },
            new InsurancePolicy
            {
                Id = 3,
                Name = "Premium Coverage",
                MaxPayout = 100000m,
                Fee = 500m,
                IncludesHazardItems = false
            }
        });
    }
}