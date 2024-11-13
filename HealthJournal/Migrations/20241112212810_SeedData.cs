using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthJournal.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "887ff93b-799d-46c9-8c8f-328605a00a59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1a9a43d-c1a2-4912-a96d-f9e33f4e9d82");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11d38957-6326-42c1-b078-776728ace2d8", "578e2758-2aa7-43b1-a411-3324497a4435", "Admin", "ADMIN" },
                    { "adc4eced-93b4-4fcc-b7fb-baf9b8ce616d", "677971f9-8820-43ab-bdc6-a1439d0b399b", "Patient", "PATIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user1", 0, "8ef27cb3-f804-4cf1-92a9-9b7417e75f56", "user1@example.com", false, null, null, false, null, null, null, null, null, false, "f4781912-d6e2-4c75-8e90-04482a8205fa", false, "user1@example.com" },
                    { "user2", 0, "5ae99608-2e75-4f86-b226-08d03c7e14d5", "user2@example.com", false, null, null, false, null, null, null, null, null, false, "6031ec76-ec95-4c70-8d83-ceb224c788ad", false, "user2@example.com" },
                    { "user3", 0, "3e89747a-aa67-4ec2-aa21-135d4b6fc7a4", "user3@example.com", false, null, null, false, null, null, null, null, null, false, "c5847ddb-194e-48a0-a31d-959623dbbaf9", false, "user3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Date", "Info", "ReceiverId", "SenderId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 9, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1492), "Follow-up appointment scheduled.", "user1", "user2" },
                    { 2, new DateTime(2024, 11, 10, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1527), "Please bring medical reports.", "user2", "user1" },
                    { 3, new DateTime(2024, 11, 11, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1530), "Lab results ready.", "user3", "user1" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, 45, "John", "Doe", "user1" },
                    { 2, 32, "Jane", "Smith", "user2" },
                    { 3, 28, "Tom", "Brown", "user3" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "ConditionName", "PatientId" },
                values: new object[,]
                {
                    { 1, "Hypertension", 1 },
                    { 2, "Diabetes", 2 },
                    { 3, "Asthma", 3 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Date", "PatientId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1569), 1 },
                    { 2, new DateTime(2024, 9, 12, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1572), 2 },
                    { 3, new DateTime(2024, 10, 17, 22, 28, 10, 93, DateTimeKind.Local).AddTicks(1573), 3 }
                });

            migrationBuilder.InsertData(
                table: "Observations",
                columns: new[] { "Id", "EncounterId", "PatientId", "Type", "Value" },
                values: new object[] { 1, 1, 1, "Blood Pressure", 130.5 });

            migrationBuilder.InsertData(
                table: "Observations",
                columns: new[] { "Id", "EncounterId", "PatientId", "Type", "Value" },
                values: new object[] { 2, 2, 2, "Blood Sugar", 7.5 });

            migrationBuilder.InsertData(
                table: "Observations",
                columns: new[] { "Id", "EncounterId", "PatientId", "Type", "Value" },
                values: new object[] { 3, 3, 3, "Peak Flow", 350.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11d38957-6326-42c1-b078-776728ace2d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adc4eced-93b4-4fcc-b7fb-baf9b8ce616d");

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "887ff93b-799d-46c9-8c8f-328605a00a59", "78517ce4-224f-46b3-8734-b98bea39a7e7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c1a9a43d-c1a2-4912-a96d-f9e33f4e9d82", "efb690cd-f038-49f6-b14c-aed8609cff8d", "Patient", "PATIENT" });
        }
    }
}
