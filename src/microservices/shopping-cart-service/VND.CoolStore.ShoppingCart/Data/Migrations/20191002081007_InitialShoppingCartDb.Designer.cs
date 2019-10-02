﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VND.CoolStore.ShoppingCart.Data;

namespace VND.CoolStore.ShoppingCart.Data.Migrations
{
    [DbContext(typeof(ShoppingCartDataContext))]
    [Migration("20191002081007_InitialShoppingCartDb")]
    partial class InitialShoppingCartDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VND.CoolStore.ShoppingCart.Domain.Cart.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("CartItemPromoSavings")
                        .HasColumnType("float");

                    b.Property<double>("CartItemTotal")
                        .HasColumnType("float");

                    b.Property<double>("CartTotal")
                        .HasColumnType("float");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCheckout")
                        .HasColumnType("bit");

                    b.Property<double>("ShippingPromoSavings")
                        .HasColumnType("float");

                    b.Property<double>("ShippingTotal")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts","cart");
                });

            modelBuilder.Entity("VND.CoolStore.ShoppingCart.Domain.Cart.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CurrentCartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("PromoSavings")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CurrentCartId");

                    b.ToTable("CartItems","cart");
                });

            modelBuilder.Entity("VND.CoolStore.ShoppingCart.Domain.Cart.ProductCatalogId", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CurrentCartItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CurrentCartItemId")
                        .IsUnique();

                    b.ToTable("ProductCatalogIds","cart");
                });

            modelBuilder.Entity("VND.CoolStore.ShoppingCart.Domain.ProductCatalog.ProductCatalog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductCatalogs","catalog");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5054021b-d151-473d-ab12-f8f81f194e22"),
                            Created = new DateTime(2019, 10, 2, 8, 10, 6, 648, DateTimeKind.Utc).AddTicks(2773),
                            Desc = "quis nostrud exercitation ull",
                            ImagePath = "https://picsum.photos/1200/900?image=1",
                            InventoryId = new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd"),
                            IsDeleted = false,
                            Name = "tempor incididunt ut labore et do",
                            Price = 638.0,
                            ProductId = new Guid("05233341-185a-468a-b074-00ebd08559aa"),
                            Version = 0
                        },
                        new
                        {
                            Id = new Guid("56170822-c912-4a17-bbc0-4e6389a0c4db"),
                            Created = new DateTime(2019, 10, 2, 8, 10, 6, 649, DateTimeKind.Utc).AddTicks(1057),
                            Desc = "sin",
                            ImagePath = "https://picsum.photos/1200/900?image=1",
                            InventoryId = new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd"),
                            IsDeleted = false,
                            Name = "m",
                            Price = 671.0,
                            ProductId = new Guid("3cb275c5-aa53-40ff-bc6a-015327053af9"),
                            Version = 0
                        },
                        new
                        {
                            Id = new Guid("d2549324-5299-413f-922b-f707f108e739"),
                            Created = new DateTime(2019, 10, 2, 8, 10, 6, 649, DateTimeKind.Utc).AddTicks(1592),
                            Desc = "dolor sit amet, consectetur adipiscing e",
                            ImagePath = "https://picsum.photos/1200/900?image=1",
                            InventoryId = new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd"),
                            IsDeleted = false,
                            Name = "ut labore et dolore magna aliqua. Ut enim ad minim ",
                            Price = 901.0,
                            ProductId = new Guid("a162b9ee-85b4-457a-93fc-015df74201dd"),
                            Version = 0
                        },
                        new
                        {
                            Id = new Guid("32945efe-294c-4c53-80b7-224cb08c8069"),
                            Created = new DateTime(2019, 10, 2, 8, 10, 6, 649, DateTimeKind.Utc).AddTicks(1614),
                            Desc = "est laborum.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididun",
                            ImagePath = "https://picsum.photos/1200/900?image=1",
                            InventoryId = new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd"),
                            IsDeleted = false,
                            Name = "non proident, sunt in culpa qui officia deserunt mollit anim id",
                            Price = 661.0,
                            ProductId = new Guid("ff58a71d-76a2-41f8-af44-018969694a59"),
                            Version = 0
                        },
                        new
                        {
                            Id = new Guid("3e5cc141-68bb-42b1-b176-70cc58bccedd"),
                            Created = new DateTime(2019, 10, 2, 8, 10, 6, 649, DateTimeKind.Utc).AddTicks(1635),
                            Desc = "ipsum dolor sit amet, consectetur adipis",
                            ImagePath = "https://picsum.photos/1200/900?image=1",
                            InventoryId = new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd"),
                            IsDeleted = false,
                            Name = "tempor incididunt ut labore ",
                            Price = 80.0,
                            ProductId = new Guid("9032b448-61f2-45f8-9e95-020961441613"),
                            Version = 0
                        },
                        new
                        {
                            Id = new Guid("1016202d-ebc5-41f4-9728-8fd7289457fd"),
                            Created = new DateTime(2019, 10, 2, 8, 10, 6, 649, DateTimeKind.Utc).AddTicks(1666),
                            Desc = "officia deserunt mollit anim id est laborum.Lorem ipsum dolor sit amet, consectetur adipi",
                            ImagePath = "https://picsum.photos/1200/900?image=1",
                            InventoryId = new Guid("b8b62196-6369-409d-b709-11c112dd023f"),
                            IsDeleted = false,
                            Name = "aliqua. Ut enim ad minim veniam, quis nostrud exercitation ul",
                            Price = 275.0,
                            ProductId = new Guid("d16e6353-0f88-43ba-9303-0241672d6ab6"),
                            Version = 0
                        },
                        new
                        {
                            Id = new Guid("c443fcf4-5aed-44fe-a45f-6a4c6a7b944e"),
                            Created = new DateTime(2019, 10, 2, 8, 10, 6, 649, DateTimeKind.Utc).AddTicks(1683),
                            Desc = "mollit anim id est laborum.Lo",
                            ImagePath = "https://picsum.photos/1200/900?image=1",
                            InventoryId = new Guid("b8b62196-6369-409d-b709-11c112dd023f"),
                            IsDeleted = false,
                            Name = "velit esse cillum dolore eu fugiat ",
                            Price = 738.0,
                            ProductId = new Guid("80258882-2a90-4038-ac48-0283bb0ac9b7"),
                            Version = 0
                        },
                        new
                        {
                            Id = new Guid("176b607d-9228-438a-bd7b-cc6c1d2e03fd"),
                            Created = new DateTime(2019, 10, 2, 8, 10, 6, 649, DateTimeKind.Utc).AddTicks(1762),
                            Desc = "elit, sed do eiusmod tempor incididunt ut labore et dolore magna a",
                            ImagePath = "https://picsum.photos/1200/900?image=1",
                            InventoryId = new Guid("b8b62196-6369-409d-b709-11c112dd023f"),
                            IsDeleted = false,
                            Name = "aute irure dolor in re",
                            Price = 51.0,
                            ProductId = new Guid("a11128b0-dd82-4179-99d9-0288e22db70b"),
                            Version = 0
                        },
                        new
                        {
                            Id = new Guid("ed08787c-088d-41ac-a8f2-87a1b4c34f96"),
                            Created = new DateTime(2019, 10, 2, 8, 10, 6, 649, DateTimeKind.Utc).AddTicks(1780),
                            Desc = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui ",
                            ImagePath = "https://picsum.photos/1200/900?image=1",
                            InventoryId = new Guid("b8b62196-6369-409d-b709-11c112dd023f"),
                            IsDeleted = false,
                            Name = "cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Lorem ipsu",
                            Price = 847.0,
                            ProductId = new Guid("e96a0646-6508-4e40-a035-0294e3b6a017"),
                            Version = 0
                        },
                        new
                        {
                            Id = new Guid("da5aa144-ae6c-4a29-897d-4f4bd770ff55"),
                            Created = new DateTime(2019, 10, 2, 8, 10, 6, 649, DateTimeKind.Utc).AddTicks(1797),
                            Desc = "voluptate velit esse cillum dolore eu fugiat nulla pariat",
                            ImagePath = "https://picsum.photos/1200/900?image=1",
                            InventoryId = new Guid("b8b62196-6369-409d-b709-11c112dd023f"),
                            IsDeleted = false,
                            Name = "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna a",
                            Price = 2.0,
                            ProductId = new Guid("d39650d3-7929-4702-bcb9-02978d2c2711"),
                            Version = 0
                        });
                });

            modelBuilder.Entity("VND.CoolStore.ShoppingCart.Domain.Cart.CartItem", b =>
                {
                    b.HasOne("VND.CoolStore.ShoppingCart.Domain.Cart.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CurrentCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VND.CoolStore.ShoppingCart.Domain.Cart.ProductCatalogId", b =>
                {
                    b.HasOne("VND.CoolStore.ShoppingCart.Domain.Cart.CartItem", "CartItem")
                        .WithOne("Product")
                        .HasForeignKey("VND.CoolStore.ShoppingCart.Domain.Cart.ProductCatalogId", "CurrentCartItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
