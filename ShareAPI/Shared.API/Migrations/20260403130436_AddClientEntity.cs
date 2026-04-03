using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shared.API.Migrations
{
    /// <inheritdoc />
    public partial class AddClientEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "contact@techsolutions.com", "Tech Solutions", "+1234567890" },
                    { 2, "info@globallogistics.com", "Global Logistics", "+1987654321" },
                    { 3, "hello@creativeagency.net", "Creative Agency", "+1122334455" },
                    { 4, "support@summitretail.com", "Summit Retail", "+1555666777" },
                    { 5, "admin@oceanic.org", "Oceanic Corp", "+1444333222" },
                    { 6, "billing@primehealth.com", "Prime Health", "+1888999000" },
                    { 7, "sales@ecoenergy.io", "Eco Energy", "+1777111222" },
                    { 8, "dev@stellarsoft.com", "Stellar Soft", "+1666555444" },
                    { 9, "manager@urbaneats.com", "Urban Eats", "+1222999888" },
                    { 10, "info@bluehorizon.com", "Blue Horizon", "+1333444555" },
                    { 11, "ops@fasttrack.com", "Fast Track", "+1999888777" },
                    { 12, "contact@greenleaf.net", "Green Leaf", "+1000111222" },
                    { 13, "support@nexusit.com", "Nexus IT", "+1111222333" },
                    { 14, "office@skyline.com", "Skyline Const", "+1444555666" },
                    { 15, "wealth@peakfinance.com", "Peak Finance", "+1777888999" },
                    { 16, "ads@novamedia.com", "Nova Media", "+1222333444" },
                    { 17, "land@terrafirma.org", "Terra Firma", "+1555444333" },
                    { 18, "gallery@vividarts.com", "Vivid Arts", "+1666777888" },
                    { 19, "ceo@zenith.com", "Zenith Group", "+1888777666" },
                    { 20, "build@deltaapps.io", "Delta Apps", "+1000999888" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Email",
                table: "Clients",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
