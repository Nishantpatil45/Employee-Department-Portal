using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpDeptPortal.Migrations
{
    public partial class AddUpdateDeptTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeptName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeptName",
                table: "Employees");
        }
    }
}
