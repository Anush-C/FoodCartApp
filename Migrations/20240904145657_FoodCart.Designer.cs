﻿// <auto-generated />
using System;
using FoodCart.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodCart.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240904145657_FoodCart")]
    partial class FoodCart
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodCart.Models.CardPayment", b =>
                {
                    b.Property<int>("CardPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardPaymentId"));

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.HasKey("CardPaymentId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.ToTable("CardPayment");
                });

            modelBuilder.Entity("FoodCart.Models.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DelieveryAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int?>("MenuItemsItemID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUserID")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("MenuItemsItemID");

                    b.HasIndex("UsersUserID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("FoodCart.Models.DeliveryAgent", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("AvailStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18, 6)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18, 6)");

                    b.Property<string>("RatingsAndReviews")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsersUserID")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("UsersUserID");

                    b.ToTable("DeliveryAgents");
                });

            modelBuilder.Entity("FoodCart.Models.MenuCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryID");

                    b.ToTable("MenuCategories");
                });

            modelBuilder.Entity("FoodCart.Models.MenuItems", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemID"));

                    b.Property<string>("AvailabilityStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CuisineType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DietaryInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("MenuCategoryCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("TasteInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemID");

                    b.HasIndex("MenuCategoryCategoryID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("FoodCart.Models.NetBankingPayment", b =>
                {
                    b.Property<int>("NetBankingPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NetBankingPaymentId"));

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.HasKey("NetBankingPaymentId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.ToTable("NetBankingPayment");
                });

            modelBuilder.Entity("FoodCart.Models.Notification", b =>
                {
                    b.Property<int>("NotificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationID"));

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int?>("MenuItemsItemID")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NotificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotificationType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RestID")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUserID")
                        .HasColumnType("int");

                    b.HasKey("NotificationID");

                    b.HasIndex("MenuItemsItemID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UsersUserID");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("FoodCart.Models.OrderItems", b =>
                {
                    b.Property<int>("OrderItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemID"));

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int?>("MenuItemsItemID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int?>("OrdersOrderID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemID");

                    b.HasIndex("MenuItemsItemID");

                    b.HasIndex("OrdersOrderID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("FoodCart.Models.Orders", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int?>("DeliveryAgentID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeliveryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("int");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("DeliveryAgentID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodCart.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int?>("OrdersOrderID")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("TransDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrdersOrderID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("FoodCart.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantID"));

                    b.Property<TimeSpan>("ClosingHours")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("OpeningHours")
                        .HasColumnType("time");

                    b.Property<string>("RestaurantAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RestaurantDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RestaurantPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantID");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("FoodCart.Models.UpiPayment", b =>
                {
                    b.Property<int>("UpiPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UpiPaymentId"));

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<string>("UpiId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UpiPaymentId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.ToTable("UpiPayment");
                });

            modelBuilder.Entity("FoodCart.Models.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MenuItemsRestaurant", b =>
                {
                    b.Property<int>("MenuItemsItemID")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantsRestaurantID")
                        .HasColumnType("int");

                    b.HasKey("MenuItemsItemID", "RestaurantsRestaurantID");

                    b.HasIndex("RestaurantsRestaurantID");

                    b.ToTable("MenuItemsRestaurant");
                });

            modelBuilder.Entity("FoodCart.Models.CardPayment", b =>
                {
                    b.HasOne("FoodCart.Models.Payment", "Payment")
                        .WithOne("CardPayment")
                        .HasForeignKey("FoodCart.Models.CardPayment", "PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("FoodCart.Models.Cart", b =>
                {
                    b.HasOne("FoodCart.Models.MenuItems", "MenuItems")
                        .WithMany("Carts")
                        .HasForeignKey("MenuItemsItemID");

                    b.HasOne("FoodCart.Models.Users", "Users")
                        .WithMany("Carts")
                        .HasForeignKey("UsersUserID");

                    b.Navigation("MenuItems");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FoodCart.Models.DeliveryAgent", b =>
                {
                    b.HasOne("FoodCart.Models.Users", "Users")
                        .WithMany("DeliveryAgents")
                        .HasForeignKey("UsersUserID");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FoodCart.Models.MenuItems", b =>
                {
                    b.HasOne("FoodCart.Models.MenuCategory", "MenuCategory")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuCategoryCategoryID");

                    b.Navigation("MenuCategory");
                });

            modelBuilder.Entity("FoodCart.Models.NetBankingPayment", b =>
                {
                    b.HasOne("FoodCart.Models.Payment", "Payment")
                        .WithOne("NetBankingPayment")
                        .HasForeignKey("FoodCart.Models.NetBankingPayment", "PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("FoodCart.Models.Notification", b =>
                {
                    b.HasOne("FoodCart.Models.MenuItems", "MenuItems")
                        .WithMany("Notifications")
                        .HasForeignKey("MenuItemsItemID");

                    b.HasOne("FoodCart.Models.Restaurant", "Restaurant")
                        .WithMany("Notifications")
                        .HasForeignKey("RestaurantID");

                    b.HasOne("FoodCart.Models.Users", "Users")
                        .WithMany("Notifications")
                        .HasForeignKey("UsersUserID");

                    b.Navigation("MenuItems");

                    b.Navigation("Restaurant");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FoodCart.Models.OrderItems", b =>
                {
                    b.HasOne("FoodCart.Models.MenuItems", "MenuItems")
                        .WithMany("OrderItems")
                        .HasForeignKey("MenuItemsItemID");

                    b.HasOne("FoodCart.Models.Orders", "Orders")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrdersOrderID");

                    b.Navigation("MenuItems");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FoodCart.Models.Orders", b =>
                {
                    b.HasOne("FoodCart.Models.DeliveryAgent", "DeliveryAgent")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryAgentID");

                    b.HasOne("FoodCart.Models.Restaurant", "Restaurant")
                        .WithMany("Orders")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodCart.Models.Users", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryAgent");

                    b.Navigation("Restaurant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodCart.Models.Payment", b =>
                {
                    b.HasOne("FoodCart.Models.Orders", "Orders")
                        .WithMany()
                        .HasForeignKey("OrdersOrderID");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FoodCart.Models.UpiPayment", b =>
                {
                    b.HasOne("FoodCart.Models.Payment", "Payment")
                        .WithOne("UpiPayment")
                        .HasForeignKey("FoodCart.Models.UpiPayment", "PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("MenuItemsRestaurant", b =>
                {
                    b.HasOne("FoodCart.Models.MenuItems", null)
                        .WithMany()
                        .HasForeignKey("MenuItemsItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodCart.Models.Restaurant", null)
                        .WithMany()
                        .HasForeignKey("RestaurantsRestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodCart.Models.DeliveryAgent", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FoodCart.Models.MenuCategory", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("FoodCart.Models.MenuItems", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Notifications");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FoodCart.Models.Orders", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FoodCart.Models.Payment", b =>
                {
                    b.Navigation("CardPayment");

                    b.Navigation("NetBankingPayment");

                    b.Navigation("UpiPayment");
                });

            modelBuilder.Entity("FoodCart.Models.Restaurant", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FoodCart.Models.Users", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("DeliveryAgents");

                    b.Navigation("Notifications");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
