using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthJournal.Migrations
{
    public partial class SeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3caf46f3-af4b-4372-9548-a3e03e79c2c9", "65c34ce9-e13b-4059-beb2-79f4624ccb59", "Patient", "PATIENT" },
                    { "55641d84-5c0c-4e14-b7ca-c74dc5793ca0", "8634ae6f-1595-4fb7-9615-92f2323b2501", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9cfed4b-86a6-4bce-b9a6-a19978141985", "3530fac4-8f8b-4384-9951-016b52300d99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f265da3-8ec6-4024-b586-81f8031d19cd", "25e0d943-1610-41ae-b2f4-e56b3d97fb8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91f29871-80b9-4fb9-8e73-4347b4983db4", "76003995-4828-42a3-9280-a8a894deb888" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user10", 0, "c5f622c6-f744-4108-be55-17e36eb1ddeb", "user10@example.com", false, null, null, false, null, null, null, null, null, false, "4890fa83-215d-432f-a3f1-2b8bc3bda774", false, "user10@example.com" },
                    { "user100", 0, "83438100-d30a-4c89-b3ca-ed5f23192e01", "user100@example.com", false, null, null, false, null, null, null, null, null, false, "efe65a8d-cda1-442e-8b39-7709075ae685", false, "user100@example.com" },
                    { "user11", 0, "ea50c2e2-909f-47ab-ad8b-57aadac18c2a", "user11@example.com", false, null, null, false, null, null, null, null, null, false, "7dd4411b-90a9-41f6-a200-c96616164809", false, "user11@example.com" },
                    { "user12", 0, "d1c311c3-0b8a-46d2-9fe9-ce17033ed203", "user12@example.com", false, null, null, false, null, null, null, null, null, false, "b380e136-1514-49e1-91c9-e7068ebf83e7", false, "user12@example.com" },
                    { "user13", 0, "faeb2cde-594e-4019-8247-922ef716634f", "user13@example.com", false, null, null, false, null, null, null, null, null, false, "db3d3907-a3b4-4d8e-a4b9-134402ec23d3", false, "user13@example.com" },
                    { "user14", 0, "59d54d2a-a194-459d-b36d-763b6f95bf7d", "user14@example.com", false, null, null, false, null, null, null, null, null, false, "81fcd9ba-f694-4bc0-a9ca-29bf6e8ca071", false, "user14@example.com" },
                    { "user15", 0, "5e6a9649-27ac-4c85-9454-cb65d0c0e143", "user15@example.com", false, null, null, false, null, null, null, null, null, false, "c2266803-9f1a-4ab0-a1bd-6d658cd9b0c0", false, "user15@example.com" },
                    { "user16", 0, "633f965e-9ac1-4e5e-b19f-9fe49429f1e3", "user16@example.com", false, null, null, false, null, null, null, null, null, false, "8ee88bc8-81a4-44e9-859a-d818aed2f036", false, "user16@example.com" },
                    { "user17", 0, "7f051992-8ab2-4589-a9c2-06ab6f692caa", "user17@example.com", false, null, null, false, null, null, null, null, null, false, "090cc26b-ec7a-4bfb-9a46-c29d857c35f3", false, "user17@example.com" },
                    { "user18", 0, "a92cbdd1-f8e2-47ed-985b-2e4d136622e2", "user18@example.com", false, null, null, false, null, null, null, null, null, false, "efb07a4b-7329-4c30-85af-38883260ff56", false, "user18@example.com" },
                    { "user19", 0, "d3a5dddb-2a2d-4f5a-a154-91afb29bb8bb", "user19@example.com", false, null, null, false, null, null, null, null, null, false, "221077d7-03f2-4d93-8bde-57d2459686c7", false, "user19@example.com" },
                    { "user20", 0, "8964e0c4-f486-4a48-8ef2-8e70093364a3", "user20@example.com", false, null, null, false, null, null, null, null, null, false, "9d73164b-2bd5-4a7e-b5e9-e01f9d0e0a5c", false, "user20@example.com" },
                    { "user21", 0, "1a94e7b3-d789-4a5f-8aad-1df3e9c91faf", "user21@example.com", false, null, null, false, null, null, null, null, null, false, "99631721-6d04-4889-8e6a-853e9b297a3a", false, "user21@example.com" },
                    { "user22", 0, "54a30d00-64d3-4da4-91f0-a20817095454", "user22@example.com", false, null, null, false, null, null, null, null, null, false, "83efcbeb-a84c-4920-962e-7746439b9182", false, "user22@example.com" },
                    { "user23", 0, "e69b7d83-0f22-47f2-939a-2975aa758b92", "user23@example.com", false, null, null, false, null, null, null, null, null, false, "bb50ccc5-baa3-4076-9b01-788a6b50c7d7", false, "user23@example.com" },
                    { "user24", 0, "ee6afec9-0fee-4b8b-abb6-71ee5785609e", "user24@example.com", false, null, null, false, null, null, null, null, null, false, "83bda00c-b4d5-4553-a760-9bbd0d1c8a18", false, "user24@example.com" },
                    { "user25", 0, "767f54eb-0b38-4ac5-b675-9e2850a20935", "user25@example.com", false, null, null, false, null, null, null, null, null, false, "92129e0b-c80d-4e03-a40c-40058a2c5152", false, "user25@example.com" },
                    { "user26", 0, "caf52898-387c-4944-a2f0-d89bd350ee2b", "user26@example.com", false, null, null, false, null, null, null, null, null, false, "cc4a0e34-bc32-459f-b32b-49edf4e37fd5", false, "user26@example.com" },
                    { "user27", 0, "0c1fdfcb-0fe1-4c44-a366-f0d15d906277", "user27@example.com", false, null, null, false, null, null, null, null, null, false, "66d2e8db-6d66-44fd-b6e8-dad65fe21bdb", false, "user27@example.com" },
                    { "user28", 0, "801e4c72-94b3-48d4-8d43-5d90b570fbd2", "user28@example.com", false, null, null, false, null, null, null, null, null, false, "dba7fcd8-8e14-4af8-84c3-f36826054055", false, "user28@example.com" },
                    { "user29", 0, "913c3cb3-a791-4141-8012-189136d3c7ee", "user29@example.com", false, null, null, false, null, null, null, null, null, false, "e1210449-acbc-431f-8573-a03ee36a8c91", false, "user29@example.com" },
                    { "user30", 0, "6cab7dea-70e4-450c-b267-f9a8d8c4f437", "user30@example.com", false, null, null, false, null, null, null, null, null, false, "6b9f2e03-e2a9-4e7e-803f-c669d9ccae33", false, "user30@example.com" },
                    { "user31", 0, "019fc7c2-e5a4-490b-b331-f8e4657ef8e0", "user31@example.com", false, null, null, false, null, null, null, null, null, false, "a3fc9da9-192e-467a-af6a-26eb8550bd70", false, "user31@example.com" },
                    { "user32", 0, "93486717-6284-4cb1-95ff-aeeaf6c114a3", "user32@example.com", false, null, null, false, null, null, null, null, null, false, "71a1699e-edf7-45ed-9cdd-6beec8d6a96c", false, "user32@example.com" },
                    { "user33", 0, "4be17ac8-5e7b-4187-9660-b7d90a684f7e", "user33@example.com", false, null, null, false, null, null, null, null, null, false, "5a1994b4-77d6-4ebb-a85c-b51930de4786", false, "user33@example.com" },
                    { "user34", 0, "71accb0d-1c14-41e9-914c-ba189043eb71", "user34@example.com", false, null, null, false, null, null, null, null, null, false, "48b2bf18-76b4-4948-9035-fc2757a28234", false, "user34@example.com" },
                    { "user35", 0, "4adc1c9b-7076-4085-b389-52ccacbc0f40", "user35@example.com", false, null, null, false, null, null, null, null, null, false, "aeb3a27d-63ed-4544-bf2d-1cc954e31137", false, "user35@example.com" },
                    { "user36", 0, "a7bac12c-7843-4fa9-abfc-27836a91b27e", "user36@example.com", false, null, null, false, null, null, null, null, null, false, "4166192b-927c-4f0b-ab23-41c1e9da3169", false, "user36@example.com" },
                    { "user37", 0, "0616b084-f57d-4ca4-8afc-c616bac4bd3a", "user37@example.com", false, null, null, false, null, null, null, null, null, false, "9f9cc703-edd9-4640-860e-1ddb121f339b", false, "user37@example.com" },
                    { "user38", 0, "7e6b7fae-f4e6-4c91-9db2-0e494a4a7d42", "user38@example.com", false, null, null, false, null, null, null, null, null, false, "eed85412-4ca8-48de-8909-966986345530", false, "user38@example.com" },
                    { "user39", 0, "40958586-1c88-4629-9257-48a977710553", "user39@example.com", false, null, null, false, null, null, null, null, null, false, "77ddf189-a542-457f-9e19-cfb958a73dec", false, "user39@example.com" },
                    { "user4", 0, "8dee3387-8aae-4459-92b4-a61aa8974fa5", "user4@example.com", false, null, null, false, null, null, null, null, null, false, "16bee1af-02d8-48b7-bb70-be5a1db692f4", false, "user4@example.com" },
                    { "user40", 0, "11c83665-06d3-4389-99cd-849ea8559908", "user40@example.com", false, null, null, false, null, null, null, null, null, false, "1bd188b8-ad5d-4277-a286-c76a68da0cfc", false, "user40@example.com" },
                    { "user41", 0, "295cd1a1-125a-4e70-b7f9-04a89d7f4e50", "user41@example.com", false, null, null, false, null, null, null, null, null, false, "06a09d58-d5b2-405c-8f61-8c5e836ce001", false, "user41@example.com" },
                    { "user42", 0, "92e479ef-2daa-469f-9dae-58829aac25d9", "user42@example.com", false, null, null, false, null, null, null, null, null, false, "1a993ef6-27ab-4e21-ba68-ac8620ab2f6e", false, "user42@example.com" },
                    { "user43", 0, "98325536-d8cd-4d04-99ee-9282e1154b95", "user43@example.com", false, null, null, false, null, null, null, null, null, false, "39cdc28f-ae14-41e9-bc6f-205cf1bf40e8", false, "user43@example.com" },
                    { "user44", 0, "cfe466d8-313b-445c-a80e-780d55020e24", "user44@example.com", false, null, null, false, null, null, null, null, null, false, "65d9c581-da2d-42ca-80a9-52f8e69a81bc", false, "user44@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user45", 0, "fdd1fae4-a618-4268-ba1e-097198ee7544", "user45@example.com", false, null, null, false, null, null, null, null, null, false, "2eed9b6f-e687-477f-95e2-3ff335fca8d7", false, "user45@example.com" },
                    { "user46", 0, "2816a830-8ba5-40e9-9829-974b15aa3e0e", "user46@example.com", false, null, null, false, null, null, null, null, null, false, "cc583ea6-00af-4c8b-b14e-8497682438b6", false, "user46@example.com" },
                    { "user47", 0, "fb2d67d2-10ca-4c74-b1c4-0ba7be991458", "user47@example.com", false, null, null, false, null, null, null, null, null, false, "134cfb0b-ee04-4d37-9d1a-5921b5d6ef7c", false, "user47@example.com" },
                    { "user48", 0, "b386cd6d-b5d5-4957-ad57-380ae995e2f2", "user48@example.com", false, null, null, false, null, null, null, null, null, false, "a3420334-c899-4f11-ad84-1ed79add296e", false, "user48@example.com" },
                    { "user49", 0, "b0497637-d7c6-4d5f-a817-1cec10a1ff6e", "user49@example.com", false, null, null, false, null, null, null, null, null, false, "b8e79d86-ab03-4181-9cf2-1237585c80a9", false, "user49@example.com" },
                    { "user5", 0, "250cb28e-bd5f-4418-b12b-c164caa295b7", "user5@example.com", false, null, null, false, null, null, null, null, null, false, "69f502fa-760e-463f-92c0-92e986fd834b", false, "user5@example.com" },
                    { "user50", 0, "3f1d98b7-e8af-4ddf-a629-60b35d909cab", "user50@example.com", false, null, null, false, null, null, null, null, null, false, "63e54473-7919-41b3-9e3b-f469ba4d7c18", false, "user50@example.com" },
                    { "user51", 0, "732a04d4-c819-40cb-9a7a-b1bd6578b128", "user51@example.com", false, null, null, false, null, null, null, null, null, false, "6188bdbc-1f66-4786-8dd4-d25a585f16bf", false, "user51@example.com" },
                    { "user52", 0, "a39ed18a-842b-41c3-9825-15943a8d37d0", "user52@example.com", false, null, null, false, null, null, null, null, null, false, "7c0a62cb-0e96-4393-a3d9-2718790f4124", false, "user52@example.com" },
                    { "user53", 0, "b5b7fc71-2493-4eb6-a9eb-df3958f61305", "user53@example.com", false, null, null, false, null, null, null, null, null, false, "fc76c175-ba18-4df4-ad40-a9a4e091452d", false, "user53@example.com" },
                    { "user54", 0, "9e222a56-0c13-4ab9-8a5d-09ef3090b94a", "user54@example.com", false, null, null, false, null, null, null, null, null, false, "cbad2afe-a056-4dad-85a7-aaa030410e8a", false, "user54@example.com" },
                    { "user55", 0, "97e4f147-d6a7-4204-bee4-bb9748269401", "user55@example.com", false, null, null, false, null, null, null, null, null, false, "2cc6d99c-1866-46b9-b51c-5f49f412b5f4", false, "user55@example.com" },
                    { "user56", 0, "75f461e1-3829-44a0-8dcb-80f353a6bac6", "user56@example.com", false, null, null, false, null, null, null, null, null, false, "36ffd009-0075-4f1d-b3d4-ebf94c9c522a", false, "user56@example.com" },
                    { "user57", 0, "ae4682ee-7e06-45cb-a3ef-84831bf26e10", "user57@example.com", false, null, null, false, null, null, null, null, null, false, "de894e9b-3096-42fd-bbaa-dfc14948ca94", false, "user57@example.com" },
                    { "user58", 0, "3563b560-93d3-4a24-a280-47e82a734ed7", "user58@example.com", false, null, null, false, null, null, null, null, null, false, "bf6c0fed-717c-4429-87aa-21d9362d9595", false, "user58@example.com" },
                    { "user59", 0, "3c7f4e0c-1a13-41ad-af4b-33a922af83f1", "user59@example.com", false, null, null, false, null, null, null, null, null, false, "37b7d11d-7a4b-4924-b917-a9423d20bd32", false, "user59@example.com" },
                    { "user6", 0, "e6b9dea0-0616-4d12-bf35-964e9b31737d", "user6@example.com", false, null, null, false, null, null, null, null, null, false, "3304eb36-38fd-4641-bc3d-e8dbd8c0ca0f", false, "user6@example.com" },
                    { "user60", 0, "9864e8c8-6702-43cc-8aa2-495d86706a2e", "user60@example.com", false, null, null, false, null, null, null, null, null, false, "9e30f57f-3d8b-435d-9053-c929012b6ac7", false, "user60@example.com" },
                    { "user61", 0, "5f634a5f-92a8-4008-a17a-b3827dec576e", "user61@example.com", false, null, null, false, null, null, null, null, null, false, "7aa4d54f-2e6b-4a2c-8325-78a776c5bc5d", false, "user61@example.com" },
                    { "user62", 0, "6f51a4a0-99e4-4a53-a2b8-82f69b72f42e", "user62@example.com", false, null, null, false, null, null, null, null, null, false, "dcfb0a82-30c5-4dec-97c1-80cb871bea71", false, "user62@example.com" },
                    { "user63", 0, "4f8b04ab-4d5b-46b6-89d9-c226f76e5aa7", "user63@example.com", false, null, null, false, null, null, null, null, null, false, "9a813780-c9f9-4ab7-8388-16599901818b", false, "user63@example.com" },
                    { "user64", 0, "babe8d78-da37-4fed-94d2-583155d1d776", "user64@example.com", false, null, null, false, null, null, null, null, null, false, "9e76909d-f883-4181-a620-eeba6c025b54", false, "user64@example.com" },
                    { "user65", 0, "ce367f76-5b88-4938-8b7d-102519f4ab1c", "user65@example.com", false, null, null, false, null, null, null, null, null, false, "65e95e04-6d1b-4c3c-91e7-9f205fcfe563", false, "user65@example.com" },
                    { "user66", 0, "b1138422-dbf0-48b6-85a2-5d37f7c4f7a7", "user66@example.com", false, null, null, false, null, null, null, null, null, false, "4c21922c-5d13-4223-8b87-536805bdc72c", false, "user66@example.com" },
                    { "user67", 0, "d7164225-d8f5-414f-a714-fb54f275ac05", "user67@example.com", false, null, null, false, null, null, null, null, null, false, "36e384b0-7fd4-428b-b942-a45dc9ea9db2", false, "user67@example.com" },
                    { "user68", 0, "0e98b522-468b-4cb8-97ed-d660a0321482", "user68@example.com", false, null, null, false, null, null, null, null, null, false, "b403bf71-444a-4f6a-abb3-a74eea2b3f7a", false, "user68@example.com" },
                    { "user69", 0, "fee724fa-6c82-4ec4-be53-0ebf86930dc0", "user69@example.com", false, null, null, false, null, null, null, null, null, false, "d4f4b501-e9cb-48fa-b9ba-f5fe42f20a31", false, "user69@example.com" },
                    { "user7", 0, "5c2c58eb-5e77-417c-8e00-1cc83d244a99", "user7@example.com", false, null, null, false, null, null, null, null, null, false, "3e9722be-71be-4535-90e1-ef2a3ff93572", false, "user7@example.com" },
                    { "user70", 0, "1a2f6f1b-7437-4f79-9b1f-a441d2642610", "user70@example.com", false, null, null, false, null, null, null, null, null, false, "bc83d6ea-145d-4cb0-b36f-32c943ebe0ff", false, "user70@example.com" },
                    { "user71", 0, "60ce03d6-e9d8-4e36-b9ca-6d157a542f7c", "user71@example.com", false, null, null, false, null, null, null, null, null, false, "a35dd40e-db42-4c3d-9d10-cd659e4ff420", false, "user71@example.com" },
                    { "user72", 0, "9b552c3f-671e-4841-8edf-bb72b2813875", "user72@example.com", false, null, null, false, null, null, null, null, null, false, "cdfe6d8c-5d74-45f7-a073-e4429d61929d", false, "user72@example.com" },
                    { "user73", 0, "05dc9e20-2546-4655-93c2-055be4ad7d40", "user73@example.com", false, null, null, false, null, null, null, null, null, false, "f96dc9bd-dd99-48a5-aa05-b5834600582c", false, "user73@example.com" },
                    { "user74", 0, "f75af05d-4ad8-417a-a5d9-1c36edf9ed8a", "user74@example.com", false, null, null, false, null, null, null, null, null, false, "5cc9b529-b239-455f-8316-7168b5922f94", false, "user74@example.com" },
                    { "user75", 0, "b38acdc3-119f-4124-a967-fc7659319d63", "user75@example.com", false, null, null, false, null, null, null, null, null, false, "673872db-926c-4cb6-989d-b7b23fccb8ee", false, "user75@example.com" },
                    { "user76", 0, "6315766d-0c06-4f9c-b781-3478e63a4408", "user76@example.com", false, null, null, false, null, null, null, null, null, false, "17287a17-21b9-42fa-96af-44685aa07040", false, "user76@example.com" },
                    { "user77", 0, "7140d605-e4a2-48af-a929-dfb018991ea2", "user77@example.com", false, null, null, false, null, null, null, null, null, false, "dbb0dc73-7879-4c4e-9001-56dfd58cc8c8", false, "user77@example.com" },
                    { "user78", 0, "0bbc19b9-f867-4b94-bf30-3ce5bd86bfad", "user78@example.com", false, null, null, false, null, null, null, null, null, false, "789adae2-648e-4b20-b103-cadc040743d1", false, "user78@example.com" },
                    { "user79", 0, "8654e46f-7e19-4665-a3f6-f01a058e3209", "user79@example.com", false, null, null, false, null, null, null, null, null, false, "eacaa0fc-cf4a-4424-b829-fce205728290", false, "user79@example.com" },
                    { "user8", 0, "b7de795a-2787-4db5-b3a7-2cb2668f25ab", "user8@example.com", false, null, null, false, null, null, null, null, null, false, "a836ec5c-ec29-4d4a-b45d-a41ebf7f0276", false, "user8@example.com" },
                    { "user80", 0, "cc55794c-083a-42e5-a876-512725bae95f", "user80@example.com", false, null, null, false, null, null, null, null, null, false, "21bc9dbb-f794-49d0-964d-e3ce46ff5b46", false, "user80@example.com" },
                    { "user81", 0, "ef64c8a3-bea9-494d-8355-3837c0f7dfdf", "user81@example.com", false, null, null, false, null, null, null, null, null, false, "5eda8034-bf2f-4a47-8291-15168ee4a11e", false, "user81@example.com" },
                    { "user82", 0, "6f359d63-5de1-4f0b-af0b-931fcb35c2c3", "user82@example.com", false, null, null, false, null, null, null, null, null, false, "4f2f7452-59b4-40c7-adb3-236281feaaaa", false, "user82@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user83", 0, "7ed14b29-134b-46c2-85ce-c6a8f5827c24", "user83@example.com", false, null, null, false, null, null, null, null, null, false, "576e10f6-f518-4440-957b-92afbacfc89b", false, "user83@example.com" },
                    { "user84", 0, "5338c82d-bc01-4e04-bb83-12f93444f498", "user84@example.com", false, null, null, false, null, null, null, null, null, false, "09b407cc-3097-45fd-9627-57f74ebbb11c", false, "user84@example.com" },
                    { "user85", 0, "3e19f049-b887-4f0b-b3d8-86a033d3e09c", "user85@example.com", false, null, null, false, null, null, null, null, null, false, "599eb8a6-95d7-4aa1-9c92-148e020484e8", false, "user85@example.com" },
                    { "user86", 0, "1e2a743c-5cf6-4000-92f7-5a6e439baa8e", "user86@example.com", false, null, null, false, null, null, null, null, null, false, "111afa72-9178-44f3-b09e-32eef8d84ddb", false, "user86@example.com" },
                    { "user87", 0, "549b7532-0ce5-41f3-9b21-25d961596499", "user87@example.com", false, null, null, false, null, null, null, null, null, false, "14221e29-9c53-4547-8ac3-e16600a2dcd7", false, "user87@example.com" },
                    { "user88", 0, "147c3ff9-e18c-4dc2-b420-2585ec62574c", "user88@example.com", false, null, null, false, null, null, null, null, null, false, "05c4850f-dfbe-4870-968f-780287e40c17", false, "user88@example.com" },
                    { "user89", 0, "2257b306-f938-4d3a-8049-64170b969d1a", "user89@example.com", false, null, null, false, null, null, null, null, null, false, "66433c4b-e39d-406e-978d-9b4556dd4bdf", false, "user89@example.com" },
                    { "user9", 0, "2389fd74-3ef3-4438-81d8-d50d7e24e12c", "user9@example.com", false, null, null, false, null, null, null, null, null, false, "b4e1d2d1-5679-4a62-88db-97883d502def", false, "user9@example.com" },
                    { "user90", 0, "463ccc9a-23d8-4e3b-953c-5c233a296232", "user90@example.com", false, null, null, false, null, null, null, null, null, false, "349da025-23ed-45d8-93ec-de3deb687742", false, "user90@example.com" },
                    { "user91", 0, "6cae7b8e-fe9d-4550-93a0-5f6920a028c3", "user91@example.com", false, null, null, false, null, null, null, null, null, false, "f89aba68-5ebd-4deb-94ea-546f0491ea86", false, "user91@example.com" },
                    { "user92", 0, "546f923f-9a6f-4eb6-ae35-0b2aaba97dd5", "user92@example.com", false, null, null, false, null, null, null, null, null, false, "7f2bb893-3533-4221-9e8e-2ae49d415936", false, "user92@example.com" },
                    { "user93", 0, "6c21515b-a1ee-4c86-b2eb-22f91dc501af", "user93@example.com", false, null, null, false, null, null, null, null, null, false, "88a7d27c-38e5-41b7-a3f9-f5425982cfcc", false, "user93@example.com" },
                    { "user94", 0, "47089d2c-88f8-48eb-9025-38769bce0ac6", "user94@example.com", false, null, null, false, null, null, null, null, null, false, "4ab434f6-75fb-458a-9b04-a98eb58995db", false, "user94@example.com" },
                    { "user95", 0, "efb48567-ef44-4c79-bfdd-73410e6fbc36", "user95@example.com", false, null, null, false, null, null, null, null, null, false, "46e94219-df1d-4e7b-b764-cb2041559f30", false, "user95@example.com" },
                    { "user96", 0, "c173ea6c-400d-41fe-ad74-ef154c7a4328", "user96@example.com", false, null, null, false, null, null, null, null, null, false, "bd04c92b-8e50-419b-9baa-4c89f895337f", false, "user96@example.com" },
                    { "user97", 0, "94d5bc1a-eeb3-4cb5-aae3-2288467844a4", "user97@example.com", false, null, null, false, null, null, null, null, null, false, "9ba5fffc-69e2-4eb7-8a7c-e37b399b77c4", false, "user97@example.com" },
                    { "user98", 0, "51e51dd1-7cf3-4fe0-b6f9-43b485db1e84", "user98@example.com", false, null, null, false, null, null, null, null, null, false, "3531fba0-a418-4ab2-93d8-020dde231e15", false, "user98@example.com" },
                    { "user99", 0, "72e55979-a7df-4143-a1cc-25c80d2f3767", "user99@example.com", false, null, null, false, null, null, null, null, null, false, "4f204279-23a1-4962-a549-975eb7b14ca8", false, "user99@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConditionName",
                value: "Condition 1");

            migrationBuilder.UpdateData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConditionName",
                value: "Condition 2");

            migrationBuilder.UpdateData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConditionName",
                value: "Condition 3");

            migrationBuilder.UpdateData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 10, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 9, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 8, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Info", "ReceiverId", "SenderId" },
                values: new object[] { new DateTime(2024, 11, 20, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9045), "Message 1 info", "user2", "user3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Info", "ReceiverId" },
                values: new object[] { new DateTime(2024, 11, 19, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9157), "Message 2 info", "user3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Info", "ReceiverId", "SenderId" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9239), "Message 3 info", "user1", "user2" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Date", "Info", "ReceiverId", "SenderId" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 11, 17, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9289), "Message 4 info", "user2", "user3" },
                    { 5, new DateTime(2024, 11, 16, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9341), "Message 5 info", "user3", "user1" },
                    { 6, new DateTime(2024, 11, 15, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9420), "Message 6 info", "user1", "user2" },
                    { 7, new DateTime(2024, 11, 14, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9470), "Message 7 info", "user2", "user3" },
                    { 8, new DateTime(2024, 11, 13, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9518), "Message 8 info", "user3", "user1" },
                    { 9, new DateTime(2024, 11, 12, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9607), "Message 9 info", "user1", "user2" },
                    { 10, new DateTime(2024, 11, 11, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9661), "Message 10 info", "user2", "user3" },
                    { 11, new DateTime(2024, 11, 10, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9707), "Message 11 info", "user3", "user1" },
                    { 12, new DateTime(2024, 11, 9, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9777), "Message 12 info", "user1", "user2" },
                    { 13, new DateTime(2024, 11, 8, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9825), "Message 13 info", "user2", "user3" },
                    { 14, new DateTime(2024, 11, 7, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9870), "Message 14 info", "user3", "user1" },
                    { 15, new DateTime(2024, 11, 6, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9944), "Message 15 info", "user1", "user2" },
                    { 16, new DateTime(2024, 11, 5, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9992), "Message 16 info", "user2", "user3" },
                    { 17, new DateTime(2024, 11, 4, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(39), "Message 17 info", "user3", "user1" },
                    { 18, new DateTime(2024, 11, 3, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(114), "Message 18 info", "user1", "user2" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Date", "Info", "ReceiverId", "SenderId" },
                values: new object[,]
                {
                    { 19, new DateTime(2024, 11, 2, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(161), "Message 19 info", "user2", "user3" },
                    { 20, new DateTime(2024, 11, 1, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(206), "Message 20 info", "user3", "user1" },
                    { 21, new DateTime(2024, 10, 31, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(275), "Message 21 info", "user1", "user2" },
                    { 22, new DateTime(2024, 10, 30, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(323), "Message 22 info", "user2", "user3" },
                    { 23, new DateTime(2024, 10, 29, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(369), "Message 23 info", "user3", "user1" },
                    { 24, new DateTime(2024, 10, 28, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(439), "Message 24 info", "user1", "user2" },
                    { 25, new DateTime(2024, 10, 27, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(485), "Message 25 info", "user2", "user3" },
                    { 26, new DateTime(2024, 10, 26, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(533), "Message 26 info", "user3", "user1" },
                    { 27, new DateTime(2024, 10, 25, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(601), "Message 27 info", "user1", "user2" },
                    { 28, new DateTime(2024, 10, 24, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(648), "Message 28 info", "user2", "user3" },
                    { 29, new DateTime(2024, 10, 23, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(698), "Message 29 info", "user3", "user1" },
                    { 30, new DateTime(2024, 10, 22, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(770), "Message 30 info", "user1", "user2" },
                    { 31, new DateTime(2024, 10, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(819), "Message 31 info", "user2", "user3" },
                    { 32, new DateTime(2024, 10, 20, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(867), "Message 32 info", "user3", "user1" },
                    { 33, new DateTime(2024, 10, 19, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(946), "Message 33 info", "user1", "user2" },
                    { 34, new DateTime(2024, 10, 18, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1000), "Message 34 info", "user2", "user3" },
                    { 35, new DateTime(2024, 10, 17, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1075), "Message 35 info", "user3", "user1" },
                    { 36, new DateTime(2024, 10, 16, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1121), "Message 36 info", "user1", "user2" },
                    { 37, new DateTime(2024, 10, 15, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1169), "Message 37 info", "user2", "user3" },
                    { 38, new DateTime(2024, 10, 14, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1238), "Message 38 info", "user3", "user1" },
                    { 39, new DateTime(2024, 10, 13, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1286), "Message 39 info", "user1", "user2" },
                    { 40, new DateTime(2024, 10, 12, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1332), "Message 40 info", "user2", "user3" },
                    { 41, new DateTime(2024, 10, 11, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1399), "Message 41 info", "user3", "user1" },
                    { 42, new DateTime(2024, 10, 10, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1449), "Message 42 info", "user1", "user2" },
                    { 43, new DateTime(2024, 10, 9, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1495), "Message 43 info", "user2", "user3" },
                    { 44, new DateTime(2024, 10, 8, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1563), "Message 44 info", "user3", "user1" },
                    { 45, new DateTime(2024, 10, 7, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1611), "Message 45 info", "user1", "user2" },
                    { 46, new DateTime(2024, 10, 6, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1655), "Message 46 info", "user2", "user3" },
                    { 47, new DateTime(2024, 10, 5, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1703), "Message 47 info", "user3", "user1" },
                    { 48, new DateTime(2024, 10, 4, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1773), "Message 48 info", "user1", "user2" },
                    { 49, new DateTime(2024, 10, 3, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1818), "Message 49 info", "user2", "user3" },
                    { 50, new DateTime(2024, 10, 2, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1866), "Message 50 info", "user3", "user1" },
                    { 51, new DateTime(2024, 10, 1, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1937), "Message 51 info", "user1", "user2" },
                    { 52, new DateTime(2024, 9, 30, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1983), "Message 52 info", "user2", "user3" },
                    { 53, new DateTime(2024, 9, 29, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2030), "Message 53 info", "user3", "user1" },
                    { 54, new DateTime(2024, 9, 28, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2100), "Message 54 info", "user1", "user2" },
                    { 55, new DateTime(2024, 9, 27, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2147), "Message 55 info", "user2", "user3" },
                    { 56, new DateTime(2024, 9, 26, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2194), "Message 56 info", "user3", "user1" },
                    { 57, new DateTime(2024, 9, 25, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2273), "Message 57 info", "user1", "user2" },
                    { 58, new DateTime(2024, 9, 24, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2320), "Message 58 info", "user2", "user3" },
                    { 59, new DateTime(2024, 9, 23, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2364), "Message 59 info", "user3", "user1" },
                    { 60, new DateTime(2024, 9, 22, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2433), "Message 60 info", "user1", "user2" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Date", "Info", "ReceiverId", "SenderId" },
                values: new object[,]
                {
                    { 61, new DateTime(2024, 9, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2483), "Message 61 info", "user2", "user3" },
                    { 62, new DateTime(2024, 9, 20, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2530), "Message 62 info", "user3", "user1" },
                    { 63, new DateTime(2024, 9, 19, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2601), "Message 63 info", "user1", "user2" },
                    { 64, new DateTime(2024, 9, 18, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2646), "Message 64 info", "user2", "user3" },
                    { 65, new DateTime(2024, 9, 17, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2691), "Message 65 info", "user3", "user1" },
                    { 66, new DateTime(2024, 9, 16, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2765), "Message 66 info", "user1", "user2" },
                    { 67, new DateTime(2024, 9, 15, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2837), "Message 67 info", "user2", "user3" },
                    { 68, new DateTime(2024, 9, 14, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2885), "Message 68 info", "user3", "user1" },
                    { 69, new DateTime(2024, 9, 13, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2934), "Message 69 info", "user1", "user2" },
                    { 70, new DateTime(2024, 9, 12, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3005), "Message 70 info", "user2", "user3" },
                    { 71, new DateTime(2024, 9, 11, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3053), "Message 71 info", "user3", "user1" },
                    { 72, new DateTime(2024, 9, 10, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3099), "Message 72 info", "user1", "user2" },
                    { 73, new DateTime(2024, 9, 9, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3145), "Message 73 info", "user2", "user3" },
                    { 74, new DateTime(2024, 9, 8, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3216), "Message 74 info", "user3", "user1" },
                    { 75, new DateTime(2024, 9, 7, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3262), "Message 75 info", "user1", "user2" },
                    { 76, new DateTime(2024, 9, 6, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3308), "Message 76 info", "user2", "user3" },
                    { 77, new DateTime(2024, 9, 5, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3381), "Message 77 info", "user3", "user1" },
                    { 78, new DateTime(2024, 9, 4, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3428), "Message 78 info", "user1", "user2" },
                    { 79, new DateTime(2024, 9, 3, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3476), "Message 79 info", "user2", "user3" },
                    { 80, new DateTime(2024, 9, 2, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3553), "Message 80 info", "user3", "user1" },
                    { 81, new DateTime(2024, 9, 1, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3598), "Message 81 info", "user1", "user2" },
                    { 82, new DateTime(2024, 8, 31, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3646), "Message 82 info", "user2", "user3" },
                    { 83, new DateTime(2024, 8, 30, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3721), "Message 83 info", "user3", "user1" },
                    { 84, new DateTime(2024, 8, 29, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3767), "Message 84 info", "user1", "user2" },
                    { 85, new DateTime(2024, 8, 28, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3814), "Message 85 info", "user2", "user3" },
                    { 86, new DateTime(2024, 8, 27, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3886), "Message 86 info", "user3", "user1" },
                    { 87, new DateTime(2024, 8, 26, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3933), "Message 87 info", "user1", "user2" },
                    { 88, new DateTime(2024, 8, 25, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3979), "Message 88 info", "user2", "user3" },
                    { 89, new DateTime(2024, 8, 24, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4047), "Message 89 info", "user3", "user1" },
                    { 90, new DateTime(2024, 8, 23, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4094), "Message 90 info", "user1", "user2" },
                    { 91, new DateTime(2024, 8, 22, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4138), "Message 91 info", "user2", "user3" },
                    { 92, new DateTime(2024, 8, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4206), "Message 92 info", "user3", "user1" },
                    { 93, new DateTime(2024, 8, 20, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4254), "Message 93 info", "user1", "user2" },
                    { 94, new DateTime(2024, 8, 19, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4302), "Message 94 info", "user2", "user3" },
                    { 95, new DateTime(2024, 8, 18, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4350), "Message 95 info", "user3", "user1" },
                    { 96, new DateTime(2024, 8, 17, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4418), "Message 96 info", "user1", "user2" },
                    { 97, new DateTime(2024, 8, 16, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4465), "Message 97 info", "user2", "user3" },
                    { 98, new DateTime(2024, 8, 15, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4513), "Message 98 info", "user3", "user1" },
                    { 99, new DateTime(2024, 8, 14, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4580), "Message 99 info", "user1", "user2" },
                    { 100, new DateTime(2024, 8, 13, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4626), "Message 100 info", "user2", "user3" }
                });

            migrationBuilder.UpdateData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Type", "Value" },
                values: new object[] { "Observation Type 1", 51.0 });

            migrationBuilder.UpdateData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Type", "Value" },
                values: new object[] { "Observation Type 2", 52.0 });

            migrationBuilder.UpdateData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Type", "Value" },
                values: new object[] { "Observation Type 3", 53.0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName", "UserId" },
                values: new object[] { 21, "FirstName1", "LastName1", "user2" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName", "UserId" },
                values: new object[] { 22, "FirstName2", "LastName2", "user3" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "UserId" },
                values: new object[] { 100, 20, "FirstName100", "LastName100", "user1" });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "ConditionName", "PatientId" },
                values: new object[] { 100, "Condition 100", 100 });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Date", "PatientId" },
                values: new object[] { 100, new DateTime(2016, 7, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4647), 100 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName", "UserId" },
                values: new object[] { 23, "FirstName3", "LastName3", "user4" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 4, 24, "FirstName4", "LastName4", "user5" },
                    { 5, 25, "FirstName5", "LastName5", "user6" },
                    { 6, 26, "FirstName6", "LastName6", "user7" },
                    { 7, 27, "FirstName7", "LastName7", "user8" },
                    { 8, 28, "FirstName8", "LastName8", "user9" },
                    { 9, 29, "FirstName9", "LastName9", "user10" },
                    { 10, 30, "FirstName10", "LastName10", "user11" },
                    { 11, 31, "FirstName11", "LastName11", "user12" },
                    { 12, 32, "FirstName12", "LastName12", "user13" },
                    { 13, 33, "FirstName13", "LastName13", "user14" },
                    { 14, 34, "FirstName14", "LastName14", "user15" },
                    { 15, 35, "FirstName15", "LastName15", "user16" },
                    { 16, 36, "FirstName16", "LastName16", "user17" },
                    { 17, 37, "FirstName17", "LastName17", "user18" },
                    { 18, 38, "FirstName18", "LastName18", "user19" },
                    { 19, 39, "FirstName19", "LastName19", "user20" },
                    { 20, 40, "FirstName20", "LastName20", "user21" },
                    { 21, 41, "FirstName21", "LastName21", "user22" },
                    { 22, 42, "FirstName22", "LastName22", "user23" },
                    { 23, 43, "FirstName23", "LastName23", "user24" },
                    { 24, 44, "FirstName24", "LastName24", "user25" },
                    { 25, 45, "FirstName25", "LastName25", "user26" },
                    { 26, 46, "FirstName26", "LastName26", "user27" },
                    { 27, 47, "FirstName27", "LastName27", "user28" },
                    { 28, 48, "FirstName28", "LastName28", "user29" },
                    { 29, 49, "FirstName29", "LastName29", "user30" },
                    { 30, 50, "FirstName30", "LastName30", "user31" },
                    { 31, 51, "FirstName31", "LastName31", "user32" },
                    { 32, 52, "FirstName32", "LastName32", "user33" },
                    { 33, 53, "FirstName33", "LastName33", "user34" },
                    { 34, 54, "FirstName34", "LastName34", "user35" },
                    { 35, 55, "FirstName35", "LastName35", "user36" },
                    { 36, 56, "FirstName36", "LastName36", "user37" },
                    { 37, 57, "FirstName37", "LastName37", "user38" },
                    { 38, 58, "FirstName38", "LastName38", "user39" },
                    { 39, 59, "FirstName39", "LastName39", "user40" },
                    { 40, 60, "FirstName40", "LastName40", "user41" },
                    { 41, 61, "FirstName41", "LastName41", "user42" },
                    { 42, 62, "FirstName42", "LastName42", "user43" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 43, 63, "FirstName43", "LastName43", "user44" },
                    { 44, 64, "FirstName44", "LastName44", "user45" },
                    { 45, 65, "FirstName45", "LastName45", "user46" },
                    { 46, 66, "FirstName46", "LastName46", "user47" },
                    { 47, 67, "FirstName47", "LastName47", "user48" },
                    { 48, 68, "FirstName48", "LastName48", "user49" },
                    { 49, 69, "FirstName49", "LastName49", "user50" },
                    { 50, 20, "FirstName50", "LastName50", "user51" },
                    { 51, 21, "FirstName51", "LastName51", "user52" },
                    { 52, 22, "FirstName52", "LastName52", "user53" },
                    { 53, 23, "FirstName53", "LastName53", "user54" },
                    { 54, 24, "FirstName54", "LastName54", "user55" },
                    { 55, 25, "FirstName55", "LastName55", "user56" },
                    { 56, 26, "FirstName56", "LastName56", "user57" },
                    { 57, 27, "FirstName57", "LastName57", "user58" },
                    { 58, 28, "FirstName58", "LastName58", "user59" },
                    { 59, 29, "FirstName59", "LastName59", "user60" },
                    { 60, 30, "FirstName60", "LastName60", "user61" },
                    { 61, 31, "FirstName61", "LastName61", "user62" },
                    { 62, 32, "FirstName62", "LastName62", "user63" },
                    { 63, 33, "FirstName63", "LastName63", "user64" },
                    { 64, 34, "FirstName64", "LastName64", "user65" },
                    { 65, 35, "FirstName65", "LastName65", "user66" },
                    { 66, 36, "FirstName66", "LastName66", "user67" },
                    { 67, 37, "FirstName67", "LastName67", "user68" },
                    { 68, 38, "FirstName68", "LastName68", "user69" },
                    { 69, 39, "FirstName69", "LastName69", "user70" },
                    { 70, 40, "FirstName70", "LastName70", "user71" },
                    { 71, 41, "FirstName71", "LastName71", "user72" },
                    { 72, 42, "FirstName72", "LastName72", "user73" },
                    { 73, 43, "FirstName73", "LastName73", "user74" },
                    { 74, 44, "FirstName74", "LastName74", "user75" },
                    { 75, 45, "FirstName75", "LastName75", "user76" },
                    { 76, 46, "FirstName76", "LastName76", "user77" },
                    { 77, 47, "FirstName77", "LastName77", "user78" },
                    { 78, 48, "FirstName78", "LastName78", "user79" },
                    { 79, 49, "FirstName79", "LastName79", "user80" },
                    { 80, 50, "FirstName80", "LastName80", "user81" },
                    { 81, 51, "FirstName81", "LastName81", "user82" },
                    { 82, 52, "FirstName82", "LastName82", "user83" },
                    { 83, 53, "FirstName83", "LastName83", "user84" },
                    { 84, 54, "FirstName84", "LastName84", "user85" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 85, 55, "FirstName85", "LastName85", "user86" },
                    { 86, 56, "FirstName86", "LastName86", "user87" },
                    { 87, 57, "FirstName87", "LastName87", "user88" },
                    { 88, 58, "FirstName88", "LastName88", "user89" },
                    { 89, 59, "FirstName89", "LastName89", "user90" },
                    { 90, 60, "FirstName90", "LastName90", "user91" },
                    { 91, 61, "FirstName91", "LastName91", "user92" },
                    { 92, 62, "FirstName92", "LastName92", "user93" },
                    { 93, 63, "FirstName93", "LastName93", "user94" },
                    { 94, 64, "FirstName94", "LastName94", "user95" },
                    { 95, 65, "FirstName95", "LastName95", "user96" },
                    { 96, 66, "FirstName96", "LastName96", "user97" },
                    { 97, 67, "FirstName97", "LastName97", "user98" },
                    { 98, 68, "FirstName98", "LastName98", "user99" },
                    { 99, 69, "FirstName99", "LastName99", "user100" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "ConditionName", "PatientId" },
                values: new object[,]
                {
                    { 4, "Condition 4", 4 },
                    { 5, "Condition 5", 5 },
                    { 6, "Condition 6", 6 },
                    { 7, "Condition 7", 7 },
                    { 8, "Condition 8", 8 },
                    { 9, "Condition 9", 9 },
                    { 10, "Condition 10", 10 },
                    { 11, "Condition 11", 11 },
                    { 12, "Condition 12", 12 },
                    { 13, "Condition 13", 13 },
                    { 14, "Condition 14", 14 },
                    { 15, "Condition 15", 15 },
                    { 16, "Condition 16", 16 },
                    { 17, "Condition 17", 17 },
                    { 18, "Condition 18", 18 },
                    { 19, "Condition 19", 19 },
                    { 20, "Condition 20", 20 },
                    { 21, "Condition 21", 21 },
                    { 22, "Condition 22", 22 },
                    { 23, "Condition 23", 23 },
                    { 24, "Condition 24", 24 },
                    { 25, "Condition 25", 25 },
                    { 26, "Condition 26", 26 },
                    { 27, "Condition 27", 27 },
                    { 28, "Condition 28", 28 },
                    { 29, "Condition 29", 29 },
                    { 30, "Condition 30", 30 },
                    { 31, "Condition 31", 31 },
                    { 32, "Condition 32", 32 },
                    { 33, "Condition 33", 33 },
                    { 34, "Condition 34", 34 },
                    { 35, "Condition 35", 35 },
                    { 36, "Condition 36", 36 },
                    { 37, "Condition 37", 37 },
                    { 38, "Condition 38", 38 },
                    { 39, "Condition 39", 39 },
                    { 40, "Condition 40", 40 },
                    { 41, "Condition 41", 41 },
                    { 42, "Condition 42", 42 },
                    { 43, "Condition 43", 43 },
                    { 44, "Condition 44", 44 },
                    { 45, "Condition 45", 45 }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "ConditionName", "PatientId" },
                values: new object[,]
                {
                    { 46, "Condition 46", 46 },
                    { 47, "Condition 47", 47 },
                    { 48, "Condition 48", 48 },
                    { 49, "Condition 49", 49 },
                    { 50, "Condition 50", 50 },
                    { 51, "Condition 51", 51 },
                    { 52, "Condition 52", 52 },
                    { 53, "Condition 53", 53 },
                    { 54, "Condition 54", 54 },
                    { 55, "Condition 55", 55 },
                    { 56, "Condition 56", 56 },
                    { 57, "Condition 57", 57 },
                    { 58, "Condition 58", 58 },
                    { 59, "Condition 59", 59 },
                    { 60, "Condition 60", 60 },
                    { 61, "Condition 61", 61 },
                    { 62, "Condition 62", 62 },
                    { 63, "Condition 63", 63 },
                    { 64, "Condition 64", 64 },
                    { 65, "Condition 65", 65 },
                    { 66, "Condition 66", 66 },
                    { 67, "Condition 67", 67 },
                    { 68, "Condition 68", 68 },
                    { 69, "Condition 69", 69 },
                    { 70, "Condition 70", 70 },
                    { 71, "Condition 71", 71 },
                    { 72, "Condition 72", 72 },
                    { 73, "Condition 73", 73 },
                    { 74, "Condition 74", 74 },
                    { 75, "Condition 75", 75 },
                    { 76, "Condition 76", 76 },
                    { 77, "Condition 77", 77 },
                    { 78, "Condition 78", 78 },
                    { 79, "Condition 79", 79 },
                    { 80, "Condition 80", 80 },
                    { 81, "Condition 81", 81 },
                    { 82, "Condition 82", 82 },
                    { 83, "Condition 83", 83 },
                    { 84, "Condition 84", 84 },
                    { 85, "Condition 85", 85 },
                    { 86, "Condition 86", 86 },
                    { 87, "Condition 87", 87 }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "ConditionName", "PatientId" },
                values: new object[,]
                {
                    { 88, "Condition 88", 88 },
                    { 89, "Condition 89", 89 },
                    { 90, "Condition 90", 90 },
                    { 91, "Condition 91", 91 },
                    { 92, "Condition 92", 92 },
                    { 93, "Condition 93", 93 },
                    { 94, "Condition 94", 94 },
                    { 95, "Condition 95", 95 },
                    { 96, "Condition 96", 96 },
                    { 97, "Condition 97", 97 },
                    { 98, "Condition 98", 98 },
                    { 99, "Condition 99", 99 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Date", "PatientId" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 7, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9310), 4 },
                    { 5, new DateTime(2024, 6, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9390), 5 },
                    { 6, new DateTime(2024, 5, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9442), 6 },
                    { 7, new DateTime(2024, 4, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9491), 7 },
                    { 8, new DateTime(2024, 3, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9579), 8 },
                    { 9, new DateTime(2024, 2, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9631), 9 },
                    { 10, new DateTime(2024, 1, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9682), 10 },
                    { 11, new DateTime(2023, 12, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9750), 11 },
                    { 12, new DateTime(2023, 11, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9797), 12 },
                    { 13, new DateTime(2023, 10, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9844), 13 },
                    { 14, new DateTime(2023, 9, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9916), 14 },
                    { 15, new DateTime(2023, 8, 21, 17, 18, 5, 354, DateTimeKind.Local).AddTicks(9965), 15 },
                    { 16, new DateTime(2023, 7, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(12), 16 },
                    { 17, new DateTime(2023, 6, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(84), 17 },
                    { 18, new DateTime(2023, 5, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(135), 18 },
                    { 19, new DateTime(2023, 4, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(181), 19 },
                    { 20, new DateTime(2023, 3, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(248), 20 },
                    { 21, new DateTime(2023, 2, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(297), 21 },
                    { 22, new DateTime(2023, 1, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(342), 22 },
                    { 23, new DateTime(2022, 12, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(413), 23 },
                    { 24, new DateTime(2022, 11, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(460), 24 },
                    { 25, new DateTime(2022, 10, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(506), 25 },
                    { 26, new DateTime(2022, 9, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(574), 26 },
                    { 27, new DateTime(2022, 8, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(622), 27 },
                    { 28, new DateTime(2022, 7, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(669), 28 },
                    { 29, new DateTime(2022, 6, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(719), 29 },
                    { 30, new DateTime(2022, 5, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(791), 30 },
                    { 31, new DateTime(2022, 4, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(840), 31 },
                    { 32, new DateTime(2022, 3, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(887), 32 },
                    { 33, new DateTime(2022, 2, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(971), 33 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Date", "PatientId" },
                values: new object[,]
                {
                    { 34, new DateTime(2022, 1, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1021), 34 },
                    { 35, new DateTime(2021, 12, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1095), 35 },
                    { 36, new DateTime(2021, 11, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1141), 36 },
                    { 37, new DateTime(2021, 10, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1189), 37 },
                    { 38, new DateTime(2021, 9, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1258), 38 },
                    { 39, new DateTime(2021, 8, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1308), 39 },
                    { 40, new DateTime(2021, 7, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1351), 40 },
                    { 41, new DateTime(2021, 6, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1421), 41 },
                    { 42, new DateTime(2021, 5, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1469), 42 },
                    { 43, new DateTime(2021, 4, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1515), 43 },
                    { 44, new DateTime(2021, 3, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1583), 44 },
                    { 45, new DateTime(2021, 2, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1630), 45 },
                    { 46, new DateTime(2021, 1, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1674), 46 },
                    { 47, new DateTime(2020, 12, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1746), 47 },
                    { 48, new DateTime(2020, 11, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1793), 48 },
                    { 49, new DateTime(2020, 10, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1838), 49 },
                    { 50, new DateTime(2020, 9, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1910), 50 },
                    { 51, new DateTime(2020, 8, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(1957), 51 },
                    { 52, new DateTime(2020, 7, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2003), 52 },
                    { 53, new DateTime(2020, 6, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2051), 53 },
                    { 54, new DateTime(2020, 5, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2120), 54 },
                    { 55, new DateTime(2020, 4, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2168), 55 },
                    { 56, new DateTime(2020, 3, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2215), 56 },
                    { 57, new DateTime(2020, 2, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2293), 57 },
                    { 58, new DateTime(2020, 1, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2339), 58 },
                    { 59, new DateTime(2019, 12, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2384), 59 },
                    { 60, new DateTime(2019, 11, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2455), 60 },
                    { 61, new DateTime(2019, 10, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2505), 61 },
                    { 62, new DateTime(2019, 9, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2551), 62 },
                    { 63, new DateTime(2019, 8, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2621), 63 },
                    { 64, new DateTime(2019, 7, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2664), 64 },
                    { 65, new DateTime(2019, 6, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2736), 65 },
                    { 66, new DateTime(2019, 5, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2786), 66 },
                    { 67, new DateTime(2019, 4, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2858), 67 },
                    { 68, new DateTime(2019, 3, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2905), 68 },
                    { 69, new DateTime(2019, 2, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(2954), 69 },
                    { 70, new DateTime(2019, 1, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3025), 70 },
                    { 71, new DateTime(2018, 12, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3073), 71 },
                    { 72, new DateTime(2018, 11, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3120), 72 },
                    { 73, new DateTime(2018, 10, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3188), 73 },
                    { 74, new DateTime(2018, 9, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3237), 74 },
                    { 75, new DateTime(2018, 8, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3283), 75 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Date", "PatientId" },
                values: new object[,]
                {
                    { 76, new DateTime(2018, 7, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3352), 76 },
                    { 77, new DateTime(2018, 6, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3401), 77 },
                    { 78, new DateTime(2018, 5, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3448), 78 },
                    { 79, new DateTime(2018, 4, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3525), 79 },
                    { 80, new DateTime(2018, 3, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3573), 80 },
                    { 81, new DateTime(2018, 2, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3618), 81 },
                    { 82, new DateTime(2018, 1, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3665), 82 },
                    { 83, new DateTime(2017, 12, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3740), 83 },
                    { 84, new DateTime(2017, 11, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3787), 84 },
                    { 85, new DateTime(2017, 10, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3835), 85 },
                    { 86, new DateTime(2017, 9, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3907), 86 },
                    { 87, new DateTime(2017, 8, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3953), 87 },
                    { 88, new DateTime(2017, 7, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(3999), 88 },
                    { 89, new DateTime(2017, 6, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4066), 89 },
                    { 90, new DateTime(2017, 5, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4113), 90 },
                    { 91, new DateTime(2017, 4, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4158), 91 },
                    { 92, new DateTime(2017, 3, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4227), 92 },
                    { 93, new DateTime(2017, 2, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4275), 93 },
                    { 94, new DateTime(2017, 1, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4322), 94 },
                    { 95, new DateTime(2016, 12, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4392), 95 },
                    { 96, new DateTime(2016, 11, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4438), 96 },
                    { 97, new DateTime(2016, 10, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4485), 97 },
                    { 98, new DateTime(2016, 9, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4554), 98 },
                    { 99, new DateTime(2016, 8, 21, 17, 18, 5, 355, DateTimeKind.Local).AddTicks(4600), 99 }
                });

            migrationBuilder.InsertData(
                table: "Observations",
                columns: new[] { "Id", "EncounterId", "PatientId", "Type", "Value" },
                values: new object[] { 100, 100, 100, "Observation Type 100", 50.0 });

            migrationBuilder.InsertData(
                table: "Observations",
                columns: new[] { "Id", "EncounterId", "PatientId", "Type", "Value" },
                values: new object[,]
                {
                    { 4, 4, 4, "Observation Type 4", 54.0 },
                    { 5, 5, 5, "Observation Type 5", 55.0 },
                    { 6, 6, 6, "Observation Type 6", 56.0 },
                    { 7, 7, 7, "Observation Type 7", 57.0 },
                    { 8, 8, 8, "Observation Type 8", 58.0 },
                    { 9, 9, 9, "Observation Type 9", 59.0 },
                    { 10, 10, 10, "Observation Type 10", 60.0 },
                    { 11, 11, 11, "Observation Type 11", 61.0 },
                    { 12, 12, 12, "Observation Type 12", 62.0 },
                    { 13, 13, 13, "Observation Type 13", 63.0 },
                    { 14, 14, 14, "Observation Type 14", 64.0 },
                    { 15, 15, 15, "Observation Type 15", 65.0 },
                    { 16, 16, 16, "Observation Type 16", 66.0 },
                    { 17, 17, 17, "Observation Type 17", 67.0 },
                    { 18, 18, 18, "Observation Type 18", 68.0 },
                    { 19, 19, 19, "Observation Type 19", 69.0 },
                    { 20, 20, 20, "Observation Type 20", 70.0 },
                    { 21, 21, 21, "Observation Type 21", 71.0 },
                    { 22, 22, 22, "Observation Type 22", 72.0 },
                    { 23, 23, 23, "Observation Type 23", 73.0 },
                    { 24, 24, 24, "Observation Type 24", 74.0 },
                    { 25, 25, 25, "Observation Type 25", 75.0 },
                    { 26, 26, 26, "Observation Type 26", 76.0 },
                    { 27, 27, 27, "Observation Type 27", 77.0 },
                    { 28, 28, 28, "Observation Type 28", 78.0 },
                    { 29, 29, 29, "Observation Type 29", 79.0 },
                    { 30, 30, 30, "Observation Type 30", 80.0 },
                    { 31, 31, 31, "Observation Type 31", 81.0 },
                    { 32, 32, 32, "Observation Type 32", 82.0 },
                    { 33, 33, 33, "Observation Type 33", 83.0 },
                    { 34, 34, 34, "Observation Type 34", 84.0 },
                    { 35, 35, 35, "Observation Type 35", 85.0 },
                    { 36, 36, 36, "Observation Type 36", 86.0 },
                    { 37, 37, 37, "Observation Type 37", 87.0 },
                    { 38, 38, 38, "Observation Type 38", 88.0 },
                    { 39, 39, 39, "Observation Type 39", 89.0 },
                    { 40, 40, 40, "Observation Type 40", 90.0 },
                    { 41, 41, 41, "Observation Type 41", 91.0 },
                    { 42, 42, 42, "Observation Type 42", 92.0 },
                    { 43, 43, 43, "Observation Type 43", 93.0 },
                    { 44, 44, 44, "Observation Type 44", 94.0 },
                    { 45, 45, 45, "Observation Type 45", 95.0 }
                });

            migrationBuilder.InsertData(
                table: "Observations",
                columns: new[] { "Id", "EncounterId", "PatientId", "Type", "Value" },
                values: new object[,]
                {
                    { 46, 46, 46, "Observation Type 46", 96.0 },
                    { 47, 47, 47, "Observation Type 47", 97.0 },
                    { 48, 48, 48, "Observation Type 48", 98.0 },
                    { 49, 49, 49, "Observation Type 49", 99.0 },
                    { 50, 50, 50, "Observation Type 50", 100.0 },
                    { 51, 51, 51, "Observation Type 51", 101.0 },
                    { 52, 52, 52, "Observation Type 52", 102.0 },
                    { 53, 53, 53, "Observation Type 53", 103.0 },
                    { 54, 54, 54, "Observation Type 54", 104.0 },
                    { 55, 55, 55, "Observation Type 55", 105.0 },
                    { 56, 56, 56, "Observation Type 56", 106.0 },
                    { 57, 57, 57, "Observation Type 57", 107.0 },
                    { 58, 58, 58, "Observation Type 58", 108.0 },
                    { 59, 59, 59, "Observation Type 59", 109.0 },
                    { 60, 60, 60, "Observation Type 60", 110.0 },
                    { 61, 61, 61, "Observation Type 61", 111.0 },
                    { 62, 62, 62, "Observation Type 62", 112.0 },
                    { 63, 63, 63, "Observation Type 63", 113.0 },
                    { 64, 64, 64, "Observation Type 64", 114.0 },
                    { 65, 65, 65, "Observation Type 65", 115.0 },
                    { 66, 66, 66, "Observation Type 66", 116.0 },
                    { 67, 67, 67, "Observation Type 67", 117.0 },
                    { 68, 68, 68, "Observation Type 68", 118.0 },
                    { 69, 69, 69, "Observation Type 69", 119.0 },
                    { 70, 70, 70, "Observation Type 70", 120.0 },
                    { 71, 71, 71, "Observation Type 71", 121.0 },
                    { 72, 72, 72, "Observation Type 72", 122.0 },
                    { 73, 73, 73, "Observation Type 73", 123.0 },
                    { 74, 74, 74, "Observation Type 74", 124.0 },
                    { 75, 75, 75, "Observation Type 75", 125.0 },
                    { 76, 76, 76, "Observation Type 76", 126.0 },
                    { 77, 77, 77, "Observation Type 77", 127.0 },
                    { 78, 78, 78, "Observation Type 78", 128.0 },
                    { 79, 79, 79, "Observation Type 79", 129.0 },
                    { 80, 80, 80, "Observation Type 80", 130.0 },
                    { 81, 81, 81, "Observation Type 81", 131.0 },
                    { 82, 82, 82, "Observation Type 82", 132.0 },
                    { 83, 83, 83, "Observation Type 83", 133.0 },
                    { 84, 84, 84, "Observation Type 84", 134.0 },
                    { 85, 85, 85, "Observation Type 85", 135.0 },
                    { 86, 86, 86, "Observation Type 86", 136.0 },
                    { 87, 87, 87, "Observation Type 87", 137.0 }
                });

            migrationBuilder.InsertData(
                table: "Observations",
                columns: new[] { "Id", "EncounterId", "PatientId", "Type", "Value" },
                values: new object[,]
                {
                    { 88, 88, 88, "Observation Type 88", 138.0 },
                    { 89, 89, 89, "Observation Type 89", 139.0 },
                    { 90, 90, 90, "Observation Type 90", 140.0 },
                    { 91, 91, 91, "Observation Type 91", 141.0 },
                    { 92, 92, 92, "Observation Type 92", 142.0 },
                    { 93, 93, 93, "Observation Type 93", 143.0 },
                    { 94, 94, 94, "Observation Type 94", 144.0 },
                    { 95, 95, 95, "Observation Type 95", 145.0 },
                    { 96, 96, 96, "Observation Type 96", 146.0 },
                    { 97, 97, 97, "Observation Type 97", 147.0 },
                    { 98, 98, 98, "Observation Type 98", 148.0 },
                    { 99, 99, 99, "Observation Type 99", 149.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3caf46f3-af4b-4372-9548-a3e03e79c2c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55641d84-5c0c-4e14-b7ca-c74dc5793ca0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4");

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user100");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user99");

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
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConditionName",
                value: "Hypertension");

            migrationBuilder.UpdateData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConditionName",
                value: "Diabetes");

            migrationBuilder.UpdateData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConditionName",
                value: "Asthma");

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
                columns: new[] { "Date", "Info", "ReceiverId", "SenderId" },
                values: new object[] { new DateTime(2024, 11, 11, 1, 9, 3, 374, DateTimeKind.Local).AddTicks(8113), "Follow-up appointment scheduled.", "user1", "user2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Info", "ReceiverId" },
                values: new object[] { new DateTime(2024, 11, 12, 1, 9, 3, 374, DateTimeKind.Local).AddTicks(8148), "Please bring medical reports.", "user2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Info", "ReceiverId", "SenderId" },
                values: new object[] { new DateTime(2024, 11, 13, 1, 9, 3, 374, DateTimeKind.Local).AddTicks(8150), "Lab results ready.", "user3", "user1" });

            migrationBuilder.UpdateData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Type", "Value" },
                values: new object[] { "Blood Pressure", 130.5 });

            migrationBuilder.UpdateData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Type", "Value" },
                values: new object[] { "Blood Sugar", 7.5 });

            migrationBuilder.UpdateData(
                table: "Observations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Type", "Value" },
                values: new object[] { "Peak Flow", 350.0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName", "UserId" },
                values: new object[] { 45, "John", "Doe", "user1" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName", "UserId" },
                values: new object[] { 32, "Jane", "Smith", "user2" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName", "UserId" },
                values: new object[] { 28, "Tom", "Brown", "user3" });
        }
    }
}
