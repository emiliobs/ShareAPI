using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shared.API.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyIdnetity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TaxId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "ContactEmail", "Name", "Phone", "TaxId" },
                values: new object[,]
                {
                    { 1, "Silicon Valley 101", "info@alphatech.com", "Alpha Tech Group", "+15550101", "76.123.456-1" },
                    { 2, "Industrial Park 45", "ops@betalog.com", "Beta Logistics SA", "+15550102", "76.123.456-2" },
                    { 3, "Downtown Ave 789", "hello@gammalab.net", "Gamma Creative Lab", "+15550103", "76.123.456-3" },
                    { 4, "Market Street 12", "orders@deltafood.com", "Delta Food & Bev", "+15550104", "76.123.456-4" },
                    { 5, "Green Tower 5", "admin@epsilon.org", "Epsilon Energy", "+15550105", "76.123.456-5" },
                    { 6, "Medical Center Plaza", "care@zetahealth.com", "Zeta Healthcare", "+15550106", "76.123.456-6" },
                    { 7, "Build Site 99", "projects@etacon.com", "Eta Construction", "+15550107", "76.123.456-7" },
                    { 8, "Code Road 404", "support@theta.io", "Theta Software", "+15550108", "76.123.456-8" },
                    { 9, "Shopping Mall Wing B", "sales@iota.com", "Iota Retail", "+15550109", "76.123.456-9" },
                    { 10, "Wall Street 200", "finance@kappa.net", "Kappa Finance", "+15550110", "76.123.456-10" },
                    { 11, "Port Terminal 3", "fleet@lambda.com", "Lambda Transport", "+15550111", "76.123.456-11" },
                    { 12, "Creative Hub 10", "ads@mu.agency", "Mu Marketing", "+15550112", "76.123.456-12" },
                    { 13, "Signal Way 55", "noc@nu.com", "Nu Networking", "+15550113", "76.123.456-13" },
                    { 14, "Global Trade Center", "export@xi.com", "Xi Exports", "+15550114", "76.123.456-14" },
                    { 15, "Safe House Blvd", "protect@omicron.org", "Omicron Security", "+15550115", "76.123.456-15" },
                    { 16, "Expertise Lane 314", "advice@piconsult.com", "Pi Consulting", "+15550116", "76.123.456-16" },
                    { 17, "Property Heights 22", "rent@rho.com", "Rho Real Estate", "+15550117", "76.123.456-17" },
                    { 18, "Antenna Hill 1", "telco@sigma.io", "Sigma Telecom", "+15550118", "76.123.456-18" },
                    { 19, "Airport View 77", "travel@tau.com", "Tau Tourism", "+15550119", "76.123.456-19" },
                    { 20, "Mountain Road 50", "earth@upsilon.com", "Upsilon Mining", "+15550120", "76.123.456-20" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ContactEmail",
                table: "Companies",
                column: "ContactEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_TaxId",
                table: "Companies",
                column: "TaxId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
