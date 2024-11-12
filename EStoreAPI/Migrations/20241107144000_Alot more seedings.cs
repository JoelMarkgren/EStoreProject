using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EStoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class Alotmoreseedings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cellphones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cellphones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cellphones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cellphones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cellphones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cellphones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cellphone" },
                    { 2, "Laptop" },
                    { 3, "Console" },
                    { 4, "TV" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "Super-duper awesome Cellphone with top of the line camera.", "/Images/Cellphones/Samsung.jpg", "Samsung Galaxy s24 Ultra", 23000m, 100 },
                    { 2, 1, "Apple's newest juicy cellphone that everybody is talking about.", "/Images/Cellphones/Iphone.jpg", "Iphone 15 Pro", 24000m, 45 },
                    { 3, 1, "Google's newest masterpiece with great AI technology built-in features.", "/Images/Cellphones/Google.jpg", "Google Pixel 8 Pro", 19999m, 30 },
                    { 4, 1, "Blast from the past! Take a break from all the social-media apps and play the original snake instead.", "/Images/Cellphones/Nokia.jpg", "Nokia 3210", 3000m, 60 },
                    { 5, 1, "Awesome, affordable and easy to use. Buy this exceptional phone and you wont regret it.", "/Images/Cellphones/OnePlus.jpg", "One Plus 11R", 17999m, 85 },
                    { 6, 3, "Modern Gaming Consoles, Top Performing.", "/Images/Consoles/Playstation.jpg", "Playstation 5", 7000m, 120 },
                    { 7, 3, "Modern Gaming Consoles, Top Performing.", "/Images/Consoles/Xbox.jpg", "X-Box Series X", 6000m, 200 },
                    { 8, 3, "Modern Gaming Consoles, Top Performing.", "/Images/Consoles/Switch.jpg", "Nintendo Switch", 4500m, 300 },
                    { 9, 3, "Retro gaming, for the good old days.", "/Images/Consoles/Nintendo64.jpg", "Nintendo 64", 1999m, 20 },
                    { 10, 3, "Retro gaming, for the good old days.", "/Images/Consoles/SuperNintendo.jpg", "Super Nintendo", 1499m, 15 },
                    { 11, 2, "Powerful gaming laptops.", "/Images/Laptops/AcerNitro.jpg", "Acer Nitro V16", 12000m, 212 },
                    { 12, 2, "Powerful gaming laptops.", "/Images/Laptops/Lenovo7.", "Lenovo Legion 7", 14000m, 112 },
                    { 13, 2, "Powerful gaming laptops.", "/Images/Laptops/Asus.jpg", "Asus Rog Strix G16", 11999m, 90 },
                    { 14, 2, "", "/Images/Laptops/MacBook.jpg", "MacBook Air", 14995m, 95 },
                    { 15, 2, "", "/Images/Laptops/Hp.jpg", "Hp Laptop 15s", 11000m, 100 },
                    { 16, 4, "65' 8K", "/Images/TVs/Samsung.jpg", "Neo Samsung QLED 65' QN800D 8K Smart TV", 24000m, 50 },
                    { 19, 4, "75' OLED", "/Images/TVs/LG.jpg", "LG 75' OLED Evo Smart TV", 150m, 60 },
                    { 20, 4, "Samsung 55'.", "/Images/TVs/TheFrame.jpg", "Samsung 55' The Frame LS03D 4K QLED Smart TV", 200m, 70 },
                    { 21, 4, "Nanocell, AI , 4k, 86'.", "/Images/Tvs/LGNano.jpg", "4K NanoCell-TV 86' with AI-improved sound and pictures", 44000m, 120 },
                    { 22, 4, "98' Biggest of them all.", "/Images/TVs/Biggest.jpg", "TCL 98C855", 69500m, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Cellphones",
                columns: new[] { "Id", "Color", "Image", "Model", "Price" },
                values: new object[,]
                {
                    { 1, "Light Green", "https://images.samsung.com/is/image/samsung/p6pim/se/2401/gallery/se-galaxy-s24-s928-491054-sm-s928blgheub-539439922?$720_576_JPG$", "Samsung Galaxy s24 Ultra", 22000m },
                    { 2, "Moonlight Purple", "https://assets.spares.nu/products/thumb/101135809E_rQ6lLOnKjYIExsUw87Px0.jpg", "Iphone 15 Pro", 23000m },
                    { 3, "Light Blue", "https://cdn.cdon.com/media-dynamic/images/product/cloud/store/UnlockedMobilePhones/000/140/488/326/140488326-279120600-11453-org.jpg?cache=133722718752479021", "Google Pixel 8 Pro", 22000m },
                    { 4, "Grey", "https://m.media-amazon.com/images/I/91zKJjqgYeL.jpg", "Nokia 3210", 2999m },
                    { 5, "Black", "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/pdp/admin-image/phones/mate50-pro/specs/mate50-pro-black.png", "Huawei Mate 50 Pro", 23000m },
                    { 6, "Red", "https://rukminim2.flixcart.com/image/850/1000/xif0q/mobile/v/q/4/11r-5g-5011102671-oneplus-original-imagu5h8x9h8qwrv.jpeg?q=90&crop=false", "One Plus 11R", 18000m }
                });
        }
    }
}
