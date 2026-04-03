using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shared.API.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "emilio@example.com", "Emilio", "Barrera", "Pass123", "56912345678123456789" },
                    { 2, "juan.perez@example.com", "Juan", "Perez", "User456", "56900000000123456780" },
                    { 3, "m.lopez@example.com", "Maria", "Lopez", "Secret789", "56900000000123456781" },
                    { 4, "c.soto@example.com", "Carlos", "Soto", "Admin321", "56900000000123456782" },
                    { 5, "a.silva@example.com", "Ana", "Silva", "Power999", "56900000000123456783" },
                    { 6, "l.martinez@example.com", "Luis", "Martinez", "Login111", "56900000000123456784" },
                    { 7, "e.gomez@example.com", "Elena", "Gomez", "Pass555", "56900000000123456785" },
                    { 8, "p.castro@example.com", "Pedro", "Castro", "Word000", "56900000000123456786" },
                    { 9, "s.rojas@example.com", "Sofia", "Rojas", "Key1234", "56900000000123456787" },
                    { 10, "d.torres@example.com", "Diego", "Torres", "Dev8888", "56900000000123456788" },
                    { 11, "l.vargas@example.com", "Laura", "Vargas", "Test222", "56900000000123456789" },
                    { 12, "j.herrera@example.com", "Jorge", "Herrera", "Secure9", "56900000000123456710" },
                    { 13, "r.mendez@example.com", "Rosa", "Mendez", "Mendez1", "56900000000123456711" },
                    { 14, "p.araya@example.com", "Pablo", "Araya", "Araya22", "56900000000123456712" },
                    { 15, "c.nunez@example.com", "Carmen", "Nuñez", "Nunez33", "56900000000123456713" },
                    { 16, "m.pinto@example.com", "Mario", "Pinto", "Pinto44", "56900000000123456714" },
                    { 17, "i.duran@example.com", "Isabel", "Duran", "Duran55", "56900000000123456715" },
                    { 18, "a.jara@example.com", "Andres", "Jara", "Jara666", "56900000000123456716" },
                    { 19, "p.salas@example.com", "Paola", "Salas", "Salas77", "56900000000123456717" },
                    { 20, "r.vega@example.com", "Raul", "Vega", "Vega888", "56900000000123456718" },
                    { 21, "g.ruz@example.com", "Gloria", "Ruz", "Ruz9999", "56900000000123456719" },
                    { 22, "f.leiva@example.com", "Felipe", "Leiva", "Leiva10", "56900000000123456720" },
                    { 23, "m.pena@example.com", "Monica", "Pena", "Pena202", "56900000000123456721" },
                    { 24, "h.cano@example.com", "Hugo", "Cano", "Cano303", "56900000000123456722" },
                    { 25, "s.bustos@example.com", "Silvia", "Bustos", "Bustos4", "56900000000123456723" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
