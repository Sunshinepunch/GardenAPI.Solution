using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenAPI.Migrations
{
    public partial class Development : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seeds",
                columns: table => new
                {
                    SeedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SeedName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SqFootPlant = table.Column<int>(type: "int", nullable: false),
                    DaysTillHarvest = table.Column<int>(type: "int", nullable: false),
                    WaterInterval = table.Column<int>(type: "int", nullable: false),
                    DaysTillSprout = table.Column<int>(type: "int", nullable: false),
                    Companions = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Enemies = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Notes = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Zone = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seeds", x => x.SeedId);
                });

            migrationBuilder.CreateTable(
                name: "ZipZones",
                columns: table => new
                {
                    ZipZoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    Zone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZipZones", x => x.ZipZoneId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seeds");

            migrationBuilder.DropTable(
                name: "ZipZones");
        }
    }
}
