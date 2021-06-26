﻿// <auto-generated />
using System;
using J6.DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace J6.Migrations
{
    [DbContext(typeof(DbContainer))]
    [Migration("20210624074820_Edit-Address2")]
    partial class EditAddress2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("J6.DAL.Entities.Address", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("J6.DAL.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("J6.DAL.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("IsActive")
                        .IsFixedLength(true);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("J6.DAL.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("J6.DAL.Entities.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("J6.DAL.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Cost")
                        .HasColumnType("int")
                        .HasColumnName("cost");

                    b.Property<int>("CustimerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("date")
                        .HasColumnName("orderDate");

                    b.Property<string>("Paymentid")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("paymentid");

                    b.Property<DateTime?>("ShippingDate")
                        .HasColumnType("date")
                        .HasColumnName("shippingDate");

                    b.HasKey("Id");

                    b.HasIndex("CustimerId")
                        .IsUnique();

                    b.ToTable("cart");
                });

            modelBuilder.Entity("J6.DAL.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("categoryId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("categoryName");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("date")
                        .HasColumnName("updatedAt");

                    b.HasKey("CategoryId");

                    b.ToTable("category");
                });

            modelBuilder.Entity("J6.DAL.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SenderId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.Property<int>("sellerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("J6.DAL.Entities.MiddleSavedProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SaveBagId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "SaveBagId");

                    b.HasIndex("SaveBagId");

                    b.ToTable("ProductsBag");
                });

            modelBuilder.Entity("J6.DAL.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustimerId")
                        .HasColumnType("int");

                    b.Property<double>("OrderCost")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustimerId")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("J6.DAL.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Paymenttype")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .HasDefaultValue("PayPal")
                        .HasColumnName("paymenttype")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("J6.DAL.Entities.ProdCart", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int")
                        .HasColumnName("cartId");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("productId");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId");

                    b.ToTable("prod_Cart");
                });

            modelBuilder.Entity("J6.DAL.Entities.ProdOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.ToTable("ProdOrders");
                });

            modelBuilder.Entity("J6.DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PromotionId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<int?>("SellerId")
                        .HasColumnType("int");

                    b.Property<int>("Ship")
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasColumnName("ship");

                    b.Property<int>("Size")
                        .HasMaxLength(10)
                        .HasColumnType("int")
                        .HasColumnName("size")
                        .IsFixedLength(true);

                    b.Property<int?>("SoldQuantities")
                        .HasColumnType("int");

                    b.Property<int?>("SubcategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("material")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("PromotionId");

                    b.HasIndex("SellerId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("J6.DAL.Entities.Promotion", b =>
                {
                    b.Property<int>("PromotionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.HasKey("PromotionId");

                    b.HasIndex("SellerId");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("J6.DAL.Entities.Review", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationTime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("CustomerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("J6.DAL.Entities.SavedBag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("SavedBag");
                });

            modelBuilder.Entity("J6.DAL.Entities.SubCategory", b =>
                {
                    b.Property<int>("SubcategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubcategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("SubcategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("J6.DAL.Entities.View", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("CustomerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Views");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("J6.DAL.Entities.Address", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", "AppUser")
                        .WithOne("Address")
                        .HasForeignKey("J6.DAL.Entities.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("J6.DAL.Entities.AppUserRole", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppRole", "Role")
                        .WithMany("userRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("J6.DAL.Entities.AppUser", "user")
                        .WithMany("userRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("user");
                });

            modelBuilder.Entity("J6.DAL.Entities.Cart", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("J6.DAL.Entities.Cart", "CustimerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("J6.DAL.Entities.Message", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", "Sender")
                        .WithMany("Messages")
                        .HasForeignKey("SenderId");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("J6.DAL.Entities.MiddleSavedProduct", b =>
                {
                    b.HasOne("J6.DAL.Entities.Product", "Product")
                        .WithMany("ProductsBag")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("J6.DAL.Entities.SavedBag", "Bag")
                        .WithMany("ProductsBag")
                        .HasForeignKey("SaveBagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bag");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("J6.DAL.Entities.Order", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", "Customer")
                        .WithOne("Order")
                        .HasForeignKey("J6.DAL.Entities.Order", "CustimerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("J6.DAL.Entities.Payment", b =>
                {
                    b.HasOne("J6.DAL.Entities.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("J6.DAL.Entities.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("J6.DAL.Entities.ProdCart", b =>
                {
                    b.HasOne("J6.DAL.Entities.Cart", "Cart")
                        .WithMany("ProdCarts")
                        .HasForeignKey("CartId")
                        .HasConstraintName("FK_prod_Cart_cart")
                        .IsRequired();

                    b.HasOne("J6.DAL.Entities.Product", "CartNavigation")
                        .WithMany("ProdCarts")
                        .HasForeignKey("CartId")
                        .HasConstraintName("FK_prod_Cart_product")
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("CartNavigation");
                });

            modelBuilder.Entity("J6.DAL.Entities.ProdOrder", b =>
                {
                    b.HasOne("J6.DAL.Entities.Order", "Order")
                        .WithMany("ProdOrders")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_prod_order_Orders")
                        .IsRequired();

                    b.HasOne("J6.DAL.Entities.Product", "Product")
                        .WithMany("ProdOrders")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_prod_order_product")
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("J6.DAL.Entities.Product", b =>
                {
                    b.HasOne("J6.DAL.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.HasOne("J6.DAL.Entities.Promotion", "Promotion")
                        .WithMany("Products")
                        .HasForeignKey("PromotionId")
                        .HasConstraintName("FK_product_Promotions");

                    b.HasOne("J6.DAL.Entities.AppUser", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId");

                    b.HasOne("J6.DAL.Entities.SubCategory", "Subcategory")
                        .WithMany("Products")
                        .HasForeignKey("SubcategoryId")
                        .HasConstraintName("FK_product_subCategory");

                    b.Navigation("Brand");

                    b.Navigation("Promotion");

                    b.Navigation("Seller");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("J6.DAL.Entities.Promotion", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", "Seller")
                        .WithMany("Promotions")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("J6.DAL.Entities.Review", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Reviews_Customer")
                        .IsRequired();

                    b.HasOne("J6.DAL.Entities.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Reviews_product")
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("J6.DAL.Entities.SavedBag", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", "Customer")
                        .WithOne("Bag")
                        .HasForeignKey("J6.DAL.Entities.SavedBag", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("J6.DAL.Entities.SubCategory", b =>
                {
                    b.HasOne("J6.DAL.Entities.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_subCategory_category");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("J6.DAL.Entities.View", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", "Customer")
                        .WithMany("Views")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Views_Customer")
                        .IsRequired();

                    b.HasOne("J6.DAL.Entities.Product", "Product")
                        .WithMany("Views")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Views_product")
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("J6.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("J6.DAL.Entities.AppRole", b =>
                {
                    b.Navigation("userRoles");
                });

            modelBuilder.Entity("J6.DAL.Entities.AppUser", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Bag");

                    b.Navigation("Cart");

                    b.Navigation("Messages");

                    b.Navigation("Order");

                    b.Navigation("Products");

                    b.Navigation("Promotions");

                    b.Navigation("Reviews");

                    b.Navigation("userRoles");

                    b.Navigation("Views");
                });

            modelBuilder.Entity("J6.DAL.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("J6.DAL.Entities.Cart", b =>
                {
                    b.Navigation("ProdCarts");
                });

            modelBuilder.Entity("J6.DAL.Entities.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("J6.DAL.Entities.Order", b =>
                {
                    b.Navigation("Payment");

                    b.Navigation("ProdOrders");
                });

            modelBuilder.Entity("J6.DAL.Entities.Product", b =>
                {
                    b.Navigation("ProdCarts");

                    b.Navigation("ProdOrders");

                    b.Navigation("ProductsBag");

                    b.Navigation("Reviews");

                    b.Navigation("Views");
                });

            modelBuilder.Entity("J6.DAL.Entities.Promotion", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("J6.DAL.Entities.SavedBag", b =>
                {
                    b.Navigation("ProductsBag");
                });

            modelBuilder.Entity("J6.DAL.Entities.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
