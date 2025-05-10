using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projekt.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pojazdy",
                columns: table => new
                {
                    IdPojazdu = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Marka = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    RokProdukcji = table.Column<int>(type: "integer", nullable: false),
                    Typ = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pojazdy", x => x.IdPojazdu);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motory",
                columns: table => new
                {
                    IdPojazdu = table.Column<int>(type: "integer", nullable: false),
                    PojemnoscSilnika = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motory", x => x.IdPojazdu);
                    table.ForeignKey(
                        name: "FK_Motory_Pojazdy_IdPojazdu",
                        column: x => x.IdPojazdu,
                        principalTable: "Pojazdy",
                        principalColumn: "IdPojazdu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Osobowe",
                columns: table => new
                {
                    IdPojazdu = table.Column<int>(type: "integer", nullable: false),
                    LiczbaDrzwi = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osobowe", x => x.IdPojazdu);
                    table.ForeignKey(
                        name: "FK_Osobowe_Pojazdy_IdPojazdu",
                        column: x => x.IdPojazdu,
                        principalTable: "Pojazdy",
                        principalColumn: "IdPojazdu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pojazdy",
                columns: new[] { "IdPojazdu", "Marka", "Model", "RokProdukcji", "Typ" },
                values: new object[,]
                {
                    { 1, "Opel", "Corsa", 2000, "Osobowy" },
                    { 2, "Yamaha", "R1", 2015, "Motor" },
                    { 3, "Audi", "A6", 2011, "Osobowy" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[] { 1, "admin", "admin123" });

            migrationBuilder.InsertData(
                table: "Motory",
                columns: new[] { "IdPojazdu", "PojemnoscSilnika" },
                values: new object[] { 2, 1000 });

            migrationBuilder.InsertData(
                table: "Osobowe",
                columns: new[] { "IdPojazdu", "LiczbaDrzwi" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 3, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motory");

            migrationBuilder.DropTable(
                name: "Osobowe");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Pojazdy");
        }
    }
}
