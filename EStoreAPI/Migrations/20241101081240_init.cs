using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EStoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cellphones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cellphones", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cellphones",
                columns: new[] { "Id", "Color", "Image", "Model", "Price" },
                values: new object[,]
                {
                    { 1, "Light Green", "https://www.google.com/imgres?q=light%20green%20samsung%20galaxy%20s25%20ultra&imgurl=https%3A%2F%2Fimages.samsung.com%2Fis%2Fimage%2Fsamsung%2Fp6pim%2Fse%2F2401%2Fgallery%2Fse-galaxy-s24-s928-491054-sm-s928blgheub-539439922%3F%24720_576_JPG%24&imgrefurl=https%3A%2F%2Fwww.samsung.com%2Fse%2Fbusiness%2Fsmartphones%2Fgalaxy-s%2Fgalaxy-s24-ultra-512-gb-sm-s928blgheub%2Fbuy%2F&docid=1wBOu4q7cj1gPM&tbnid=cPYWdzd-lbDFTM&vet=12ahUKEwiCgJCm0LqJAxXhAhAIHRWIJ7sQM3oECBcQAA..i&w=720&h=576&hcb=2&ved=2ahUKEwiCgJCm0LqJAxXhAhAIHRWIJ7sQM3oECBcQAA", "Samsung Galaxy s24 Ultra", 22000m },
                    { 2, "Moonlight Purple", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freepik.com%2Fpremium-photo%2Fiphone-15-purple_43528206.htm&psig=AOvVaw1yNDg9B9dhezgxmTMYMm5J&ust=1730533242105000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPjQi-7QuokDFQAAAAAdAAAAABAE", "Iphone 15 Pro", 23000m },
                    { 3, "Light Blue", "https://www.google.com/imgres?q=Google%20pixel%208%20Pro%20blue&imgurl=https%3A%2F%2Fbsimg.nl%2Fimages%2Fgoogle-pixel-8-pro-256gb-blauw-eu_2.png%2FswX-eXQy8AQuj3MaYMhIvVQbzR8%253D%2Ffit-in%2F0x0%2Ffilters%253Aupscale%2528%2529&imgrefurl=https%3A%2F%2Fwww.gomibo.se%2Fgoogle-pixel-8-pro-eu%2F256gb-bla&docid=_7xgUh0742JgtM&tbnid=J1qYBDRhS5jBpM&vet=12ahUKEwj0hPSJ0bqJAxW3FRAIHaNmNzUQM3oECBwQAA..i&w=325&h=505&hcb=2&itg=1&ved=2ahUKEwj0hPSJ0bqJAxW3FRAIHaNmNzUQM3oECBwQAA", "Google Pixel 8 Pro", 22000m },
                    { 4, "Grey", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fsv.gagadget.com%2F450931-hmd-kommer-att-ateruppliva-nokia-3210-den-legendariska-telefonen-fran-1999%2F&psig=AOvVaw3urD6QAvAUzxJBD7jB5xi6&ust=1730533433250000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODapsbRuokDFQAAAAAdAAAAABAE", "Nokia 3210", 2999m },
                    { 5, "Black", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.se%2FHUAWEI-Aperture-SuperCharge-h%25C3%25B6gpresterande-batteri%2Fdp%2FB0BJ7L5DX4&psig=AOvVaw2a_6hjCZ7hhu7ShHmh-IXA&ust=1730533497889000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKjv4eXRuokDFQAAAAAdAAAAABAE", "Huawei Mate 50 Pro", 23000m },
                    { 6, "Red", "https://www.google.com/imgres?q=one%20plus%20red&imgurl=https%3A%2F%2Foasis.opstatics.com%2Fcontent%2Fdam%2Foasis%2Fpage%2F2023%2Fin%2Fproduct%2F11r%2F11r-red.png&imgrefurl=https%3A%2F%2Fwww.oneplus.in%2F11r%2Fspecs&docid=Cg52G3K2bK1jDM&tbnid=M1MHipRzXvT_XM&vet=12ahUKEwit3NqN0rqJAxX1ExAIHVkHC4sQM3oECGQQAA..i&w=1080&h=1080&hcb=2&ved=2ahUKEwit3NqN0rqJAxX1ExAIHVkHC4sQM3oECGQQAA", "One Plus 11R", 18000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cellphones");
        }
    }
}
