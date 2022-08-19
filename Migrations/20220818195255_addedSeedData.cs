using Microsoft.EntityFrameworkCore.Migrations;

namespace CoderResort.Migrations
{
    public partial class addedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Capacity", "Description", "ImageUrl", "Name", "Price", "Size" },
                values: new object[] { 1, 2, "Double Deluxe Room.", "https://i.ibb.co/L9bYkSZ/room-1.jpg", "Double Deluxe", 400m, 500m });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Capacity", "Description", "ImageUrl", "Name", "Price", "Size" },
                values: new object[] { 2, 5, "Family Standard Room.", "https://i.ibb.co/0yjxGxp/room-2.jpg", "Standard", 400m, 600m });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Capacity", "Description", "ImageUrl", "Name", "Price", "Size" },
                values: new object[] { 3, 8, "Presidential Room.", "https://i.ibb.co/2tCwhYF/room-3.jpg", "Presidential", 600m, 1000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3);
        }
    }
}
