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
    [Migration("20241111100802_smallest change in seeding")]
    partial class smallestchangeinseeding
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
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Cellphones");
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

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Super-duper awesome Cellphone with top of the line camera.",
                            ImageURL = "/Images/Cellphones/Samsung.jpg",
                            Name = "Samsung Galaxy s24 Ultra",
                            Price = 23000m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Apple's newest juicy cellphone that everybody is talking about.",
                            ImageURL = "/Images/Cellphones/Iphone.jpg",
                            Name = "Iphone 15 Pro",
                            Price = 24000m,
                            Qty = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Google's newest masterpiece with great AI technology built-in features.",
                            ImageURL = "/Images/Cellphones/Google.jpg",
                            Name = "Google Pixel 8 Pro",
                            Price = 19999m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Blast from the past! Take a break from all the social-media apps and play the original snake instead.",
                            ImageURL = "/Images/Cellphones/Nokia.jpg",
                            Name = "Nokia 3210",
                            Price = 3000m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Awesome, affordable and easy to use. Buy this exceptional phone and you wont regret it.",
                            ImageURL = "/Images/Cellphones/OnePlus.jpg",
                            Name = "One Plus 11R",
                            Price = 17999m,
                            Qty = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Modern Gaming Consoles, Top Performing.",
                            ImageURL = "/Images/Consoles/Playstation.jpg",
                            Name = "Playstation 5",
                            Price = 7000m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Modern Gaming Consoles, Top Performing.",
                            ImageURL = "/Images/Consoles/Xbox.jpg",
                            Name = "X-Box Series X",
                            Price = 6000m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Modern Gaming Consoles, Top Performing.",
                            ImageURL = "/Images/Consoles/Switch.jpg",
                            Name = "Nintendo Switch",
                            Price = 4500m,
                            Qty = 300
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Retro gaming, for the good old days.",
                            ImageURL = "/Images/Consoles/Nintendo64.jpg",
                            Name = "Nintendo 64",
                            Price = 1999m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Retro gaming, for the good old days.",
                            ImageURL = "/Images/Consoles/SuperNintendo.jpg",
                            Name = "Super Nintendo",
                            Price = 1499m,
                            Qty = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "Powerful gaming laptops.",
                            ImageURL = "/Images/Laptops/AcerNitro.jpg",
                            Name = "Acer Nitro V16",
                            Price = 12000m,
                            Qty = 212
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Powerful gaming laptops.",
                            ImageURL = "/Images/Laptops/Lenovo7.jpg",
                            Name = "Lenovo Legion 7",
                            Price = 14000m,
                            Qty = 112
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Powerful gaming laptops.",
                            ImageURL = "/Images/Laptops/Asus.jpg",
                            Name = "Asus Rog Strix G16",
                            Price = 11999m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "For Mac-lovers.",
                            ImageURL = "/Images/Laptops/MacBook.jpg",
                            Name = "MacBook Air",
                            Price = 14995m,
                            Qty = 95
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Insanley Good Coding Computer.",
                            ImageURL = "/Images/Laptops/Hp.jpg",
                            Name = "Hp Laptop 15s",
                            Price = 11000m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            Description = "65' 8K",
                            ImageURL = "/Images/TVs/Samsung.jpg",
                            Name = "Neo Samsung QLED 65' QN800D 8K Smart TV",
                            Price = 24000m,
                            Qty = 50
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "75' OLED",
                            ImageURL = "/Images/TVs/LG.jpg",
                            Name = "LG 75' OLED Evo Smart TV",
                            Price = 150m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Samsung 55'.",
                            ImageURL = "/Images/TVs/TheFrame.jpg",
                            Name = "Samsung 55' The Frame LS03D 4K QLED Smart TV",
                            Price = 200m,
                            Qty = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Nanocell, AI , 4k, 86'.",
                            ImageURL = "/Images/Tvs/LGNano.jpg",
                            Name = "4K NanoCell-TV 86' with AI-improved sound and pictures",
                            Price = 44000m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "98' Biggest of them all.",
                            ImageURL = "/Images/TVs/Biggest.jpg",
                            Name = "TCL 98C855",
                            Price = 69500m,
                            Qty = 100
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cellphones"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Laptops"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Consoles"
                        },
                        new
                        {
                            Id = 4,
                            Name = "TVs"
                        });
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

            modelBuilder.Entity("EStoreAPI.Models.Product", b =>
                {
                    b.HasOne("EStoreAPI.Models.ProductCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
