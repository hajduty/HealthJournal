using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthJournal.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11d38957-6326-42c1-b078-776728ace2d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adc4eced-93b4-4fcc-b7fb-baf9b8ce616d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64cc9ea2-2cf6-483a-9bbe-3e19eb730983", "e92aaf6a-e8b0-4f80-8a6a-b5da50e3ed59", "Admin", "ADMIN" },
                    { "6c322838-0498-4b45-8583-fdb82bda04c3", "feca97b0-39ef-442b-8872-b44b61ade035", "Patient", "PATIENT" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f6e2ab3c-0bc1-46e2-a01a-8843c0716592", "568b5737-5f24-4b3b-945d-38f6dd923fd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2cba4af4-88cb-40d0-af03-d9cb1352a2b6", "925d98e8-6f83-49f7-b5c1-5913539256f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9f78ef5-7a91-4f93-b46b-168a6bdf298f", "1296102b-2ab2-484b-aa42-c58071c9b5ee" });

            migrationBuilder.UpdateData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 14, 1, 9, 3, 374, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 14, 1, 9, 3, 374, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 10, 19, 1, 9, 3, 374, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 11, 11, 1, 9, 3, 374, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 12, 1, 9, 3, 374, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 11, 13, 1, 9, 3, 374, DateTimeKind.Local).AddTicks(8150));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64cc9ea2-2cf6-483a-9bbe-3e19eb730983");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c322838-0498-4b45-8583-fdb82bda04c3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11d38957-6326-42c1-b078-776728ace2d8", "578e2758-2aa7-43b1-a411-3324497a4435", "Admin", "ADMIN" },
                    { "adc4eced-93b4-4fcc-b7fb-baf9b8ce616d", "677971f9-8820-43ab-bdc6-a1439d0b399b", "Patient", "PATIENT" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ef27cb3-f804-4cf1-92a9-9b7417e75f56", "f4781912-d6e2-4c75-8e90-04482a8205fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ae99608-2e75-4f86-b226-08d03c7e14d5", "6031ec76-ec95-4c70-8d83-ceb224c788ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3e89747a-aa67-4ec2-aa21-135d4b6fc7a4", "c5847ddb-194e-48a0-a31d-959623dbbaf9" });

            migrationBuilder.UpdateData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 12, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 12, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 10, 17, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 11, 9, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 10, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 11, 11, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1530));
        }
    }
}
