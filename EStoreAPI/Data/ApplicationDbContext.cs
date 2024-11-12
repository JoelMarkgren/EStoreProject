using EStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EStoreAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Cellphone> Cellphones { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Cellphone>()
            //    .Property(c => c.Price)
            //    .HasPrecision(18, 2);
            //modelBuilder.Entity<Cellphone>()
            //    .HasData(
            //    new Cellphone { Id = 1, Color = "Light Green", Model = "Samsung Galaxy s24 Ultra", Price = 22000, Image = "https://images.samsung.com/is/image/samsung/p6pim/se/2401/gallery/se-galaxy-s24-s928-491054-sm-s928blgheub-539439922?$720_576_JPG$" },
            //    new Cellphone { Id = 2, Color = "Moonlight Purple", Model = "Iphone 15 Pro", Price = 23000, Image = "https://assets.spares.nu/products/thumb/101135809E_rQ6lLOnKjYIExsUw87Px0.jpg" },
            //    new Cellphone { Id = 3, Color = "Light Blue", Model = "Google Pixel 8 Pro", Price = 22000, Image = "https://cdn.cdon.com/media-dynamic/images/product/cloud/store/UnlockedMobilePhones/000/140/488/326/140488326-279120600-11453-org.jpg?cache=133722718752479021" },
            //    new Cellphone { Id = 4, Color = "Grey", Model = "Nokia 3210", Price = 2999, Image = "https://m.media-amazon.com/images/I/91zKJjqgYeL.jpg" },
            //    new Cellphone { Id = 5, Color = "Black", Model = "Huawei Mate 50 Pro", Price = 23000, Image = "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/pdp/admin-image/phones/mate50-pro/specs/mate50-pro-black.png" },
            //    new Cellphone { Id = 6, Color = "Red", Model = "One Plus 11R", Price = 18000, Image = "https://rukminim2.flixcart.com/image/850/1000/xif0q/mobile/v/q/4/11r-5g-5011102671-oneplus-original-imagu5h8x9h8qwrv.jpeg?q=90&crop=false" }
            //    );
            // Cellphones
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Samsung Galaxy s24 Ultra",
                Description = "Super-duper awesome Cellphone with top of the line camera.",
                ImageURL = "/Images/Cellphones/Samsung.jpg",
                Price = 23000,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Iphone 15 Pro",
                Description = "Apple's newest juicy cellphone that everybody is talking about.",
                ImageURL = "/Images/Cellphones/Iphone.jpg",
                Price = 24000,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Google Pixel 8 Pro",
                Description = "Google's newest masterpiece with great AI technology built-in features.",
                ImageURL = "/Images/Cellphones/Google.jpg",
                Price = 19999,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Nokia 3210",
                Description = "Blast from the past! Take a break from all the social-media apps and play the original snake instead.",
                ImageURL = "/Images/Cellphones/Nokia.jpg",
                Price = 3000,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "One Plus 11R",
                Description = "Awesome, affordable and easy to use. Buy this exceptional phone and you wont regret it.",
                ImageURL = "/Images/Cellphones/OnePlus.jpg",
                Price = 17999,
                Qty = 85,
                CategoryId = 1

            });

            // Consoles

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Playstation 5",
                Description = "Modern Gaming Consoles, Top Performing.",
                ImageURL = "/Images/Consoles/Playstation.jpg",
                Price = 7000,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "X-Box Series X",
                Description = "Modern Gaming Consoles, Top Performing.",
                ImageURL = "/Images/Consoles/Xbox.jpg",
                Price = 6000,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Nintendo Switch",
                Description = "Modern Gaming Consoles, Top Performing.",
                ImageURL = "/Images/Consoles/Switch.jpg",
                Price = 4500,
                Qty = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Nintendo 64",
                Description = "Retro gaming, for the good old days.",
                ImageURL = "/Images/Consoles/Nintendo64.jpg",
                Price = 1999,
                Qty = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Super Nintendo",
                Description = "Retro gaming, for the good old days.",
                ImageURL = "/Images/Consoles/SuperNintendo.jpg",
                Price = 1499,
                Qty = 15,
                CategoryId = 3

            });
            
            //Laptops

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Acer Nitro V16",
                Description = "Powerful gaming laptops.",
                ImageURL = "/Images/Laptops/AcerNitro.jpg",
                Price = 12000,
                Qty = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Lenovo Legion 7",
                Description = "Powerful gaming laptops.",
                ImageURL = "/Images/Laptops/Lenovo7.jpg",
                Price = 14000,
                Qty = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Asus Rog Strix G16",
                Description = "Powerful gaming laptops.",
                ImageURL = "/Images/Laptops/Asus.jpg",
                Price = 11999,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "MacBook Air",
                Description = "For Mac-lovers.",
                ImageURL = "/Images/Laptops/MacBook.jpg",
                Price = 14995,
                Qty = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Hp Laptop 15s",
                Description = "Insanley Good Coding Computer.",
                ImageURL = "/Images/Laptops/Hp.jpg",
                Price = 11000,
                Qty = 100,
                CategoryId = 2
            });
           
            //TVs

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Neo Samsung QLED 65' QN800D 8K Smart TV",
                Description = "65' 8K",
                ImageURL = "/Images/TVs/Samsung.jpg",
                Price = 24000,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "LG 75' OLED Evo Smart TV",
                Description = "75' OLED",
                ImageURL = "/Images/TVs/LG.jpg",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Samsung 55' The Frame LS03D 4K QLED Smart TV",
                Description = "Samsung 55'.",
                ImageURL = "/Images/TVs/TheFrame.jpg",
                Price = 200,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "4K NanoCell-TV 86' with AI-improved sound and pictures",
                Description = "Nanocell, AI , 4k, 86'.",
                ImageURL = "/Images/Tvs/LGNano.jpg",
                Price = 44000,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "TCL 98C855",
                Description = "98' Biggest of them all.",
                ImageURL = "/Images/TVs/Biggest.jpg",
                Price = 69500,
                Qty = 100,
                CategoryId = 4
            });

            //Add users
            //modelBuilder.Entity<User>().HasData(new User
            //{
            //    Id = 1,
            //    UserName = "Bob"

            //});
            //modelBuilder.Entity<User>().HasData(new User
            //{
            //    Id = 2,
            //    UserName = "Sarah"

            //});

            ////Create Shopping Cart for Users
            //modelBuilder.Entity<Cart>().HasData(new Cart
            //{
            //    Id = 1,
            //    UserId = 1

            //});
            //modelBuilder.Entity<Cart>().HasData(new Cart
            //{
            //    Id = 2,
            //    UserId = 2

            //});
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Cellphones"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Laptops"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Consoles"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "TVs"
            });

        }
    }
}
