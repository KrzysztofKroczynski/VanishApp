﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VanishApp.Data;

#nullable disable

namespace VanishApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240616143415_final8")]
    partial class final8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("VanishApp.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("VanishApp.Data.Entities.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.EnterpriseClient", b =>
                {
                    b.Property<string>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Regon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClientId");

                    b.ToTable("EnterpriseClient");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.InsurancePolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Fee")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IncludesHazardItems")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("MaxPayout")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("InsurancePolicies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Fee = 100m,
                            IncludesHazardItems = false,
                            MaxPayout = 10000m,
                            Name = "Basic Coverage"
                        },
                        new
                        {
                            Id = 2,
                            Fee = 250m,
                            IncludesHazardItems = false,
                            MaxPayout = 50000m,
                            Name = "Standard Coverage"
                        },
                        new
                        {
                            Id = 3,
                            Fee = 500m,
                            IncludesHazardItems = false,
                            MaxPayout = 100000m,
                            Name = "Premium Coverage"
                        });
                });

            modelBuilder.Entity("VanishApp.Data.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Items");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Regular");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("VanishApp.Data.Entities.ItemStorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("DropOffAddress")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("InsurancePolicyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PickupAddress")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("StorageState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InsurancePolicyId");

                    b.HasIndex("ItemId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("ItemStorages");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ItemStorage");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("VanishApp.Data.Entities.PrivateClient", b =>
                {
                    b.Property<string>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClientId");

                    b.ToTable("PrivateClient");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalCapacity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Warehouse");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("VanishApp.Data.Entities.HazardItem", b =>
                {
                    b.HasBaseType("VanishApp.Data.Entities.Item");

                    b.Property<int>("FireHazard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HealthHazard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InstabilityHazard")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Hazard");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.PlannedStorage", b =>
                {
                    b.HasBaseType("VanishApp.Data.Entities.ItemStorage");

                    b.Property<DateTime>("PlannedDate")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Planned");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.UnplannedStorage", b =>
                {
                    b.HasBaseType("VanishApp.Data.Entities.ItemStorage");

                    b.HasDiscriminator().HasValue("Unplanned");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.ClimateControlledWarehouse", b =>
                {
                    b.HasBaseType("VanishApp.Data.Entities.Warehouse");

                    b.Property<decimal>("ClimateFee")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DailyFee")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Climate");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Address = "789 Climate Rd, Climate Town",
                            TotalCapacity = 75,
                            ClimateFee = 10m,
                            DailyFee = 30m
                        });
                });

            modelBuilder.Entity("VanishApp.Data.Entities.HighSecurityWarehouse", b =>
                {
                    b.HasBaseType("VanishApp.Data.Entities.Warehouse");

                    b.Property<int>("SecurityLevel")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("HighSecurity");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Address = "456 Secure Blvd, Secure City",
                            TotalCapacity = 50,
                            SecurityLevel = 4
                        },
                        new
                        {
                            Id = 5,
                            Address = "202 Empty Ave, Null City",
                            TotalCapacity = 0,
                            SecurityLevel = 2
                        });
                });

            modelBuilder.Entity("VanishApp.Data.Entities.RegularWarehouse", b =>
                {
                    b.HasBaseType("VanishApp.Data.Entities.Warehouse");

                    b.HasDiscriminator().HasValue("Regular");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St, Regular Town",
                            TotalCapacity = 100
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Capacity Dr, Tiny Town",
                            TotalCapacity = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("VanishApp.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("VanishApp.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VanishApp.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("VanishApp.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VanishApp.Data.Entities.Client", b =>
                {
                    b.HasOne("VanishApp.Data.ApplicationUser", "ApplicationUser")
                        .WithOne("Client")
                        .HasForeignKey("VanishApp.Data.Entities.Client", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.EnterpriseClient", b =>
                {
                    b.HasOne("VanishApp.Data.Entities.Client", "Client")
                        .WithOne("EnterpriseClient")
                        .HasForeignKey("VanishApp.Data.Entities.EnterpriseClient", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.Item", b =>
                {
                    b.HasOne("VanishApp.Data.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.ItemStorage", b =>
                {
                    b.HasOne("VanishApp.Data.Entities.InsurancePolicy", "InsurancePolicy")
                        .WithMany("ItemStorages")
                        .HasForeignKey("InsurancePolicyId");

                    b.HasOne("VanishApp.Data.Entities.Item", "Item")
                        .WithMany("Storages")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VanishApp.Data.Entities.Warehouse", "Warehouse")
                        .WithMany("ItemStorage")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsurancePolicy");

                    b.Navigation("Item");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.PrivateClient", b =>
                {
                    b.HasOne("VanishApp.Data.Entities.Client", "Client")
                        .WithOne("PrivateClient")
                        .HasForeignKey("VanishApp.Data.Entities.PrivateClient", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("VanishApp.Data.ApplicationUser", b =>
                {
                    b.Navigation("Client");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.Client", b =>
                {
                    b.Navigation("EnterpriseClient");

                    b.Navigation("PrivateClient");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.InsurancePolicy", b =>
                {
                    b.Navigation("ItemStorages");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.Item", b =>
                {
                    b.Navigation("Storages");
                });

            modelBuilder.Entity("VanishApp.Data.Entities.Warehouse", b =>
                {
                    b.Navigation("ItemStorage");
                });
#pragma warning restore 612, 618
        }
    }
}
