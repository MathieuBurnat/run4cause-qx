using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace run4cause.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "total_distance_covered",
                table: "users",
                type: "numeric(20,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(320)",
                oldMaxLength: 320);

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
                columns: new[] { "concurrency_stamp", "total_distance_covered" },
                values: new object[] { "29684717-b274-4c92-94d0-275810e21891", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "concurrency_stamp", "total_distance_covered" },
                values: new object[] { "6b7773bd-8dc9-42e7-87ee-c678fb50c8d7", null });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "concurrency_stamp", "total_distance_covered" },
                values: new object[] { "83ed0c48-8ac9-4188-b340-d7cdfda0cf59", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "total_distance_covered",
                table: "users",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(decimal),
                oldType: "numeric(20,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "users",
                type: "character varying(320)",
                maxLength: 320,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "concurrency_stamp",
                value: "93418617-a171-4821-ab8c-3a5acfff102c");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrency_stamp",
                value: "d9f59396-0ac6-4f04-b76f-4fdf781dcb8e");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrency_stamp",
                value: "fefe6c90-f5d0-4b65-ade2-74a61e9a5e65");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "concurrency_stamp", "total_distance_covered" },
                values: new object[] { "53c6ec2a-5f95-48ac-9e7d-d14bc49e0434", 0f });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "concurrency_stamp", "total_distance_covered" },
                values: new object[] { "25162299-3bb5-47ef-9dce-f385aca57bd1", 0f });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "concurrency_stamp", "total_distance_covered" },
                values: new object[] { "79dd01ef-2049-4fba-a90d-2513a208dfd3", 0f });
        }
    }
}
