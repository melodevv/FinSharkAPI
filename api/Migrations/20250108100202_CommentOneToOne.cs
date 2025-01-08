using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class CommentOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c249f86b-33ae-4caf-acc9-adb1f3f1301b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d39924f1-a863-4520-97a4-4e8e75d41ae2");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Commnets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e921774-f21e-4389-884e-4cbf9eab744d", null, "User", "USER" },
                    { "c12e0d45-7659-4942-86da-735fc29331a6", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commnets_AppUserId",
                table: "Commnets",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commnets_AspNetUsers_AppUserId",
                table: "Commnets",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commnets_AspNetUsers_AppUserId",
                table: "Commnets");

            migrationBuilder.DropIndex(
                name: "IX_Commnets_AppUserId",
                table: "Commnets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e921774-f21e-4389-884e-4cbf9eab744d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c12e0d45-7659-4942-86da-735fc29331a6");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Commnets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c249f86b-33ae-4caf-acc9-adb1f3f1301b", null, "User", "USER" },
                    { "d39924f1-a863-4520-97a4-4e8e75d41ae2", null, "Admin", "ADMIN" }
                });
        }
    }
}
