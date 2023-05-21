using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogDBContext.Migrations
{
    /// <inheritdoc />
    public partial class Version6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fad5fba-28fe-4933-8ee0-051dc8843c14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eb09a81-2f8a-4973-a2b2-03c0e21f1087");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f802e0b0-5004-419c-b45f-9ea4262109f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bd92cc7-e4cd-4a91-93fe-e478c576bbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db09f488-827c-4269-a36c-e6e59258e53e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1f8cfa8-dba2-479a-bbf3-6c1d8e7b9fc3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "7a1befc8-acae-4465-8050-5aade658e9a7", "Admin", "Admin" },
                    { "2", "8c56490c-8fb1-4d5a-9f42-7f20501eba1f", "User", "User" },
                    { "3", "35ca2b4d-571d-4ba9-96d1-15eff3c90569", "HR", "HR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "d1307b2b-6951-4d48-9020-da6a6b321b40", "admin@gmail.com", false, true, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBEHw7kLwy3R2awVLa3DjuLk5AZ8ZO3Wlp3NDOYv8PtolPY0Sq4rz20fNyCcULRr+Q==", null, false, "c516628a-2145-4948-97ff-8fa6d84eee9d", false, "admin@gmail.com" },
                    { "2", 0, "5cca9451-7989-4253-8f40-0291893d0ecd", "user@gmail.com", false, true, null, null, "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEAmRS/UGbLKHl9ZFU6fgruf2DCMI/VAnTLjkXpFl2ptNYadZxQ9sKOdGDySGr2+iZA==", null, false, "20021436-92c6-4248-a584-b6de3c1abf1b", false, "user@gmail.com" },
                    { "3", 0, "ed632cd7-d6d3-4457-8e9d-5f7a7c437ce9", "hr@gmail.com", false, true, null, null, "HR@GMAIL.COM", "AQAAAAEAACcQAAAAEByZvdL+t/MD2XOUDMn3ZS0gUk/iyiY/GeoPB4Umfak1JDnQ6ugNDSSiUJdDuZPKgA==", null, false, "27b20217-5978-4faa-9f0e-cd4a812abadc", false, "hr@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fad5fba-28fe-4933-8ee0-051dc8843c14", "9f748a96-204d-41e7-ab92-e1fff64c345f", "Admin", "Admin" },
                    { "9eb09a81-2f8a-4973-a2b2-03c0e21f1087", "9225bc3d-8321-40eb-8644-7facfb726195", "HR", "HR" },
                    { "f802e0b0-5004-419c-b45f-9ea4262109f6", "603187fb-58a3-4856-a141-6cc114f46def", "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8bd92cc7-e4cd-4a91-93fe-e478c576bbbf", 0, "7d00a5fd-621a-45f0-b649-868d138561e3", "hr@gmail.com", false, true, null, null, "HR@GMAIL.COM", "AQAAAAEAACcQAAAAEC8MVQ1+Jj5zUCNPWIy8UByaZJhnlq0W6ds1wZy4kOJiCrWYk7iHCCLuruxeIeYxTg==", null, false, "5644503c-38db-4598-984a-120d3ad152c3", false, "hr@gmail.com" },
                    { "db09f488-827c-4269-a36c-e6e59258e53e", 0, "ad775fd1-a070-4183-9364-82728fe1ab63", "user@gmail.com", false, true, null, null, "USER@GMAIL.COM", "AQAAAAEAACcQAAAAELHQEvpKKnsFg5onQtYIZZ38OuQV2Y09Xa6jNJaJNbIDATv1PdGXrL4xQPMlO3rAzA==", null, false, "3382e320-8344-455c-b730-fca4294762a3", false, "user@gmail.com" },
                    { "f1f8cfa8-dba2-479a-bbf3-6c1d8e7b9fc3", 0, "0acf7f0c-1fd8-48cd-8828-213f175d2e53", "admin@gmail.com", false, true, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELH/+QsiV5x/CyAnnEhQw7/ntjEYVE9Ijrw0tedAgFufdcSKodhEoE7Aox+Z04R6nQ==", null, false, "1b7f4fc3-2d7a-4b1c-aee5-e7ef6f42e893", false, "admin@gmail.com" }
                });
        }
    }
}
