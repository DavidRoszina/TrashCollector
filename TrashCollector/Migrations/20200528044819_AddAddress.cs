using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a23887f-1425-4d43-8124-2d073e3d64e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf9edb83-32d5-469a-93ac-26fd196c39b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d76dab77-a993-4bc7-b266-b35a1bfdf241");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1be4a61e-14dc-4cbf-a9fe-49e3f3edb163", "ce203d99-83b2-4a18-8130-a0af1189ee14", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29b49039-aafb-4031-8135-378881c6829a", "fcc47e82-9602-4e0a-8b15-77dbf23fb46e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1be4a61e-14dc-4cbf-a9fe-49e3f3edb163");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29b49039-aafb-4031-8135-378881c6829a");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d76dab77-a993-4bc7-b266-b35a1bfdf241", "6c049c8b-60be-4383-93bd-d05252b896bd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf9edb83-32d5-469a-93ac-26fd196c39b8", "ef44e572-204b-40a3-989a-2b5b37a33646", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a23887f-1425-4d43-8124-2d073e3d64e6", "f286ffa8-2926-458c-8dfc-12a4ae42b9cc", "Employee", "EMPLOYEE" });
        }
    }
}
