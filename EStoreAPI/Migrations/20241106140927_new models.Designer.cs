﻿// <auto-generated />
using EStoreAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EStoreAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241106140927_new models")]
    partial class newmodels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EStoreAPI.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("EStoreAPI.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("EStoreAPI.Models.Cellphone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Cellphones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Light Green",
                            Image = "https://images.samsung.com/is/image/samsung/p6pim/se/2401/gallery/se-galaxy-s24-s928-491054-sm-s928blgheub-539439922?$720_576_JPG$",
                            Model = "Samsung Galaxy s24 Ultra",
                            Price = 22000m
                        },
                        new
                        {
                            Id = 2,
                            Color = "Moonlight Purple",
                            Image = "https://assets.spares.nu/products/thumb/101135809E_rQ6lLOnKjYIExsUw87Px0.jpg",
                            Model = "Iphone 15 Pro",
                            Price = 23000m
                        },
                        new
                        {
                            Id = 3,
                            Color = "Light Blue",
                            Image = "https://cdn.cdon.com/media-dynamic/images/product/cloud/store/UnlockedMobilePhones/000/140/488/326/140488326-279120600-11453-org.jpg?cache=133722718752479021",
                            Model = "Google Pixel 8 Pro",
                            Price = 22000m
                        },
                        new
                        {
                            Id = 4,
                            Color = "Grey",
                            Image = "https://m.media-amazon.com/images/I/91zKJjqgYeL.jpg",
                            Model = "Nokia 3210",
                            Price = 2999m
                        },
                        new
                        {
                            Id = 5,
                            Color = "Black",
                            Image = "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/pdp/admin-image/phones/mate50-pro/specs/mate50-pro-black.png",
                            Model = "Huawei Mate 50 Pro",
                            Price = 23000m
                        },
                        new
                        {
                            Id = 6,
                            Color = "Red",
                            Image = "https://rukminim2.flixcart.com/image/850/1000/xif0q/mobile/v/q/4/11r-5g-5011102671-oneplus-original-imagu5h8x9h8qwrv.jpeg?q=90&crop=false",
                            Model = "One Plus 11R",
                            Price = 18000m
                        });
                });

            modelBuilder.Entity("EStoreAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EStoreAPI.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("EStoreAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
