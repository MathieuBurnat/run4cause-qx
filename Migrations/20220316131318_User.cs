using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace run4cause.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(16)",
                oldMaxLength: 16,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "concurrency_stamp",
                value: "56d0c4e8-ecc3-47b0-b827-62aca08109cf");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrency_stamp",
                value: "2d783ff2-47a7-47d2-89c3-a78e9dc6c17f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrency_stamp",
                value: "d012dbc3-1181-4e2c-9120-a5c754c7e7f8");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "concurrency_stamp",
                value: "2c599ca1-a503-4e41-9de0-da96890edc88");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrency_stamp",
                value: "cb8273f1-56b4-4d25-9bb0-079710da62cc");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrency_stamp",
                value: "867081b4-a787-4391-9330-d4ba3df3d285");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "users",
                type: "character varying(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "concurrency_stamp",
                value: "8d2cefb3-88aa-4462-90f7-e2915f72bb96");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrency_stamp",
                value: "408b981f-6eb4-411e-a5a3-f3ffce93c10a");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrency_stamp",
                value: "711e4a85-d9d4-40f9-b745-af3004954a2a");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "concurrency_stamp",
                value: "29684717-b274-4c92-94d0-275810e21891");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrency_stamp",
                value: "6b7773bd-8dc9-42e7-87ee-c678fb50c8d7");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrency_stamp",
                value: "83ed0c48-8ac9-4188-b340-d7cdfda0cf59");
        }
    }
}
