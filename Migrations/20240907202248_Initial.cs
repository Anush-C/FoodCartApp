using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodCart.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Users_UsersUserID",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_UsersUserID",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "UsersUserID",
                table: "Restaurants");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsersUserID",
                table: "Restaurants",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: 1,
                column: "UsersUserID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: 2,
                column: "UsersUserID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: 3,
                column: "UsersUserID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: 4,
                column: "UsersUserID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: 5,
                column: "UsersUserID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: 6,
                column: "UsersUserID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: 7,
                column: "UsersUserID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: 8,
                column: "UsersUserID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: 9,
                column: "UsersUserID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: 10,
                column: "UsersUserID",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_UsersUserID",
                table: "Restaurants",
                column: "UsersUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Users_UsersUserID",
                table: "Restaurants",
                column: "UsersUserID",
                principalTable: "Users",
                principalColumn: "UserID");
        }
    }
}
