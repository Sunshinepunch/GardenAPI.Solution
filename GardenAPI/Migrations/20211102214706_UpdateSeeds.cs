using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenAPI.Migrations
{
    public partial class UpdateSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seeds",
                columns: new[] { "SeedId", "Companions", "DaysTillHarvest", "DaysTillSprout", "Enemies", "Notes", "SeedName", "SqFootPlant", "WaterInterval", "Zone" },
                values: new object[,]
                {
                    { 1, "carrot, catnip, celery, chamomile, corn, cucumber, marigold, nasturtium, oregano", 80, 10, "chives, garlic, leek, onion", "full sun, direct sow outdoors", "pole beans", 4, 3, "2, 3, 4, 5, 6, 7, 8, 9, 10, 11" },
                    { 2, "basil, garlic, parsley, amaranth, carrot, borage, marigold, onion, sage, cucumber", 85, 10, "cabbage, broccoli, fennel, corn, kale, dill, pepper, eggplant, potato, brussel sprouts, cauliflower, collards, kholrabi,", "full sun, start indoors and transplant", "tomato", 1, 1, "5, 6, 7, 8, 9, 10, 11" },
                    { 3, "lettuce, tomato, carrot, onion, pepper, peas, cucumber, spinach", 60, 4, "cabbage, broccoli, kale, brussel sprouts, cauliflower, collards, kholrabi, hyssop, turnip", "full sun,  direct sow outdoors", "radish", 16, 5, "5, 6, 7, 8, 9" },
                    { 4, "borage, cucumber, dill, melon, marigold, pole beans, nasturtium", 100, 14, "cabbage, broccoli, fennel, kale, pepper, eggplant, brussel sprouts, cauliflower, collards, kholrabi,", "full sun, start indoors and transplant or direct seed outdoors", "corn", 4, 5, "4, 5, 6, 7, 8, 9" },
                    { 5, "cabbage, kale, cauliflower, collards, eggplant, leek, lettuce, brussels sprouts, kohlrabi, asparagus, strawberries, radish, beans, peas, nasturtium, petunia, marigold", 45, 5, "sunflowers, fennel, pumpkins, melons, corn, potatoes", "full sun, direct sow outdoors", "spinach", 9, 2, "2, 3, 4, 5, 6, 7, 8, 9" },
                    { 6, "chives, garlic, marigold, beet, carrot, parsnip, onion, strawberries, corn, eggplant, tomato, corn, asparagus, peas, radish", 45, 10, "cabbage, broccoli, kale, brussel sprouts, cauliflower, collards, kholrabi", "full sun, direct sow outdoors", "loose-leaf lettuce", 4, 4, "2, 3, 4, 5, 6, 7, 8, 9" },
                    { 7, "cabbage, broccoli, kale, brussel sprouts, cauliflower, collards, kholrabi, carrot, leek, beet, strawberries", 90, 10, "peas, pole beans, bush beans, asparagus", "full sun, direct sow or from bulb outdoors", "onion", 4, 3, "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11" },
                    { 8, "peas, pole beans, bush beans, onions, leeks, chives, and garlic, cabbage, broccoli, cauliflower, carrots, kale, okra, spinach, sunflowers, lettuce, brussels sprouts", 90, 12, "any new plants grown by seed (watermelons release chemicals that inhibit seed growth)", "full sun, start indoors and transplant", "watermelon", 1, 3, "3, 4, 5, 6, 7, 8, 9, 10, 11" },
                    { 9, "corn, beans, radish, nasturtium, aromatic herbs", 120, 10, "beet, onion, potato, cabbage, broccoli, kale, brussel sprouts, cauliflower, collards, kholrabi", "full sun, direct sow outdoors", "pumpkin", 1, 3, "3, 4, 5, 6, 7" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seeds",
                keyColumn: "SeedId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seeds",
                keyColumn: "SeedId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seeds",
                keyColumn: "SeedId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seeds",
                keyColumn: "SeedId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seeds",
                keyColumn: "SeedId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seeds",
                keyColumn: "SeedId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seeds",
                keyColumn: "SeedId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seeds",
                keyColumn: "SeedId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seeds",
                keyColumn: "SeedId",
                keyValue: 9);
        }
    }
}
