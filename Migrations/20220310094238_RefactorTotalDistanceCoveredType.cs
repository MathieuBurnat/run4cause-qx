using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace run4cause.Migrations
{
    public partial class RefactorTotalDistanceCoveredType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "total_distance_covered",
                table: "users",
                type: "numeric(20,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
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
                column: "concurrency_stamp",
                value: "53c6ec2a-5f95-48ac-9e7d-d14bc49e0434");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrency_stamp",
                value: "25162299-3bb5-47ef-9dce-f385aca57bd1");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrency_stamp",
                value: "79dd01ef-2049-4fba-a90d-2513a208dfd3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "total_distance_covered",
                table: "users",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(20,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1,
                column: "concurrency_stamp",
                value: "69d1a191-f1e2-4613-9561-474749d92826");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrency_stamp",
                value: "bec7fff4-f946-40cd-bca5-a686f2087403");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrency_stamp",
                value: "e45977dd-9aac-4edf-8beb-235b7720e13f");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                column: "concurrency_stamp",
                value: "de03ec80-0f28-4eb2-b8e9-74028792c046");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                column: "concurrency_stamp",
                value: "df2cf391-73d9-4ac7-b6da-0d72cb600c8a");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 3,
                column: "concurrency_stamp",
                value: "8168d301-9f98-45a3-b079-f6dea76147c8");
        }
    }
}
